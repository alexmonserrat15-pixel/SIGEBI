using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SIGEBI.Domain.Entities.SIGEBI
{
    public sealed class GestionLibros
    {
        [Key]
        public int IdRecurso { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string? ISBN { get; set; }
        public string? Editorial { get; set; }
        public int? AnioPublicacion { get; set; }
        public int IdCategoria { get; set; }
        public string Estado { get; set; }
        public int CantidadTotal { get; set; }
        public int CantidadDisponible { get; set; }


    }
}
