using System.Collections.Generic;

namespace Simulacion_1.Clases
{
    public class CongruencialMultiplicativo : Metodo
    {
        #region Constructor

        public CongruencialMultiplicativo(int m, int a, int xo, int cant) : base(m, a, xo, cant)
        {

        }

        #endregion

        #region Implementación de la interfaz

        public override List<double> GenerarValores()
        {
            for (int i = 0; i < Cantidad; i++)
            {
                double aXi = (A * Xi), xi1 = aXi % M;
                Random = xi1 / M;
                lstNumeros.Add(Random);
                Xi = xi1;
            }
            return lstNumeros;
        }

        public override double GenerarValorExtra()
        {
            double aXi = (A * Xi), xi1 = aXi % M;
            Random = xi1 / M;
            lstNumeros.Add(Random);
            Xi = xi1;
            return Random;
        }

        #endregion
    }
}
