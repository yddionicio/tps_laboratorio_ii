using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        private string marca;
        private int cantidad;

        public Producto() { }

        public Producto(string marca, int cantidad)
        {
            this.Marca = marca;
            this.Cantidad = cantidad;
        }

        public string Marca { get => marca; set => marca = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public override string ToString()
        {
            return $"Producto: {this.GetType().Name}\n\t Marca: {this.marca} - Cantidad: {this.cantidad}";
        }
    }
}
