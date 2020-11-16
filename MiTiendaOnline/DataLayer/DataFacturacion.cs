using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataFacturacion : DataAccess
    {

        public int NuevaFactura(Facturacion facturacion)
        {
            int resultado = -1;
            string query = @"insert into Facturacion (Fecha, 
                                                      PrecioFinal, 
                                                      IdCliente, 
                                                      IdTarjeta, 
                                                      Aprobado)
                                              values (@Fecha, 
                                                      @PrecioFinal, 
                                                      @IdCliente, 
                                                      @IdTarjeta, 
                                                      @Aprobado)"
            ;

            SqlCommand cmd = new SqlCommand(query, conexion);

            SqlParameter fecha = new SqlParameter("@Fecha", facturacion.Fecha);
            SqlParameter precioFinal = new SqlParameter("@PrecioFinal", facturacion.PrecioFinal);
            SqlParameter idCliente = new SqlParameter("@IdCliente", facturacion.IdCliente);
            SqlParameter idTarjeta = new SqlParameter("@IdTarjeta", facturacion.IdTarjeta);
            SqlParameter aprobado = new SqlParameter("@Aprobado", facturacion.Aprobado);

            cmd.Parameters.Add(fecha);
            cmd.Parameters.Add(precioFinal);
            cmd.Parameters.Add(idCliente);
            cmd.Parameters.Add(idTarjeta);
            cmd.Parameters.Add(aprobado);

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

        public Facturacion TraerFacturaCliente(int cliente, Facturacion facturacion)
        {
            string query = @"select Id from Facturacion where IdCliente = '" + cliente + "'" +
                "and Id = (select max(Id) from Facturacion)"
            ;

            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                Abrirconexion();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    facturacion.Id = int.Parse(reader["Id"].ToString());
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
            return facturacion;
        }
    }
}