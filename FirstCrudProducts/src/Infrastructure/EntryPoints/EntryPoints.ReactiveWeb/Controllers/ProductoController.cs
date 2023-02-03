using Domain.Model.Entities;
using Domain.Model.Interfaces;
using Domain.UseCase.Productos;
using EntryPoints.ReactiveWeb.Base;
using EntryPoints.ReactiveWeb.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static credinet.comun.negocio.RespuestaNegocio<credinet.exception.middleware.models.ResponseEntity>;
using static credinet.exception.middleware.models.ResponseEntity;
using Microsoft.AspNetCore.Http;

namespace EntryPoints.ReactiveWeb.Controllers
{
    /// <summary>
    /// ProductoController
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    public class ProductoController : AppControllerBase<ProductoController>
    {
        private readonly IProductoUseCase _productoUseCase;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductoController"/> class.
        /// </summary>
        /// <param name="eventsService"></param>
        /// <param name="productoUseCase"></param>
        public ProductoController(IManageEventsUseCase eventsService, IProductoUseCase productoUseCase) :
            base(eventsService)
        {
            _productoUseCase = productoUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> CrearProducto(ProductoRequest productoRequest) =>
            await HandleRequestAsync(
                async () =>
                {
                    Producto nuevoProducto = productoRequest.AsEntity();
                    return await _productoUseCase.CrearProducto(nuevoProducto);
                }, "");

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> ObtenerProductos() =>
            await HandleRequestAsync(
                    async () =>
                        {
                            return await _productoUseCase.ObtenerProductos();
                        }, "");

        [HttpPut("/{id}")]
        public async Task<IActionResult> ModificarProducto([FromQuery] string id, ProductoRequest productoRequest) =>
            await HandleRequestAsync(
                async () =>
                {
                    Producto productoAModificar = productoRequest.AsEntityWithID(id);
                    await _productoUseCase.ModificarProducto(productoAModificar);
                }, "");
    }
}