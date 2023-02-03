using System;

namespace Domain.Model.Entities
{
    /// <summary>
    /// Clase Producto
    /// </summary>
    public class Producto
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// nombre
        /// </summary>
        public string Nombre { get; private set; }

        /// <summary>
        /// Cantidad en Inventario
        /// </summary>
        public int EnInventario { get; private set; }

        /// <summary>
        /// Disponibilidad
        /// </summary>
        public bool EstaDisponible { get; private set; }

        /// <summary>
        /// Precio
        /// </summary>
        public double Precio { get; private set; }

        /// <summary>
        /// Peso
        /// </summary>
        public double Peso { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="enInventario"></param>
        /// <param name="estaDisponible"></param>
        /// <param name="precio"></param>
        /// <param name="peso"></param>
        public Producto(string id, string nombre, int enInventario, bool estaDisponible,
            double precio, double peso)
        {
            Id = id;
            Nombre = nombre;
            EnInventario = enInventario;
            EstaDisponible = estaDisponible;
            Precio = precio;
            Peso = peso;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="enInventario"></param>
        /// <param name="estaDisponible"></param>
        /// <param name="precio"></param>
        /// <param name="peso"></param>
        public Producto(string nombre, int enInventario, bool estaDisponible, double precio, double peso)
        {
            Nombre = nombre;
            EnInventario = enInventario;
            EstaDisponible = estaDisponible;
            Precio = precio;
            Peso = peso;
        }
    }
}