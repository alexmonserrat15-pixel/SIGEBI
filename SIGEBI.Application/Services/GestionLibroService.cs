using SIGEBI.Application.Dtos.GestionLibros;
using SIGEBI.Application.Interfaces;
using SIGEBI.Domain.Entities.SIGEBI;
using SIGEBI.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIGEBI.Application.Services
{
    public class GestionLibroService : IGestionLibroService
    {
        private readonly IGestionLibroRepository _repo;

        public GestionLibroService(IGestionLibroRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<GestionLibroDto>> GetAll()
        {
            var data = await _repo.GetAllAsync();

            return data.Select(l => new GestionLibroDto
            {
                IdRecurso = l.IdRecurso,
                Titulo = l.Titulo,
                Autor = l.Autor,
                IdCategoria = l.IdCategoria,
                Estado = l.Estado
            });
        }

        public async Task<GestionLibroDto?> GetById(int id)
        {
            var l = await _repo.GetByIdAsync(id);
            if (l == null) return null;

            return new GestionLibroDto
            {
                IdRecurso = l.IdRecurso,
                Titulo = l.Titulo,
                Autor = l.Autor,
                IdCategoria = l.IdCategoria,
                Estado = l.Estado
            };
        }

        public async Task Crear(CreateGestionLibrodto dto)
        {
            var libro = new GestionLibros
            {
                Titulo = dto.Titulo,
                Autor = dto.Autor,
                ISBN = dto.ISBN,
                Editorial = dto.Editorial,
                AnioPublicacion = dto.AnioPublicacion,
                IdCategoria = dto.IdCategoria,
                CantidadTotal = dto.CantidadTotal,
                CantidadDisponible = dto.CantidadTotal, 
                Estado = "Disponible"
            };


            await _repo.AddAsync(libro);
        }

        public async Task Actualizar(UpdateGestionLibroDto dto)
        {
            var libro = await _repo.GetByIdAsync(dto.IdCategoria);

            if (libro == null)
                throw new Exception("Libro no existe");

            libro.Titulo = dto.Titulo;
            libro.Autor = dto.Autor;
            libro.IdCategoria = dto.IdCategoria;

            await _repo.UpdateAsync(libro);
        }

        public async Task Eliminar(DeleteGestionLibroDto dto)
        {
            await _repo.DeleteAsync(dto.IdLibro);
        }
    }
}
