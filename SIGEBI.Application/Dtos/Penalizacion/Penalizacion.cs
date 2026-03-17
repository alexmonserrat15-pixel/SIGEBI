using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Dtos.Penalizacion
{
    public class Penalizaciondto
    {
        public int IdPenalizacion { get; set; }
        public int IdUsuario { get; set; }
        public int IdPrestamo { get; set; }
        public string Motivo { get; set; }
        public int? Monto { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Estado { get; set; }
    }
}
