using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_1.Clases
{
    public class CongruencialMixto : Metodo
    {
        #region Propiedades

        private int C { get; set; }

        #endregion

        #region Constructor

        public CongruencialMixto(int m, int a, int xo, int c, int cant) : base(m, a, xo, cant)
        {
            C = c;
        }

        #endregion

        #region Implementación de la interfaz

        public override List<double> GenerarValores()
        {
            for (int i = 0; i < Cantidad; i++)
            {
                double aXic = ((A* Xi) + C), xi1 = aXic % M;
                Random = xi1 / M;
                lstNumeros.Add(Random);
                Xi = xi1;
            }
            return lstNumeros.Select(x => Math.Round(x, 4)).ToList();
        }

        public override double GenerarValorExtra()
        {
            double aXic = ((this.A * Xi) + C), xi1 = aXic % M;
            Random = xi1 / M;
            lstNumeros.Add(Random);
            Xi = xi1;
            return Random;
        }

        #endregion
    }
}
