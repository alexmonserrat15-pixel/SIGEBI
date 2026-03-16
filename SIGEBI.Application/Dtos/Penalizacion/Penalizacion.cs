using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Dtos.Penalizacion
{
    public class Penalizaciondto
    {
        public int IdUsuario { get; set; }

        public string Motivo { get; set; } = string.Empty;

        public decimal Monto { get; set; }
    }
}
