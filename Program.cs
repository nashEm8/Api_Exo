//using Exo.WebApi.Contexts;
//using Exo.WebApi.Repositories;
using Exo.WebAPi.Contexts;
using Exo.WebAPi.Repositories;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ExoContext, ExoContext>();
builder.Services.AddControllers();
builder.Services.AddTransient<ProjetoRepository, ProjetoRepository>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
