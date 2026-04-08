namespace SIGEBI.Web.Models.Dtos.GestionLibros
{
    public class CreateLibroDto
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public string Editorial { get; set; }
        public int AnioPublicacion { get; set; }
        public int IdCategoria { get; set; }
        public int CantidadTotal { get; set; }
    }
}
