using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligaBetplay.Dominio.Entidades
{
    public class Torneo
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string? Ubicacion { get; set; }
        public string? Estado { get; set; } // activo, finalizado, cancelado
    }
}