using Microsoft.EntityFrameworkCore;
using PostgreSqlExample.Data;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy("corsapp", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
        .AllowAnyHeader();
    });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration.GetConnectionString("DefaultConnection");


//builder.Services.AddScoped<DbContext>(provider => provider.GetService<PostgreSqlExampleDbContext>());


builder.Services.AddDbContext<PostgreSqlExampleDbContext>
    (options =>
    {
        options.UseNpgsql(connection,b=>b.MigrationsAssembly("PostgreSqlExample.Data"));
    });

//builder.Services.AddScoped<PostgreSqlExampleDbContext>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
