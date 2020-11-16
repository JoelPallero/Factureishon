using DataLayer;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BusCliente
    {
        private DataCliente _dataCliente;

        public BusCliente()
        {
            _dataCliente = new DataCliente();
        }

        public Cliente ClienteRegistrado(Cliente cliente)
        {
            return _dataCliente.ClienteRegistrado(cliente);
        }
    }
}
