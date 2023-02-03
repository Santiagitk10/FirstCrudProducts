using Domain.Model.Entities;
using Domain.Model.Entities.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCase.Productos
{
    /// <summary>
    /// <see cref="IProductoUseCase"/>
    /// </summary>
    public class ProductoUseCase : IProductoUseCase
    {
        private readonly IProductoRepository _ProductoRepository;

        /// <summary>
        ///  Initializes a new instance of the <see cref="ProductoUseCase"/> class.
        /// </summary>
        /// <param name="productoRepository"></param>
        public ProductoUseCase(IProductoRepository productoRepository)
        {
            _ProductoRepository = productoRepository;
        }

        /// <summary>
        /// <see cref="IProductoUseCase.CrearProducto(Producto)"/>
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public async Task<Producto> CrearProducto(Producto producto)
        {
            return await _ProductoRepository.CrearProducto(producto);
        }

        /// <summary>
        /// <see cref="IProductoUseCase.ObtenerProductos"/>
        /// </summary>
        /// <returns></returns>
        public async Task<List<Producto>> ObtenerProductos() =>
         await _ProductoRepository.ObtenerProductos();
    }
}