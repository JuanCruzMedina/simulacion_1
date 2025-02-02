﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_1.Clases
{
    public abstract class Metodo : IMetodoGeneracion
    {
        #region Constructor

        protected Metodo(int m, int a, int g, int k, int semilla, int cantidad)
        {
            M = m;
            A = a;
            G = g;
            K = k;
            Semilla = semilla;
            Cantidad = cantidad;
            Xi = semilla;
            this.LstNumeros = new List<double>();
        }
        #endregion

        #region Propiedades

        private protected int M { get; set; }
        private protected int A { get; set; }
        private protected int G { get; set; }
        private protected int K { get; set; }
        private protected int Semilla { get; set; }
        private protected int Cantidad { get; set; }
        private protected double Random { get; set; }
        private protected double Xi { get; set; }
        private protected List<double> LstNumeros { get; set; }

        #endregion

        #region Implementación de la Interfaz

        public abstract List<double> GenerarValores();
        public abstract double GenerarValorExtra();
        public List<double> GetValores() => LstNumeros.Select(x => Math.Round(x,4)).ToList();

        #endregion

    }
}
