using SIGEBI.Application.Dtos.GestionLibros;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Interfaces
{
    public interface IGestionLibroService
    {
        Task<IEnumerable<GestionLibroDto>> GetAll();

        Task<GestionLibroDto?> GetById(int id);

        Task Crear(CreateGestionLibrodto dto);

        Task Actualizar(UpdateGestionLibroDto dto);

        Task Eliminar(DeleteGestionLibroDto dto);
    }
}
