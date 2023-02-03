using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Model.Entities.Gateway
{
    /// <summary>
    /// IProductoRepository
    /// </summary>
    public interface IProductoRepository
    {
        /// <summary>
        /// Crear Producto
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>Product</returns>
        Task<Producto> CrearProducto(Producto producto);

        /// <summary>
        /// Obtener todos los productos
        /// </summary>
        /// <returns>Entity list</returns>
        Task<List<Producto>> ObtenerProductos();
    }
}