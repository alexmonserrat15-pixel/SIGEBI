using SIGEBI.Application.Dtos.Prestamo;
using SIGEBI.Application.Interfaces;
using SIGEBI.Domain.Entities.SIGEBI;
using SIGEBI.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Services
{
    public class PrestamoService : IPrestamoService
    {
        private readonly IPrestamoRepository _repo;

        public PrestamoService(IPrestamoRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Prestamodto>> GetAll()
        {
            var data = await _repo.GetAllAsync();

            return data.Select(p => new Prestamodto
            {
                IdPrestamo = p.IdPrestamo,
                IdUsuario = p.IdUsuario,
                IdLibro = p.IdLibro,
                FechaPrestamo = p.FechaPrestamo,
                FechaDevolucion = p.FechaDevolucion,
                Estado = p.Estado
            });
        }

        public async Task<Prestamodto?> GetById(int id)
        {
            var p = await _repo.GetByIdAsync(id);
            if (p == null) return null;

            return new Prestamodto
            {
                IdPrestamo = p.IdPrestamo,
                IdUsuario = p.IdUsuario,
                IdLibro = p.IdLibro,
                FechaPrestamo = p.FechaPrestamo,
                FechaDevolucion = p.FechaDevolucion,
                Estado = p.Estado
            };
        }

        public async Task Crear(CreatePrestamoDto dto)
        {
            var prestamo = new Prestamo
            {
                IdUsuario = dto.IdUsuario,
                IdLibro = dto.IdLibro,
                FechaPrestamo = DateTime.Now,
                FechaDevolucion = dto.FechaDevolucionEsperada,
                Estado = "Activo"
            };

            await _repo.AddAsync(prestamo);
        }

        public async Task Actualizar(UpdatePrestamoDto dto)
        {
            var prestamo = await _repo.GetByIdAsync(dto.IdPrestamo);

            if (prestamo == null)
                throw new Exception("Prestamo no existe");

            prestamo.FechaDevolucion = dto.FechaDevolucionReal;
            prestamo.Estado = dto.Estado;

            await _repo.UpdateAsync(prestamo);
        }

        public async Task Eliminar(DeletePrestamoDto dto)
        {
            await _repo.DeleteAsync(dto.IdPrestamo);
        }
    }
}
