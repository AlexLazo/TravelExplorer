using Domain.Primitives;
using System;
using System.Collections.Generic;

namespace Domain.Paquete
{
    public sealed class Paquete : AggregateRoot
    {
        public Paquete(PaqueteId id, string nombre, string descripcion, DateTime fechaInicio, DateTime fechaFin, decimal precio, bool activo)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Precio = precio;
            Activo = activo;
        }

        private Paquete() { }

        public PaqueteId Id { get; private set; }
        public string Nombre { get; private set; } = string.Empty;
        public string Descripcion { get; private set; } = string.Empty;
        public DateTime FechaInicio { get; private set; }
        public DateTime FechaFin { get; private set; }
        public decimal Precio { get; private set; }
        public bool Activo { get; private set; }

        public void Update(string nombre, string descripcion, DateTime fechaInicio, DateTime fechaFin, decimal precio, bool activo)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Precio = precio;
            Activo = activo;
        }
    }
}
