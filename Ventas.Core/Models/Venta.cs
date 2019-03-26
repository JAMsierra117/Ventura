using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas.Core.Models
{
    public class Venta 
    {
        public int ID_Venta { get; set; }
        public int ID_Cliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Importe { get; set; }
        public decimal Descuento { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public List<VentaDetalle> VentaDetalles { get; set; }
        public List<VentaPago> VentasPagos { get; set; }

        
    }
}
