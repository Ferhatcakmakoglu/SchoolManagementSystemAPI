using Autofac;
using Autofac.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLayer.API.Filters;
using NLayer.API.Middlewares;
using NLayer.API.Modules;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Repository;
using NLayer.Repository.Repositories;
using NLayer.Repository.UnitOfWorks;
using NLayer.Service.Mapping;
using NLayer.Service.Services;
using NLayer.Service.Validations;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//Burada Fluent Validaton un kendi Filter ini bask�lad�k yani kendi filter imizi �al��t�rd�k
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

//Filter lerimiz eklendi options ile. Validations lar ise x ile eklendi
builder.Services.AddControllers(options => options.Filters.Add(new ValidateFilterAttribute())).AddFluentValidation(x =>
{
    x.RegisterValidatorsFromAssemblyContaining<StudentDtoValidator>();
    x.RegisterValidatorsFromAssemblyContaining<TeacherDtoValidator>();
    x.RegisterValidatorsFromAssemblyContaining <SchoolDtoValidator>();
});





 

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



/*
   !!
        BU KISIM AUTOFAC ILE ISEVSIZ HALE GELDI!!!
   !!
 */
//Interface ler ile ilgili class lar birlestirildi
/*builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddScoped<IStudentsWithSchoolRepository, StudentsWithSchoolRepository>();
builder.Services.AddScoped<IStudentsWithSchoolService, StudentWithSchoolService>();
builder.Services.AddScoped<ISchoolWithTeacherService, SchoolWithTeacherService>();
builder.Services.AddScoped<ISchoolWithTeacherRepository, SchoolWithTeacherRepository>();
*/


//NotFoundFilter Tan�mlama
builder.Services.AddScoped(typeof(NotFoundFilter<>));
//AutoMapper Dahil ettik
builder.Services.AddAutoMapper(typeof(MapProfile));


//appsetting.json daki SqlConnection �n yeri soylendi
builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

//Autofac dahil ettigimiz yer 
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
//Tek bir module oldugu icin boyle hallettik. Birden fazla module olsayd� her birini bu sekil ekleyecektik
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepoServiceModule()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


//kendi ekledigimiz middleware implement
app.UseCustomException();


app.UseAuthorization();

app.MapControllers();

app.Run();
