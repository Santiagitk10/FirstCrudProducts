using Domain.Model.Entities;
using DrivenAdapters.Mongo.Entities.Base;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivenAdapters.Mongo.Entities
{
    public class ProductoEntity : Base.EntityBase, IDomainEntity<Producto>
    {
        /// <summary>
        /// nombre
        /// </summary>
        [BsonElement(elementName: "nombre")]
        public string Nombre { get; set; }

        /// <summary>
        /// Cantidad en Inventario
        /// </summary>
        [BsonElement(elementName: "enInventario")]
        public int EnInventario { get; set; }

        /// <summary>
        /// Disponibilidad
        /// </summary>
        [BsonElement(elementName: "estaDisponible")]
        public bool EstaDisponible { get; set; }

        /// <summary>
        /// Precio
        /// </summary>
        [BsonElement(elementName: "precio")]
        public double Precio { get; set; }

        /// <summary>
        /// Peso
        /// </summary>
        [BsonElement(elementName: "peso")]
        public double Peso { get; set; }

        /// <summary>
        /// Convertir a entidad de dominio
        /// </summary>
        /// <returns></returns>
        public Producto AsEntity()
        {
            return new Producto(Id, Nombre, EnInventario, EstaDisponible, Precio, Peso);
        }

        //Lo mismo de arriba pero con arrow function
        //public Producto AsEntity() =>
        //  new(Id, Nombre, EnInventario, EstaDisponible, Precio, Peso);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="enInventario"></param>
        /// <param name="estaDisponible"></param>
        /// <param name="precio"></param>
        /// <param name="peso"></param>
        public ProductoEntity(string nombre, int enInventario, bool estaDisponible, double precio, double peso)
        {
            Nombre = nombre;
            EnInventario = enInventario;
            EstaDisponible = estaDisponible;
            Precio = precio;
            Peso = peso;
        }
    }
}