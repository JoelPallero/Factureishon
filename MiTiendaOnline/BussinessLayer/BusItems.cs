using DataLayer;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BusItems
    {
        private DataItems _dataItems;

        public BusItems()
        {
            _dataItems = new DataItems();
        }

        public int RegistrarItem(Items items)
        {
            return _dataItems.RegistrarItem(items);
        }
    }
}