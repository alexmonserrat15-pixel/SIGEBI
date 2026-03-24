using SIGEBI.Application.Dtos.Penalizacion;
using SIGEBI.Application.Interfaces;
using SIGEBI.Domain.Entities.SIGEBI;
using SIGEBI.Domain.Repository.SIGEBI;
using SIGEBI.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using static SIGEBI.Application.Dtos.Penalizacion.CreatePenalizaciondto;
using static SIGEBI.Application.Dtos.Penalizacion.DeletePenalizaciondto;

namespace SIGEBI.Application.Services
{
    public class PenalizacionService : IPenalizacionService
    {
        private readonly IPenalizacionesRepository _repo;

        public PenalizacionService(IPenalizacionesRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Penalizaciondto>> GetAll()
        {
            var data = await _repo.GetAllAsync();

            return data.Select(p => new Penalizaciondto
            {
                IdPenalizacion = p.IdPenalizacion,
                IdUsuario = p.IdUsuario,
                Motivo = p.Motivo,
                Monto = p.Monto,
            });
        }

        public async Task<Penalizaciondto?> GetById(int id)
        {
            var p = await _repo.GetByIdAsync(id);
            if (p == null) return null;

            return new Penalizaciondto
            {
                IdPenalizacion = p.IdPenalizacion,
                IdUsuario = p.IdUsuario,
                Motivo = p.Motivo,
                Monto = p.Monto,
            };
        }

        public async Task Crear(CreatePenalizacionDto dto)
        {
            var penalizacion = new Penalizacion
            {
                IdUsuario = dto.IdUsuario,
                Motivo = dto.Motivo,
                Monto = dto.Monto,
                Pagada = false,
                FechaPenalizacion = DateTime.Now
            };

            await _repo.AddAsync(penalizacion);
        }

        public async Task Actualizar(UpdatePenalizacionDto dto)
        {
            var p = await _repo.GetByIdAsync(dto.IdPenalizacion);

            if (p == null)
                throw new Exception("Penalizacion no existe");

            p.Pagada = dto.Pagada;

            await _repo.UpdateAsync(p);
        }

        public async Task Eliminar(DeletePenalizacionDto dto)
        {
            await _repo.DeleteAsync(dto.IdPenalizacion);
        }
    }
}
