using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Simulacion_1
{
    public partial class Grafico : Form
    {
        private double[] intv, valuesFE, valuesFO;
        public Grafico(double[] _intv, double[] _valuesFE, double[] _valuesFO)
        {
            InitializeComponent();
            this.intv = _intv;
            this.valuesFE = _valuesFE;
            this.valuesFO = _valuesFO;
        }

        private void Grafico_Load(object sender, EventArgs e)
        {
            chFE.Titles.Add("Histograma de frecuencias esperadas");
            chFO.Titles.Add("Histograma de frecuencias observadas");
            CargarGrafico();
        }

        private void CargarGrafico()
        {
            string intervalo;
            chFE.Series.Add("Serie1");
            chFO.Series.Add("Serie2");
            chFE.Series["Serie1"].Points.Clear();
            chFO.Series["Serie2"].Points.Clear();

            chFE.Palette = ChartColorPalette.Berry;

            chFE.Series["Serie1"].LegendText = "Frecuencia esperada";
            chFO.Series["Serie2"].LegendText = "Frecuencia observada";

            for (int i = 0; i < intv.Length; i++)
            {
                if (i == 0) intervalo = "0 - " + Convert.ToDouble(intv[i].ToString("#.00"));
                else intervalo = Convert.ToDouble(intv[i-1].ToString("#.00")) + " - " + Convert.ToDouble(intv[i].ToString("#.00"));
                chFE.Series["Serie1"].Points.AddXY(intervalo, valuesFE[i]);
            }

            for (int i = 0; i < intv.Length; i++)
            {
                if (i == 0) intervalo = "0 - " + Convert.ToDouble(intv[i].ToString("#.00"));
                else intervalo = Convert.ToDouble(intv[i - 1].ToString("#.00")) + " - " + Convert.ToDouble(intv[i].ToString("#.00"));
                chFO.Series["Serie2"].Points.AddXY(intervalo, valuesFO[i]);
            }
        }
    }
}
