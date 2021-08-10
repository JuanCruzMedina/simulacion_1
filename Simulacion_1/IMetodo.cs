using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_1
{
    public interface IMetodoGeneracion
    {
        List<double> GenerarValores();
        double GenerarValorExtra();
        List<double> GetValores();
    }
}
