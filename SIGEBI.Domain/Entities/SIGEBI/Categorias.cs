using SIGEBI.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SIGEBI.Domain.Entities.SIGEBI
{
    public sealed class Categorias
    {
        [Key]
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }

    }
}
