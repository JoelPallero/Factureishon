using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TarjetaDeCompa
    {
        public int Id { get; set; }
        public string NroTarjeta { get; set; }
        public string CodSeguridad { get; set; }
        public int IdCliente { get; set; }

    }
}
