using SIGEBI.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SIGEBI.Domain.Entities.SIGEBI
{
    [Table("Categorias", Schema = "SIGEBI")]
    public sealed class Categorias
    {
        [Key]
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }

    }
}
