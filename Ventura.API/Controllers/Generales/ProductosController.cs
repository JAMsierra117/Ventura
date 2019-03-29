using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Generales.Core.Models;
using Generales.EF.Access;
using Generales.EF.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ventura.API.Dtos.Generales;

namespace Ventura.API.Controllers.Generales
{
    [Route("api/Generales/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly ProductosData _productosData;
        private readonly IMapper _mapper;


        public ProductosController(ProductosData productosData, IMapper mapper)
        {
            this._productosData = productosData;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var datos = await this._productosData.GetProductos();

            var productos = _mapper.Map<IEnumerable<ProductoToReturnDTO>>(datos);

            return Ok(productos);
        }

        [HttpGet("{ID_Producto}", Name = "GetProducto")]
        public async Task<IActionResult> Get(int ID_Producto)
        {
            var datos = await this._productosData.GetProductoByID(ID_Producto);

            var productos = _mapper.Map<ProductoToReturnDTO>(datos);

            return Ok(productos);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProducto(ProductoForCreationDTO productoDTO)
        {

            var producto = _mapper.Map<Producto>(productoDTO);

            this._productosData.AddProducto(producto);

            var productotoreturn = _mapper.Map<ProductoToReturnDTO>(producto);

            if (await this._productosData.Save())
            {
                return CreatedAtRoute("GetProducto", new { ID_Producto = producto.ID_Producto }, productotoreturn);
            }

            throw new Exception("Fallo al crear el producto");



        }
    }
}
