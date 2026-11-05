using BibliotecaAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BibliotecaDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("BibliotecaConnection"),
        ServerVersion.AutoDetect(
            builder.Configuration.GetConnectionString("BibliotecaConnection")
        )
    )
);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOpenApi();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();