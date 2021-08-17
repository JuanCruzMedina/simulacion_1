using Simulacion_1.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
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
            MostrarDesde = 0;
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

                if (cboMetodo.SelectedIndex == 0)
                    Metodo = new CongruencialMixto(condiciones.M, condiciones.A, condiciones.Semilla, condiciones.C, condiciones.G, condiciones.K, condiciones.Cantidad);
                else if (cboMetodo.SelectedIndex == 1)
                    Metodo = new CongruencialMultiplicativo(condiciones.M, condiciones.A, condiciones.Semilla, condiciones.G, condiciones.K, condiciones.Cantidad);
                else
                    Metodo = new DelLenguaje(condiciones.M, condiciones.A, condiciones.G, condiciones.K, condiciones.Semilla, condiciones.Cantidad);

                Metodo.GenerarValores();
                listaDataSource = GenerarLista(Metodo.GetValores());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                listaDataSource = null;
            }
            return listaDataSource;
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
                if (DataSource != null)
                {
                    var lst = DataSource.GetRange(MostrarDesde, cantidad);
                    MostrarDesde += cantidad;
                    return lst;
                }
                return DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Ocurrio una inconsistencia al mostrar por cantidad");
                return null;
            }
        }

        private void Generar()
        {
            DataSource = GenerarNumeros() as List<Iteracion>;
            MostrarDataSource(MostrarPorCantidad());
        }

        private void AplicarRango()
        {
            int desde = int.Parse(txt_desde.Text), hasta = int.Parse(txt_hasta.Text);
            MostrarDataSource(DataSource.Where(x => x.Indice >= desde && x.Indice <= hasta).ToList());
        }

        private void ObtenerProximoValor()
        {
            Metodo.GenerarValorExtra();
            MostrarDataSource(GenerarLista(Metodo.GetValores()));
            dgvMetodo.Refresh();
        }

        private List<Iteracion> GenerarLista(List<double> lst)
        {
            int index = 1;
            return lst.Select(x => { return new Iteracion { Indice = index++, Valor = x }; }).ToList();
        }

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

        #endregion
    }
}
