using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Items
    {
        private int id;
        private string nombreProducto;
        private int cantidad;
        private decimal subPrecio;
        private int idFactura;

        public int Id { get => id; set => id = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal SubPrecio { get => subPrecio; set => subPrecio = value; }
        public int IdFactura { get => idFactura; set => idFactura = value; }
    }
}
