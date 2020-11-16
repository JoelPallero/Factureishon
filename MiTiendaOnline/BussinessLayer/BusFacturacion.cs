using DataLayer;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BusFacturacion
    {
        private DataFacturacion _dataFacturacion;

        public BusFacturacion()
        {
            _dataFacturacion = new DataFacturacion();
        }

        public int NuevaFactura(Facturacion facturacion)
        {
            return _dataFacturacion.NuevaFactura(facturacion);
        }

        public Facturacion TraerFacturaCliente(int cliente, Facturacion facturacion)
        {
            return _dataFacturacion.TraerFacturaCliente(cliente, facturacion);
        }
    }
}