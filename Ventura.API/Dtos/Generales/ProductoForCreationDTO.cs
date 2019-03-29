using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ventura.API.Dtos.Generales
{
    public class ProductoForCreationDTO
    {
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int ID_Clasificacion { get; set; }
    }
}
