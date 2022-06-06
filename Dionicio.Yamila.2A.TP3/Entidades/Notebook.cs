using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Notebook : Producto
    {
        private ETipoDisco tipoDisco;
        private int espacioDisco;

        public Notebook() { }

        public Notebook(string marca, int cantidad, ETipoDisco tipoDisco, int espacioDisco) : base(marca, cantidad)
        {
            this.TipoDisco = tipoDisco;
            this.EspacioDisco = espacioDisco;
        }

        public ETipoDisco TipoDisco { get => tipoDisco; set => tipoDisco = value; }
        public int EspacioDisco { get => espacioDisco; set => espacioDisco = value; }

        public override string ToString()
        {
            return $"{base.ToString()} - Tipo Disco: {this.tipoDisco} - Espacio Disco: {this.espacioDisco}";
        }

        public enum ETipoDisco { HDD, SSD }
    }
}
