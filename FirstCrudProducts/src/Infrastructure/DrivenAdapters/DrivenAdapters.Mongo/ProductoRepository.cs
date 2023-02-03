using Domain.Model.Entities;
using Domain.Model.Entities.Gateway;
using DrivenAdapters.Mongo.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivenAdapters.Mongo
{
    /// <summary>
    /// Product Adapter
    /// </summary>
    public class ProductoRepository : IProductoRepository
    {
        private readonly IMongoCollection<ProductoEntity> _coleccionProductos;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductoRepository"/> class.
        /// </summary>
        /// <param name="mongodb">The mapper.</param>
        public ProductoRepository(IContext mongodb)
        {
            _coleccionProductos = mongodb.Productos;
        }

        /// <summary>
        /// <see cref="IProductoRepository."/>
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public async Task<Producto> CrearProducto(Producto producto)
        {
            ProductoEntity nuevoProducto =
                new(producto.Nombre, producto.EnInventario, producto.EstaDisponible, producto.Precio, producto.Peso);

            await _coleccionProductos.InsertOneAsync(nuevoProducto);

            return nuevoProducto.AsEntity();
        }

        public async Task<List<Producto>> ObtenerProductos()
        {
            IAsyncCursor<ProductoEntity> productosEntity =
                await _coleccionProductos.FindAsync(Builders<ProductoEntity>.Filter.Empty);

            List<Producto> productos = productosEntity.ToEnumerable()
                .Select(productoEntity => productoEntity.AsEntity()).ToList();

            return productos;
        }
    }
}