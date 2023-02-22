using Microsoft.EntityFrameworkCore;
using Core.Data;
using Business.IServices;
using Business.Services;
using Core.IRepositories;
using Core.Repositories;
using Business.Mappers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvc();

/*  Services  */
builder.Services.AddScoped<ICompanyService, CompanyService>();

/*  Repositories  */
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();

/*  EF Configuration  */
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);

builder.Services.AddCors(options => options.AddPolicy(name: "SAOrigins",
    policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
    }));


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("SAOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
