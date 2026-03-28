using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Dtos.Prestamo
{
    public class CreatePrestamoDto
    {
        public int IdUsuario { get; set; }

        public int IdRecurso { get; set; }

        public DateTime FechaDevolucion { get; set; }
    }
}
