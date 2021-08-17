using System.Collections.Generic;

namespace Simulacion_1.Clases
{
    public class CongruencialMultiplicativo : Metodo
    {
        #region Constructor

        public CongruencialMultiplicativo(int m, int a, int xo, int g, int k, int cant) : base(m, a, g, k, xo, cant)
        {

        }

        #endregion

        #region Implementación de la interfaz

        public override List<double> GenerarValores()
        {
            int a_ = A; int _m = M;
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
            if ((A == 0 && K == 0) || (M == 0 && G == 0)) return 0;
            if (M == 0) M = 2 ^ G;
            if (A == 0) A = 1 + 4 * K;
            double aXi = (A * Xi), xi1 = aXi % M;
            Random = xi1 / M;
            lstNumeros.Add(Random);
            Xi = xi1;
            return Random;
        }
         
        #endregion
    }
}
