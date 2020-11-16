using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataTarjetaDeCompra : DataAccess
    {
        public int NuevaTarjeta(TarjetaDeCompa tarjetaDeCompra)
        {
            int resultado = -1;

            string query = @"insert into TarjetaDeCompra (NroTarjeta, 
                                                          CodSeguridad, 
                                                          IdCliente)
                                                  values (@NroTarjeta, 
                                                          @CodSeguridad, 
                                                          @IdCliente)"
            ;

            SqlCommand cmd = new SqlCommand(query, conexion);

            SqlParameter nroTarjeta = new SqlParameter("@NroTarjeta", tarjetaDeCompra.NroTarjeta);
            SqlParameter codSeguridad = new SqlParameter("@CodSeguridad", tarjetaDeCompra.CodSeguridad);
            SqlParameter idCliente = new SqlParameter("@IdCliente", tarjetaDeCompra.IdCliente);

            cmd.Parameters.Add(nroTarjeta);
            cmd.Parameters.Add(codSeguridad);
            cmd.Parameters.Add(idCliente);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return resultado;
        }


        public TarjetaDeCompa TraerUltimaTarjeta(int Cliente, TarjetaDeCompa tarjetaDeCompa)
        {
            
            string query = @"select Id from TarjetaDeCompra where IdCliente = '" + Cliente + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                Abrirconexion();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    tarjetaDeCompa.Id = int.Parse(reader["Id"].ToString());
                }
                reader.Close();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return tarjetaDeCompa;
        }
    }
}