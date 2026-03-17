using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Dtos.Prestamo
{
    public class Prestamodto
    {
        public int IdPrestamo { get; set; }
        public int IdRecurso { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string Estado { get; set; }
    }
}
