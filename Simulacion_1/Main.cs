using Simulacion_1.Clases;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Simulacion_1
{
    public partial class Simulacion_1 : Form
    {
        #region Constructor

        public Simulacion_1()
        {
            InitializeComponent();
            string nombres = " Dagotto, Florencia Agustina - Donalisio, Juan Pablo - Medina, Juan Cruz - Spini, Leila Aylén - Parrucci, Lara Estefania \t\t- 4K4 \t- 2021";
            lblNombres.Text = nombres;
            lblNombres.ForeColor = Color.FromArgb(255, 255, 255);
            InicializarFormulario();
        }

        #endregion

        #region Propiedades
        public IMetodoGeneracion Metodo { get; set; }
        public List<Iteracion> Iteraciones { get; set; }
        public int MostrarDesde { get; set; }
        private Display DisplayForm { get; set; }
        #endregion

        #region Métodos privados
        private void InicializarFormulario()
        {
            cboMetodo.SelectedIndex = 0;
            Iteraciones = new List<Iteracion>();
            LimpiarGrilla();
            dgvChi.DataSource = null;
            MostrarDesde = 0;
        }
        private void HabilitarTxt(bool habilitar)
        {
            var campos = new List<TextBoxBase> { txt_a, txt_c, txt_m, txt_k, txt_g, txt_semilla };
            campos.ForEach(d => d.Enabled = habilitar);
        }
        private void CargarGrillaChi(DataGridView grilla, TestChi lista)
        {
            grilla.Rows.Clear();
            string intervalo;
            for (int i = 0; i < lista.Intervalos.Length; i++)
            {
                if (i == 0) intervalo = "0 - " + Convert.ToDouble(lista.Intervalos[i].ToString("#.00"));
                else intervalo = Convert.ToDouble(lista.Intervalos[i - 1].ToString("#.00")) + " - " + Convert.ToDouble(lista.Intervalos[i].ToString("#.00"));
                var intv = intervalo;
                var _fo = Convert.ToDouble(lista.Fo[i].ToString("#.00"));
                var _fe = Convert.ToDouble(lista.Fe[i].ToString("#.00"));
                var _c = Convert.ToDouble(lista.C[i].ToString("#.00"));
                var _cac = Convert.ToDouble(lista.Cac[i].ToString("#.00"));
                grilla.Rows.Add(intv, _fo, _fe, _c, _cac);
            }
            dgvChi.Refresh();
        }
        private Condiciones GetCondiciones()
        {
            return new Condiciones()
            {
                A = int.TryParse(txt_a.Text, out int a) ? a : 0,
                C = int.TryParse(txt_c.Text, out int c) ? c : 0,
                M = int.TryParse(txt_m.Text, out int m) ? m : 0,
                K = int.TryParse(txt_k.Text, out int k) ? k : 0,
                G = int.TryParse(txt_g.Text, out int g) ? g : 0,
                Semilla = int.TryParse(txt_semilla.Text, out int s) ? s : 0,
                Cantidad = int.TryParse(txt_cantidad.Text, out int cant) ? cant : 0,
            };
        }
        private ChiCuadradoCondiciones GetCondicionesChi()
        {
            return new ChiCuadradoCondiciones()
            {
                Subintervalos = int.TryParse(txt_intervalos.Text, out int intervalos) ? intervalos : 0,
                Confianza = 95,
            };
        }
        private bool TestChi()
        {
            try
            {
                if (cboMetodo.SelectedIndex != 0 && cboMetodo.SelectedIndex != 2)
                    throw new Exception("El test de Chi Cuadrado está implementado para los métodos congruencial mixto y del lenguaje");
                if (Iteraciones.Count == 0)
                    throw new Exception("Debe generar la lista de números pseudoaleatorios para realizar la prueba");

                dgvChi.DataSource = null;
                ChiCuadradoCondiciones condiciones = GetCondicionesChi();
                TestChi tstChi = new TestChi(Iteraciones, condiciones.Subintervalos);
                bool rechazada = tstChi.Procesar(Iteraciones);

                CargarGrillaChi(dgvChi, tstChi);
                DisplayForm = new Display(tstChi.Intervalos, tstChi.Fe, tstChi.Fo);

                string msg = "Resultado: Con los grados de libertad " + (tstChi.Intervalos.Length - 1) + " se obtuvo un valor calculado de " + (tstChi.Cac[tstChi.Cac.Length - 1]) + ".\nSe obtuvo un valor crítico de " + tstChi.ValorCritico + ", por lo tanto, la hipótesis ";
                msg += rechazada ? "fue rechazada" : "no puede ser rechazada";
                lblResultado.Text = msg;
                lblResultado.Font = new Font("gothic century", lblResultado.Font.Size);
                lblResultado.ForeColor = Color.FromArgb(255, 255, 255);
                return rechazada;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #region Generación de números

        private void LimpiarGrilla()
        {
            dgvMetodo.DataSource = new List<object>();
            dgvMetodo.Refresh();
        }

        private IList GenerarNumeros()
        {
            List<Iteracion> listaDataSource;
            try
            {
                var condiciones = GetCondiciones();
                if (cboMetodo.SelectedIndex != 2)
                {
                    if ((condiciones.A == 0 && condiciones.K == 0) || (condiciones.M == 0 && condiciones.G == 0))
                        throw new Exception("Ingrese valores para la generación de los números pseudoaleatorios");
                    if (condiciones.M == 0) condiciones.M = (int)Math.Pow(2, condiciones.G);
                }

                if (cboMetodo.SelectedIndex == 0)
                {
                    if (condiciones.A == 0) condiciones.A = 1 + 4 * condiciones.K;
                    if (!EsPrimoRelativo(condiciones.M, condiciones.C)) throw new Exception("El valor de C debe ser primo relativo del valor de M");

                    Metodo = new CongruencialMixto(condiciones.M, condiciones.A, condiciones.Semilla, condiciones.C, condiciones.G, condiciones.K, condiciones.Cantidad);
                }
                else if (cboMetodo.SelectedIndex == 1)
                {
                    if (condiciones.A == 0)
                        condiciones.A = 3 + 8 * condiciones.K;
                    if (condiciones.Semilla % 2 == 0)
                        throw new Exception("El valor de la semilla debe ser impar");

                    Metodo = new CongruencialMultiplicativo(condiciones.M, condiciones.A, condiciones.Semilla, condiciones.G, condiciones.K, condiciones.Cantidad);
                }
                else
                    Metodo = new DelLenguaje(condiciones.M, condiciones.A, condiciones.G, condiciones.K, condiciones.Semilla, condiciones.Cantidad);

                Metodo.GenerarValores();
                listaDataSource = GenerarLista(Metodo.GetValores());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listaDataSource = null;
            }
            return listaDataSource;
        }


        private bool EsPrimoRelativo(int numero1, int numero2)
        {
            //calcular el maximo divisor común
            int resto;
            while (numero2 != 0)
            {
                resto = numero1 % numero2;
                numero1 = numero2;
                numero2 = resto;
            }

            //si el el resultado es igual a 1 o a -1, son relativos, si no, no.
            return numero1 == 1 || numero1 == -1;
        }

        private void MostrarDataSource(IList lista)
        {
            LimpiarGrilla();
            dgvMetodo.DataSource = lista;
            dgvMetodo.Refresh();
        }

        private List<Iteracion> MostrarPorCantidad(int cantidad = 20)
        {
            try
            {
                if (Iteraciones is null)
                    return Iteraciones;
                if (MostrarDesde + 20 > Iteraciones.Count - 1)
                {
                    cantidad = (Iteraciones.Count - MostrarDesde);
                    btnProximo.Enabled = false;
                }
                List<Iteracion> lst = Iteraciones.GetRange(MostrarDesde, cantidad);
                MostrarDesde += cantidad;
                return lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void Generar()
        {
            LimpiarGrilla();
            dgvChi.DataSource = null;
            MostrarDesde = 0;
            Iteraciones = GenerarNumeros() as List<Iteracion>;
            if (Iteraciones == null) return;
            HabilitarProximos(20);
            MostrarDataSource(MostrarPorCantidad());
        }

        private void AplicarRango()
        {
            int desde = int.Parse(txt_desde.Text), hasta = int.Parse(txt_hasta.Text);
            if (desde > hasta || desde < 0) MessageBox.Show("Los valores 'desde' y 'hasta' no son correctos. Ingrese un rango válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            HabilitarProximos(hasta);
            MostrarDesde = hasta;
            MostrarDataSource(Iteraciones.Where(x => x.Indice >= desde && x.Indice <= hasta).ToList());
        }

        //private void ObtenerProximoValor()
        //{
        //    Metodo.GenerarValorExtra();
        //    MostrarDataSource(GenerarLista(Metodo.GetValores()));
        //    dgvMetodo.Refresh();
        //}

        private void HabilitarProximos(int value) => btnProximo.Enabled = Iteraciones.Count != value;

        private List<Iteracion> GenerarLista(List<double> lst)
        {
            int index = 0;
            return lst.Select(x => new Iteracion { Indice = index++, Valor = x }).ToList();
        }

        #endregion

        #endregion

        #region Eventos
        private void BtnGenerar_Click(object sender, EventArgs e) => Generar();
        private void BtnLimpiar_Click(object sender, EventArgs e) => LimpiarGrilla();
        private void BtnProximo_Click(object sender, EventArgs e) => MostrarDataSource(MostrarPorCantidad());
        private void BtnAplicarRango_Click(object sender, EventArgs e) => AplicarRango();
        private void CboMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResultado.Text = "";

            if (cboMetodo.SelectedIndex == 0)
            {
                HabilitarTxt(true);
            }
            if (cboMetodo.SelectedIndex == 1)
            {
                txt_c.Text = "";
                HabilitarTxt(true);
                txt_c.Enabled = false;
            }
            if (cboMetodo.SelectedIndex == 2)
            {
                HabilitarTxt(false);
                txt_c.Text = txt_m.Text = txt_a.Text = txt_k.Text = txt_g.Text = txt_semilla.Text = "";
            }
        }
        private void Txt_a_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_a.Text != "" && Convert.ToInt32(txt_a.Text) > 0)
            {
                txt_k.Enabled = false;
                txt_k.Text = "";
            }
            else txt_k.Enabled = true;
        }
        private void Txt_m_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_m.Text != "" && Convert.ToInt32(txt_m.Text) > 0)
            {
                txt_g.Enabled = false;
                txt_g.Text = "";
            }
            else txt_g.Enabled = true;
        }
        private void Txt_k_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_k.Text != "" && Convert.ToInt32(txt_k.Text) > 0)
            {
                txt_a.Enabled = false;
                txt_a.Text = "";
            }
            else txt_a.Enabled = true;
        }
        private void Txt_g_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_g.Text != "" && Convert.ToInt32(txt_g.Text) > 0)
            {
                txt_m.Enabled = false;
                txt_m.Text = "";
            }
            else txt_m.Enabled = true;
        }
        private void BtnCalcularChiCuadrado_Click(object sender, EventArgs e) => TestChi();
        private void BtnIrChi_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }
        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            if (DisplayForm is null)
               return;
            DisplayForm.ShowDialog();
        }
        #endregion
    }
}
