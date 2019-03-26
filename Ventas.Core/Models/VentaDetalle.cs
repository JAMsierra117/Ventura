using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas.Core.Models
{
    public class VentaDetalle 
    {
        public int ID_VentaDetalle { get; set; }
        public int ID_Venta { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Importe { get; set; }
        public decimal Descuento { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal Impuesto { get; set; }
        public decimal PorcentajeImpuesto { get; set; }
        public int ID_Impuesto { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

        public Venta Venta { get; set; }
    }
}
