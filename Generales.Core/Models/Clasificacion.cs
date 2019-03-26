﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generales.Core.Models
{
    public class Clasificacion
    {
        public int ID_Clasificacion { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
}
