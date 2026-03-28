
using SIGEBI.Application.Interfaces;
using SIGEBI.Application.Services;
using SIGEBI.Domain.Interfaces.Repositories;
using SIGEBI.Domain.Repository.SIGEBI;
using SIGEBI.Infrastructure.Persistence.Repositories;
using static SIGEBI.Persistence.Repositories.SIGEBI.UsuariosRepositories;
using Microsoft.EntityFrameworkCore;
using SIGEBI.Infrastructure.Persistence;


namespace SIGEBI.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<SIGEBIDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Inyección de dependencias
            builder.Services.AddScoped<IUsuarioService, UsuarioService>();
            builder.Services.AddScoped<IGestionLibroService, GestionLibroService>();
            builder.Services.AddScoped<IPrestamoService, PrestamoService>();
            builder.Services.AddScoped<IPenalizacionService, PenalizacionService>();

            builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            builder.Services.AddScoped<IGestionLibroRepository, GestionLibroRepository>();
            builder.Services.AddScoped<IPrestamoRepository, PrestamoRepository>();
            builder.Services.AddScoped<IPenalizacionesRepository, PenalizacionRepository>();

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
