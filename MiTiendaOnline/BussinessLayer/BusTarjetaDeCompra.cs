using DataLayer;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BusTarjetaDeCompra
    {
        private DataTarjetaDeCompra _dataTarjetaDeCompra;

        public BusTarjetaDeCompra()
        {
            _dataTarjetaDeCompra = new DataTarjetaDeCompra();
        }

        public int NuevaTarjeta(TarjetaDeCompa tarjetaDeCompra)
        {
            return _dataTarjetaDeCompra.NuevaTarjeta(tarjetaDeCompra);
        }

        public TarjetaDeCompa TraerUltimaTarjeta(int Cliente, TarjetaDeCompa tarjetaDeCompa)
        {
            return _dataTarjetaDeCompra.TraerUltimaTarjeta(Cliente, tarjetaDeCompa);
        }
    }
}