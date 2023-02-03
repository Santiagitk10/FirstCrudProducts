using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryPoints.ReactiveWeb.Entity
{
    /// <summary>
    /// Producto request DTO
    /// </summary>
    public class ProductoRequest
    {
        /// <summary>
        /// nombre
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Cantidad en Inventario
        /// </summary>
        public int EnInventario { get; set; }

        /// <summary>
        /// Disponibilidad
        /// </summary>
        public bool EstaDisponible { get; set; }

        /// <summary>
        /// Precio
        /// </summary>
        public double Precio { get; set; }

        /// <summary>
        /// Peso
        /// </summary>
        public double Peso { get; set; }

        /// <summary>
        /// Convertir a entidad de dominio
        /// </summary>
        /// <returns></returns>
        public Producto AsEntity()
        {
            return new Producto(Nombre, EnInventario, EstaDisponible, Precio, Peso);
        }
    }
}