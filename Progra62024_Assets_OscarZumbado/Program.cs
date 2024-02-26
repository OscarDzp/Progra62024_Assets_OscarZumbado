using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Progra62024_Assets_OscarZumbado.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();

        //Aca agregamos los valores de conexion a la base de datos para nuestra aplicacion

        //1. agregar la info en una etiquta en el archivo appsettins.json

        var CnnStrBuilder = new SqlConnectionStringBuilder(builder.Configuration.GetConnectionString("CNNSTR"));

        //por seguridad es mejor agregar la info de la contrasenia en este codigo o
        //podriamos tener un almacen externo.
        //Investigar que son los user secrets
        CnnStrBuilder.Password = "progra6";

        //ahora que hemos extraido la info de la cadena de conexion
        //creamos una variable tipo string que la almacene
        string CnnStr = CnnStrBuilder.ConnectionString;

        //ahora conectamos el proyecto a la base de datos.

        builder.Services.AddDbContext<Progra620241Context>(options => options.UseSqlServer(CnnStr));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}