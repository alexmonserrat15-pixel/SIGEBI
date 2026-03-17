using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Dtos.GestionLibros
{
    public class UpdateGestionLibroDto
    {
        public int IdLibro { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string Autor { get; set; } = string.Empty;

        public string Categoria { get; set; } = string.Empty;
    }
}
