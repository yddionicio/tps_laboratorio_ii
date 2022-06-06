using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Monitor : Producto
    {
        private int pulgadas;
        private bool pantallaCurva;

        public Monitor() { }

        public Monitor(string marca, int cantidad, int pulgadas, bool pantallaCurva) : base(marca, cantidad)
        {
            this.Pulgadas = pulgadas;
            this.PantallaCurva = pantallaCurva;
        }

        public int Pulgadas { get => pulgadas; set => pulgadas = value; }
        public bool PantallaCurva { get => pantallaCurva; set => pantallaCurva = value; }

        public override string ToString()
        {
            string pantallaCurva = this.pantallaCurva ? "Si" : "No";
            return $"{base.ToString()} - Pulgadas: {this.pulgadas} - Pantalla Curva: {pantallaCurva}";
        }
    }
}
