using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ventas.EF.Context;
using Ventas.EF.Data;

namespace Ventura.API.Controllers.Ventas
{
    [Route("api/Ventas/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly VentasData _ventas;
        private readonly IMapper _mapper;

        public ProductosController(VentasData ventas, IMapper mapper)
        {
            
            this._ventas = ventas;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var datos = await this._ventas.GetProductos();

            return Ok(datos);
        }
    }
}