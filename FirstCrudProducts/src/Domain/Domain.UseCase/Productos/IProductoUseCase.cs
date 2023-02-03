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
        Task<Producto> CrearProducto(Producto producto);
    }
}