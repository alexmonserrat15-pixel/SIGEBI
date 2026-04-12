using SIGEBI.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient("SIGEBI_API", client =>
{
    client.BaseAddress = new Uri("http://localhost:5170/");
});

builder.Services.AddScoped<UsuarioService>();

builder.Services.AddHttpClient("SIGEBI_API", client =>
{
    client.BaseAddress = new Uri("http://localhost:5170/");
});

builder.Services.AddScoped<GestionLibrosService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Usuario}/{action=Index}/{id?}");

app.Run();
