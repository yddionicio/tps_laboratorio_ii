using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Cliente
    {
        private string apellido;
        private string nombre;
        private int dni;

        public Cliente()
        {
        }

        public Cliente(int dni, string nombre, string apellido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static bool operator ==(Cliente a, Cliente b)
        {
            return a.dni == b.dni;
        }

        public static bool operator !=(Cliente a, Cliente b)
        {
            return !(a == b);
        }

        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Dni { get => dni; set => dni = value; }

        public override string ToString()
        {
            return $"Apellido: {apellido}, Nombre: {nombre}, DNI: {dni}";
        }

        public static List<Cliente> LeerDesdeJson(string ruta)
        {
            return new ClienteDAO().leerJson(ruta);
        }

        public static List<Cliente> LeerDesdeBaseDeDatos()
        {
            return new ClienteDAO().TraerDatos();
        }
    }
}

