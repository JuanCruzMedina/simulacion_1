using System;
using System.Collections.Generic;

namespace Simulacion_1.Clases
{
    public class DelLenguaje : Metodo
    {
        #region Propiedades

        private Random _Random;
        public Random oRandom
        {
            get {
                if (_Random == null)
                    _Random = new Random();
                return _Random; }
            set { _Random = value; }
        }

        #endregion

        #region Constructor

        public DelLenguaje(int m, int a, int semilla, int cantidad) : base(m, a, semilla, cantidad)
        {
        }

        #endregion

        #region Implementación de la interfaz

        public override List<double> GenerarValores()
        {
            for (int i = 0; i < Cantidad; i++)
                lstNumeros.Add(oRandom.NextDouble());
            return lstNumeros;
        }

        public override double GenerarValorExtra() => oRandom.NextDouble();

        #endregion
    }
}
