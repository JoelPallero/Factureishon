using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataCliente : DataAccess
    {
        public Cliente ClienteRegistrado(Cliente cliente)
        {
            string query = "select * from Cliente";

            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                Abrirconexion();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cliente.Id = int.Parse(reader["Id"].ToString());
                    cliente.Nombre = reader["Nombre"].ToString();
                    cliente.Dni = reader["Dni"].ToString();
                    cliente.Email = reader["Email"].ToString();
                }
                reader.Close();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception ("No se pudo conectar a la base de datos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return cliente;
        }
    }
}
