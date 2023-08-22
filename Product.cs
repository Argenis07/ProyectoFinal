using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Product
    {
        public int Nro { get; set; } // idorden
        public int IdProducto { get; set; }
        public string Producto { get; set; } // productname
        public decimal Precio { get; set; } // UnitPrice
        public int Cantidad { get; set; } // Quantity
    }
}
