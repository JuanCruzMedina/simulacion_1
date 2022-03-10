using System.Collections.Generic;
using System.Linq;


namespace Simulacion_1.Clases
{
    class TestChi
    {
        private readonly double _salto;
        public double[] Fo { get; set; } //Frecuencias observadas
        public double[] Fe { get; set; } // Frecuencias esperadas
        public double[] Intervalos { get; set; }
        public double[] C { get; set; } // Estadistico
        public double[] Cac { get; set; } // Estadistico de prueba (C acumulado)
        public bool Rechazada { get; set; }
        public double ValorCritico { get; set; } // Si cac (C acumulado) es mayor al valor critico, es posible rechazar la hipotesis nula


        public TestChi(List<Iteracion> numeros, int cantIntervalos)
        {
            // Inicializamos las variables
            double anterior = 0;
            Intervalos = new double[cantIntervalos];
            Fo = new double[cantIntervalos];
            Fe = new double[cantIntervalos];
            C = new double[cantIntervalos];
            Cac = new double[cantIntervalos];

            double salto = numeros.Max(x => x.Valor) / cantIntervalos; //aca deberiamos poner el valor maximo

            // Generamos los intervalos
            for (int i = 0; i < cantIntervalos; i++)
            {
                anterior += _salto;
                Intervalos[i] = anterior;
            }
        }

        public bool Procesar(List<Iteracion> numeros)
        {
            // Primero calculamos las frecuencias observadas
            CalcularFO(numeros);
            // Calculamos las frecuencias esperadas
            CalcularFE(numeros);
            // Obtenemos el estadistico acumulado
            CalcularEstadisticoPrueba();
            // Verificamos si se rechaza la hipotesis nula
            TestHipotesis(numeros);

            return Rechazada;
        }

        // Calcular Frecuencias Observadas
        private void CalcularFO(List<Iteracion> numeros)
        {
            // Vamos metiendo cada numero en el intervalo que corresponde
            foreach (Iteracion numero in numeros)
                for (int i = 0; i < Intervalos.Length; i++)
                    if (this.Intervalos[i] > numero.Valor && numero.Valor >= (Intervalos[i] - _salto))
                        Fo[i]++;
        }

        // Calcular Frecuencias Esperadas
        private void CalcularFE(List<Iteracion> numeros)
        {
            for (int i = 0; i < Fe.Length; i++)
                Fe[i] = (double)numeros.Count / Intervalos.Length;
        }

        private void CalcularEstadisticoPrueba()
        {
            double valorAnt = 0;
            for (int i = 0; i < Fe.Length; i++)
            {
                C[i] = ((Fe[i] - Fo[i]) * (Fe[i] - Fo[i])) / Fe[i];
                valorAnt += C[i];
                Cac[i] = valorAnt;
            }
        }

        /// <summary>
        /// Este metodo verifica si se puede rechazar o no la hipotesis nula.
        /// </summary>
        /// <param name="iteraciones">No se usa... </param>
        public void TestHipotesis(List<Iteracion> iteraciones)
        {
            int gradosLibertad = Intervalos.Length == 1 ? 1 : Intervalos.Length -1;
            Dictionary<int, double> valoresCriticos = new Dictionary<int, double>();
            CargarDiccionario(valoresCriticos);
            ValorCritico = valoresCriticos[gradosLibertad];
            //bool rechazada = !(this.ValorCritico > Cac[Cac.Length - 1]);
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

