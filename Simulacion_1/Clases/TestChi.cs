using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Simulacion_1.Clases
{
    class TestChi
    {
        double salto;
        double[] intervalos;
        double[] fo;            // Frecuencias observadas
        double[] fe;            // Frecuencias esperadas
        double[] c;             // Estadistico
        double cac;             // Estadistico de prueba (C acumulado)
        double valorCritico;    // Si cac (C acumulado) es mayor al valor critico, es posible rechazar la hipotesis nula
        bool rechazada;


        public TestChi(int cantIntervalos)
        {
            // Inicializamos las variables
            double anterior = 0;
            intervalos = new double[cantIntervalos];
            fo = new double[cantIntervalos];
            fe = new double[cantIntervalos];
            c = new double[cantIntervalos];
            salto = 1.0 / cantIntervalos;

            // Generamos los intervalos
            for (int i = 0; i < cantIntervalos; i++)
            {
                anterior += salto;
                intervalos[i] = anterior;
            }
        }

        public void procesar(List<double> numeros)
        {
            // Primero calculamos las frecuencias observadas
            calcularFO(numeros);
            // Calculamos las frecuencias esperadas
            calcularFE(numeros);
            // Obtenemos el estadistico acumulado
            calcularEstadisticoPrueba();
            // Verificamos si se rechaza la hipotesis nula
            testHipotesis(numeros);
        }

        // Calcular Frecuencias Observadas
        private void calcularFO(List<double> numeros)
        {
            // Vamos metiendo cada numero en el intervalo que corresponde
            foreach (double numero in numeros)
            //double numero :numeros
            {
                for (int i = 0; i < this.intervalos.Length; i++)
                {
                    if (this.intervalos[i] > numero && numero > (this.intervalos[i] - this.salto))
                    {
                        fo[i]++;
                        continue;
                    }
                }
            }
        }

        // Calcular Frecuencias Esperadas
        private void calcularFE(List<double> numeros)
        {
            for (int i = 0; i < this.fe.Length; i++)
            {
                this.fe[i] = (double)numeros.Count / this.intervalos.Length;
            }
        }

        private void calcularEstadisticoPrueba()
        {
            for (int i = 0; i < this.fe.Length; i++)
            {
                this.c[i] = ((this.fe[i] - this.fo[i]) * (this.fe[i] - this.fo[i])) / this.fe[i];
                cac += c[i];
            }
        }

        // Este metodo verifica si se puede rechazar o no la hipotesis nula
        public void testHipotesis(List<double> numeros)
        {
            int gradosLibertad;
            if (intervalos.Length == 1) gradosLibertad = 1;
            else gradosLibertad = intervalos.Length - 1;
            // Con este alpha definimos que existe un riesgo de 5% de concluir que la muestra no se ajusta a la
            // distribución propuesta, cuando en realidad si lo hace.

            //double alpha = 0.05;

            // Esta clase proviene de la libreria.............
            double bothtails;
            double righttail;
            double lefttails;

            alglib.onesamplevariancetest(numeros.ToArray(), numeros.Count, cac, out bothtails, out righttail, out lefttails);

            bool rechazada = !(bothtails > cac);
        }

        /**
        * -------------------------------------------------- GETTERS --------------------------------------------------
        */
        public double[] getFrecuenciasObservadas()
        {
            return fo;
        }

        public double[] getFrecuenciasEsperadas()
        {
            return fe;
        }

        public double[] getIntervalos()
        {
            return intervalos;
        }

        public double[] getEstadisticos()
        {
            return c;
        }

        public double getEstadisticoPrueba()
        {
            return cac;
        }

        public bool isRechazada()
        {
            return rechazada;
        }

        public double getValorCritico()
        {
            return valorCritico;
        }

    }


}

