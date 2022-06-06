using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteDAO: IArchivos<Cliente>
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static SqlDataReader reader;

        static ClienteDAO()
        {
            comando = new SqlCommand();
            conexion = new SqlConnection("Data source = (LocalDb)\\test; Database = YamilaDionicio; Trusted_Connection = True;");
        }

        public List<Cliente> TraerDatos()
        {
            List<Cliente> clientes = new List<Cliente>();
            string consulta = "SELECT * FROM clientes";

            try
            {
                conexion.Open();
                comando.CommandText = consulta;
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    string r = reader[1].ToString();
                    clientes.Add(new Cliente(int.Parse(reader[2].ToString()), reader[1].ToString(), reader[0].ToString()));
                }

                conexion.Close();
                return clientes;
            }
            catch (Exception e)
            {
                throw new TraerDatosException("Error al leer la base de datos.");
            }
        }

        public List<Cliente> leerJson(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                string elementoJson = sr.ReadToEnd();
                List<Cliente> clientes = JsonSerializer.Deserialize<List<Cliente>>(elementoJson);

                sr.Close();
                return clientes;
            }
            catch (Exception e)
            {
                throw new TraerDatosException("Error al leer el archivo json.");
            }
        }
    }
}
