using SIGEBI.Application.Dtos.Prestamo;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Interfaces
{
    public interface IPrestamoService
    {
        Task<IEnumerable<Prestamodto>> GetAll();

        Task<Prestamodto?> GetById(int id);

        Task Crear(CreatePrestamoDto dto);

        Task Actualizar(UpdatePrestamoDto dto);

        Task Eliminar(DeletePrestamoDto dto);
    }
}
