using System;
using System.Collections.Generic;


namespace Ventas.Core.Models
{
    public class VentaPago 
    {
        public int ID_VentaPago { get; set; }
        public int ID_Venta { get; set; }
        public int ID_FormaPago { get; set; }
        public decimal Importe { get; set; }


        public Venta Venta { get; set; }
    }
}
