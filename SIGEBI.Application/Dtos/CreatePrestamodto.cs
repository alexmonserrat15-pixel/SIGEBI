using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Dtos
{
    public class CreatePrestamodto
    {
        public int IdUsuario { get; set; }

        public int IdLibro { get; set; }

        public DateTime FechaDevolucionEsperada { get; set; }
    }
}
