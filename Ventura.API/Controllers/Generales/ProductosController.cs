using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Generales.EF.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ventura.API.Dtos.Generales;

namespace Ventura.API.Controllers.Generales
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly GeneralesContext _context;
        private readonly IMapper _mapper;


        public ProductosController(GeneralesContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var datos = await this._context.Productos.Include(p => p.Clasificacion).ToListAsync();

            var productos = _mapper.Map<IEnumerable<ProductoToReturnDTO>>(datos);

            return Ok(productos);
        }
    }
}
