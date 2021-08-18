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
        private readonly int cantidadMostrar = 20;

        public IMetodoGeneracion Metodo { get; set; }
        public List<Iteracion> DataSource { get; set; }
        public int CantidadMostrar { get; set; }
        public int MostrarDesde { get; set; }

        #endregion

        #region Métodos privados

        private void InicializarFormulario()
        {
            cboMetodo.SelectedIndex = 0;
            DataSource = new List<Iteracion>();
            LimpiarGrilla();
            dgvChi.DataSource = null;
            MostrarDesde = 0;
        }

        private void HabilitarTxt(bool habilitar)
        {
            txt_c.Enabled = habilitar;
            txt_m.Enabled = habilitar;
            txt_a.Enabled = habilitar;
            txt_k.Enabled = habilitar;
            txt_g.Enabled = habilitar;
            txt_semilla.Enabled = habilitar;
        }

        private void CargarGrillaChi(DataGridView grilla, TestChi lista)
        {
            grilla.Rows.Clear();
            string intervalo;
            for (int i = 0; i < lista.intervalos.Length; i++)
            {
                if (i == 0) intervalo = "0 - " + Convert.ToDouble(lista.intervalos[i].ToString("#.00"));
                else intervalo = Convert.ToDouble(lista.intervalos[i - 1].ToString("#.00")) + " - " + Convert.ToDouble(lista.intervalos[i].ToString("#.00"));
                var intv = intervalo;
                var _fo = Convert.ToDouble(lista.fo[i].ToString("#.00"));
                var _fe = Convert.ToDouble(lista.fe[i].ToString("#.00"));
                var _c = Convert.ToDouble(lista.c[i].ToString("#.00"));
                var _cac = Convert.ToDouble(lista.cac[i].ToString("#.00"));
                grilla.Rows.Add(intv, _fo, _fe, _c, _cac);
            }
            dgvChi.Refresh();
        }

        private Condiciones GetCondiciones()
        {
            int a, c, m, k, g, s, cant;
            return new Condiciones()
            {
                A = int.TryParse(txt_a.Text, out a) ? a : 0,
                C = int.TryParse(txt_c.Text, out c) ? c : 0,
                M = int.TryParse(txt_m.Text, out m) ? m : 0,
                K = int.TryParse(txt_k.Text, out k) ? k : 0,
                G = int.TryParse(txt_g.Text, out g) ? g : 0,
                Semilla = int.TryParse(txt_semilla.Text, out s) ? s : 0,
                Cantidad = int.TryParse(txt_cantidad.Text, out cant) ? cant : 0,
            };
        }
        private ChiCuadradoCondiciones GetCondicionesChi()
        {
            int intervalos;
            return new ChiCuadradoCondiciones()
            {
                Subintervalos = int.TryParse(txt_intervalos.Text, out intervalos) ? intervalos : 0,
                Confianza = 95,
            };
        }

        private bool TestChi()
        {
            try
            {
                dgvChi.DataSource = null;
                var condiciones = GetCondicionesChi();
                if (cboMetodo.SelectedIndex == 0 || cboMetodo.SelectedIndex == 2)
                {
                    if (DataSource.Count == 0) throw new Exception("Debe generar la lista de números pseudoaleatorios para realizar la prueba");
                    var tstChi = new TestChi(condiciones.Subintervalos);
                    bool rechazada = tstChi.procesar(DataSource);
                    CargarGrillaChi(dgvChi, tstChi);

                    Grafico g = new Grafico(tstChi.intervalos, tstChi.fe, tstChi.fo);
                    g.ShowDialog();

                    string msg = "Con los grados de libertad " + (tstChi.intervalos.Length - 1) + " se obtuvo un valor calculado de " + (tstChi.cac[tstChi.cac.Length-1]) + ".\nSe obtuvo un valor crítico de " + tstChi.valorCritico + ", por lo tanto, la hipótesis ";
                    if (rechazada) msg += "fue rechazada";
                    else msg += "no puede ser rechazada";
                    lblResultado.Text = msg;
                    lblResultado.ForeColor = Color.FromArgb(255, 255, 255);
                    return rechazada;
                }
                else
                {
                    throw new Exception("El test de Chi Cuadrado está implementado para los métodos congruencial mixto y del lenguaje");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #region generación de números

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
                    if ((condiciones.A == 0 && condiciones.K == 0) || (condiciones.M == 0 && condiciones.G == 0)) throw new Exception("Ingrese valores para la generación de los números pseudoaleatorios");
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
                    if (condiciones.A == 0) condiciones.A = 3 + 8 * condiciones.K;
                    if (condiciones.Semilla % 2 == 0) throw new Exception("El valor de la semilla debe ser impar");

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
                List<Iteracion> lst;
                if (DataSource != null)
                {
                    if (MostrarDesde + 20 > DataSource.Count-1)
                    {
                        cantidad = (DataSource.Count - MostrarDesde);
                        btnProximo.Enabled = false;
                    }
                    lst = DataSource.GetRange(MostrarDesde, cantidad);
                    MostrarDesde += cantidad;
                    return lst;
                }
                return DataSource;
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
            DataSource = GenerarNumeros() as List<Iteracion>;
            if (DataSource == null) return;
            HabilitarProximos(20);
            MostrarDataSource(MostrarPorCantidad());
        }

        private void AplicarRango()
        {
            int desde = int.Parse(txt_desde.Text), hasta = int.Parse(txt_hasta.Text);
            if (desde > hasta || desde < 0) MessageBox.Show("Los valores 'desde' y 'hasta' no son correctos. Ingrese un rango válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            HabilitarProximos(hasta);
            MostrarDesde = hasta;
            MostrarDataSource(DataSource.Where(x => x.Indice >= desde && x.Indice <= hasta).ToList());
        }

        private void ObtenerProximoValor()
        {
            Metodo.GenerarValorExtra();
            MostrarDataSource(GenerarLista(Metodo.GetValores()));
            dgvMetodo.Refresh();
        }

        private void HabilitarProximos(int value)
        {
            if (DataSource.Count != value)
                btnProximo.Enabled = true;
            else
                btnProximo.Enabled = false;
        }

        private List<Iteracion> GenerarLista(List<double> lst)
        {
            int index = 1;
            return lst.Select(x => { return new Iteracion { Indice = index++, Valor = x }; }).ToList();
        }

        #endregion
        #endregion

        #region Eventos

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Generar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarGrilla();
        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            MostrarDataSource(MostrarPorCantidad());
        }
        private void btnAplicarRango_Click(object sender, EventArgs e)
        {
            AplicarRango();
        }


        private void cboMetodo_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txt_a_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_a.Text != "" && Convert.ToInt32(txt_a.Text) > 0)
            {
                txt_k.Enabled = false;
                txt_k.Text = "";
            }
            else txt_k.Enabled = true;
        }

        private void txt_m_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_m.Text != "" && Convert.ToInt32(txt_m.Text) > 0)
            {
                txt_g.Enabled = false;
                txt_g.Text = "";
            }
            else txt_g.Enabled = true;
        }

        private void txt_k_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_k.Text != "" && Convert.ToInt32(txt_k.Text) > 0)
            {
                txt_a.Enabled = false;
                txt_a.Text = "";
            }
            else txt_a.Enabled = true;
        }

        private void txt_g_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_g.Text != "" && Convert.ToInt32(txt_g.Text) > 0)
            {
                txt_m.Enabled = false;
                txt_m.Text = "";
            }
            else txt_m.Enabled = true;
        }

        #endregion
        int posY = 0;
        int posX = 0;
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgvChi.DataSource = null;
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            TestChi();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void barraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;

            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
