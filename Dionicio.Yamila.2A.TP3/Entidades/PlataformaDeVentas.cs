using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlataformaDeVentas
    {
        private List<Cliente> clientes;

        public PlataformaDeVentas()
        {
            this.clientes = new List<Cliente>();
        }

        public List<Cliente> Clientes
        {
            get { return this.clientes; }
            set { this.clientes = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Cliente c in clientes)
            {
                sb.AppendLine(c.ToString());
            }

            return sb.ToString();
        }

        public static bool operator ==(PlataformaDeVentas a, Cliente b)
        {
            foreach (Cliente c in a.clientes)
            {
                if (c == b)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(PlataformaDeVentas a, Cliente b)
        {
            return !(a == b);
        }

        public static bool operator +(PlataformaDeVentas a, Cliente b)
        {
            if (a != b)
            {
                a.clientes.Add(b);
                return true;
            }

            return false;
        }

        public bool AgregarClientes(List<Cliente> nuevosClientes)
        {
            bool pudoAgregar = false;

            foreach(Cliente c in nuevosClientes)
            {
                if(this + c)
                {
                    pudoAgregar = true;
                }
            }

            return pudoAgregar;
        }
    }
}
