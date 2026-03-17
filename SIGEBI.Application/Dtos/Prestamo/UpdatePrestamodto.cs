using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Dtos.Prestamo
{
    public class UpdatePrestamoDto
    {
        public int IdPrestamo { get; set; }

        public DateTime FechaDevolucion { get; set; }

        public string Estado { get; set; } = string.Empty;
    }
}
