using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataItems : DataAccess
    {
        public int RegistrarItem(Items items)
        {
            int resultado = -1;

            string query = @"insert into Items (NombreProducto, 
                                                Cantidad, 
                                                SubPrecio, 
                                                IdFactura)
                                         values (@NombreProducto, 
                                                @Cantidad, 
                                                @SubPrecio, 
                                                @IdFactura)"
            ;

            SqlCommand cmd = new SqlCommand(query, conexion);

            SqlParameter nombreProducto = new SqlParameter("@NombreProducto", items.NombreProducto);
            SqlParameter cantidad = new SqlParameter("@Cantidad", items.Cantidad);
            SqlParameter subPrecio = new SqlParameter("@SubPrecio", items.SubPrecio);
            SqlParameter idFactura = new SqlParameter("@IdFactura", items.IdFactura);

            cmd.Parameters.Add(nombreProducto);
            cmd.Parameters.Add(cantidad);
            cmd.Parameters.Add(subPrecio);
            cmd.Parameters.Add(idFactura);

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
    }
}
