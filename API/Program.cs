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

/*  Services  */
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IApproverService, ApproverService>();
builder.Services.AddScoped<IBrSourceService, BrSourceService>();
builder.Services.AddScoped<IProfileService, ProfileService>();
builder.Services.AddScoped<IBrTypeService, BrTypeService>();
builder.Services.AddScoped<ILevelService, LevelService>();
builder.Services.AddScoped<ITypeService, TypeService>();
builder.Services.AddScoped<IPlaceOfDeliveryService, PlaceOfDeliveryService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IPTMOwnerService, PTMOwnerService>();
builder.Services.AddScoped<ISubContractorService, SubContractorService>();
builder.Services.AddScoped<ITypeOfCostService, TypeOfCostService>();
builder.Services.AddScoped<IPaymentTermService, PaymentTermService>();
builder.Services.AddScoped<IAppParameterService, AppParameterService>();
builder.Services.AddScoped<IRecruitmentResponsibleService, RecruitmentResponsibleService>();
builder.Services.AddScoped<IRequestFormStatusService, RequestFormStatusService>();
builder.Services.AddScoped<IHighestDegreeService, HighestDegreeService>();
builder.Services.AddScoped<IOERPCodeService, OERPCodeService>();

/*  Repositories  */
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

/*  EF Configuration  */
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), op => op.CommandTimeout(50000));
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
