using System;
using System.Collections.Generic;

namespace Simulacion_1.Clases
{
    public class DelLenguaje : Metodo
    {
        #region Propiedades

        private readonly Random _random = new Random();

        #endregion

        #region Constructor

        public DelLenguaje(int m, int a, int g, int k, int semilla, int cantidad) : base(m, a, g, k, semilla, cantidad)
        {
        }

        #endregion

        #region Implementación de la interfaz

        public override List<double> GenerarValores()
        {
            for (int i = 0; i < Cantidad; i++)
                LstNumeros.Add(_random.NextDouble());
            return LstNumeros;
        }

        public override double GenerarValorExtra() => _random.NextDouble();

        #endregion
    }
}
