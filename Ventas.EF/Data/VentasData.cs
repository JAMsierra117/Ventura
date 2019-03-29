using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ventas.Core.Models;
using Ventas.EF.Context;

namespace Ventas.EF.Data
{
    public class VentasData : IDisposable
    {
        private readonly ReferenceContext _reference;
        public VentasData(ReferenceContext reference)
        {
            this._reference = reference;
        }

        public void Dispose()
        {
            _reference.Dispose();
        }

        public async Task<IEnumerable<Producto>> GetProductos()
        {
            return await _reference.Productos.ToListAsync();
        }
    }
}
