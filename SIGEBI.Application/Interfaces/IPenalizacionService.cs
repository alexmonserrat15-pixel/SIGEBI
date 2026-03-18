using SIGEBI.Application.Dtos.Penalizacion;
using System;
using System.Collections.Generic;
using System.Text;
using static SIGEBI.Application.Dtos.Penalizacion.CreatePenalizaciondto;
using static SIGEBI.Application.Dtos.Penalizacion.DeletePenalizaciondto;

namespace SIGEBI.Application.Interfaces
{
    public interface IPenalizacionService
    {
        Task<IEnumerable<Penalizaciondto>> GetAll();

        Task<Penalizaciondto?> GetById(int id);

        Task Crear(CreatePenalizacionDto dto);

        Task Actualizar(UpdatePenalizacionDto dto);

        Task Eliminar(DeletePenalizacionDto dto);
    }
}
