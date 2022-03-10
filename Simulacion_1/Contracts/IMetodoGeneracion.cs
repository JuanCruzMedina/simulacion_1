using System.Collections.Generic;

namespace Simulacion_1
{
    public interface IMetodoGeneracion
    {
        List<double> GenerarValores();
        double GenerarValorExtra();
        List<double> GetValores();
    }
}
