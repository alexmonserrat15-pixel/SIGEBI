using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Dtos.Prestamo
{
    public class Prestamodto
    {
        public int IdUsuario { get; set; }

        public int IdLibro { get; set; }

        public DateTime FechaDevolucionEsperada { get; set; }
    }
}
