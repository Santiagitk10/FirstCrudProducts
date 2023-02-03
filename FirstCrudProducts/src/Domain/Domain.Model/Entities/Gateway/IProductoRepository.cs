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
        /// FindAll
        /// </summary>
        /// <returns>Entity list</returns>
        //List<Producto> FindAll(Producto entity = null);
    }
}