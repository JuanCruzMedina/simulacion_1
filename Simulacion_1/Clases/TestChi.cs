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
        public double[] fo { get; set; } //Frecuencias observadas
        public double[] fe { get; set; } // Frecuencias esperadas
        public double[] intervalos { get; set; }
        public double[] c { get; set; } // Estadistico
        public double[] cac { get; set; } // Estadistico de prueba (C acumulado)
        public bool rechazada { get; set; }
        public double valorCritico { get; set; } // Si cac (C acumulado) es mayor al valor critico, es posible rechazar la hipotesis nula


        public TestChi(int cantIntervalos)
        {
            // Inicializamos las variables
            double anterior = 0;
            intervalos = new double[cantIntervalos];
            fo = new double[cantIntervalos];
            fe = new double[cantIntervalos];
            c = new double[cantIntervalos];
            cac = new double[cantIntervalos];
            salto = 1.0 / cantIntervalos; //aca deberiamos poner el valor maximo

            // Generamos los intervalos
            for (int i = 0; i < cantIntervalos; i++)
            {
                anterior += salto;
                intervalos[i] = anterior;
            }
        }

        public bool procesar(List<Iteracion> numeros)
        {
            // Primero calculamos las frecuencias observadas
            calcularFO(numeros);
            // Calculamos las frecuencias esperadas
            calcularFE(numeros);
            // Obtenemos el estadistico acumulado
            calcularEstadisticoPrueba();
            // Verificamos si se rechaza la hipotesis nula
            testHipotesis(numeros);

            return rechazada;
        }

        // Calcular Frecuencias Observadas
        private void calcularFO(List<Iteracion> numeros)
        {
            // Vamos metiendo cada numero en el intervalo que corresponde
            foreach (Iteracion numero in numeros)
            //double numero :numeros
            {
                for (int i = 0; i < this.intervalos.Length; i++)
                {
                    if (this.intervalos[i] > numero.Valor && numero.Valor >= (this.intervalos[i] - this.salto))
                    {
                        fo[i]++;
                        continue;
                    }
                }
            }
        }

        // Calcular Frecuencias Esperadas
        private void calcularFE(List<Iteracion> numeros)
        {
            for (int i = 0; i < this.fe.Length; i++)
            {
                this.fe[i] = (double)numeros.Count / this.intervalos.Length;
            }
        }

        private void calcularEstadisticoPrueba()
        {
            double valorAnt = 0;
            for (int i = 0; i < this.fe.Length; i++)
            {
                this.c[i] = ((this.fe[i] - this.fo[i]) * (this.fe[i] - this.fo[i])) / this.fe[i];
                valorAnt += this.c[i];
                this.cac[i] = valorAnt;
            }
        }

        // Este metodo verifica si se puede rechazar o no la hipotesis nula

        public void testHipotesis(List<Iteracion> numeros)
        {
            int gradosLibertad;
            if (intervalos.Length == 1) gradosLibertad = 1;
            else gradosLibertad = intervalos.Length - 1;
            Dictionary<int, double> valoresCriticos = new Dictionary<int, double>();
            CargarDiccionario(valoresCriticos);
            this.valorCritico = valoresCriticos[gradosLibertad];

            bool rechazada = !(this.valorCritico > cac[cac.Length - 1]);
        }

        private void CargarDiccionario(Dictionary<int, double> valoresCriticos)
        {
            valoresCriticos.Add(1, 3.84);
            valoresCriticos.Add(2, 5.99);
            valoresCriticos.Add(3, 7.81);
            valoresCriticos.Add(4, 9.49);
            valoresCriticos.Add(5, 11.1);
            valoresCriticos.Add(6, 12.6);
            valoresCriticos.Add(7, 14.1);
            valoresCriticos.Add(8, 15.5);
            valoresCriticos.Add(9, 16.9);
            valoresCriticos.Add(10, 18.3);
            valoresCriticos.Add(11, 19.7);
            valoresCriticos.Add(12, 21.0);
            valoresCriticos.Add(13, 22.4);
            valoresCriticos.Add(14, 23.7);
            valoresCriticos.Add(15, 25.0);
            valoresCriticos.Add(16, 26.3);
            valoresCriticos.Add(17, 27.6);
            valoresCriticos.Add(18, 28.9);
            valoresCriticos.Add(19, 30.1);
            valoresCriticos.Add(20, 31.4);
            valoresCriticos.Add(21, 32.7);
            valoresCriticos.Add(22, 33.9);
            valoresCriticos.Add(23, 35.2);
            valoresCriticos.Add(24, 36.4);
            valoresCriticos.Add(25, 37.7);
            valoresCriticos.Add(26, 38.9);
            valoresCriticos.Add(27, 40.1);
            valoresCriticos.Add(28, 41.3);
            valoresCriticos.Add(29, 42.6);
            valoresCriticos.Add(30, 43.8);
            valoresCriticos.Add(40, 55.8);
            valoresCriticos.Add(50, 67.5);
            valoresCriticos.Add(60, 79.1);
            valoresCriticos.Add(70, 90.5);
            valoresCriticos.Add(80, 101.9);
            valoresCriticos.Add(90, 113.1);
            valoresCriticos.Add(100, 124.3);
        }

    }


}

