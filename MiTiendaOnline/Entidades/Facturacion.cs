using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Facturacion
    {
        private int id;
        private DateTime fecha;
        private decimal precioFinal;
        private int idCliente;
        private int idTarjeta;
        private string aprobado;

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public decimal PrecioFinal { get => precioFinal; set => precioFinal = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdTarjeta { get => idTarjeta; set => idTarjeta = value; }
        public string Aprobado { get => aprobado; set => aprobado = value; }
    }
}
