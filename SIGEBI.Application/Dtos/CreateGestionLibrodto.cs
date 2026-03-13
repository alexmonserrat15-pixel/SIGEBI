using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Dtos
{
        public class CreateGestionLibroDto
        {
            public string Titulo { get; set; } = string.Empty;

            public string Autor { get; set; } = string.Empty;

            public string ISBN { get; set; } = string.Empty;

            public int AnioPublicacion { get; set; }

            public string Categoria { get; set; } = string.Empty;
        }
    }
