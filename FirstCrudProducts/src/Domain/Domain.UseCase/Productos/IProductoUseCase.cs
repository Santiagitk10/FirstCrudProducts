using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCase.Productos
{
    /// <summary>
    /// Producto UseCase
    /// </summary>
    public interface IProductoUseCase
    {
        /// <summary>
        /// Crear Producto
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        Task<Producto> CrearProducto(Producto producto);

        /// <summary>
        /// Obtener todos los productos
        /// </summary>
        /// <returns></returns>
        Task<List<Producto>> ObtenerProductos();
    }
}