using Generales.Core.Models;
using Generales.EF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generales.EF.Access
{
    public class ProductosData
    {
        private readonly GeneralesContext _context;

        public ProductosData(GeneralesContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Producto>> GetProductos()
        {
            var datos = await _context.Productos.Include(p => p.Clasificacion).ToListAsync();
            return datos;
        }

        public async Task<Producto> GetProductoByID(int ID_Producto)
        {
            var datos = await _context.Productos.Include(p => p.Clasificacion).FirstOrDefaultAsync(x => x.ID_Producto == ID_Producto);
            return datos;
        }


        public async void AddProducto(Producto producto)
        {
            await _context.AddAsync(producto);
        }

        public async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        
    }
}
