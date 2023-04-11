#region BuilderServices

using MDN.DDD.API.Filters;
using MDN.DDD.API.Profiles;
using MDN.DDD.Domain.Entities;
using MDN.DDD.Domain.Interfaces.Repositories;
using MDN.DDD.Domain.Interfaces.Services;
using MDN.DDD.Domain.Services;
using MDN.DDD.Domain.Settings;
using MDN.DDD.Infrastructure.Contexts;
using MDN.DDD.Infrastructure.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddControllers(options =>
{
    options.Filters.Add(typeof(ExceptionFilter));
    options.Filters.Add(typeof(ValidationFilter));
});

#region AppSettings

var appSetting = builder.Configuration.GetSection(nameof(AppSetting)).Get<AppSetting>();
builder.Services.AddSingleton(appSetting);

#endregion

#region Mapper

//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var mappingConfig = new MapperConfiguration(mc =>
{ mc.AddProfile(new MappingProfile()); });
var mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(typeof(AutoMapperConfiguration));

#endregion

#region Services

builder.Services.AddScoped<IPerfilService, PerfilService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IEnderecoService, EnderecoService>();

#endregion

#region Repositories

builder.Services.AddScoped<IPerfilRepository, PerfilRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();

#endregion

#region Dbcontext
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//var connectionString = appSetting.SqlServerConnection;

builder.Services.AddDbContext<ManutencaoContext>(options => {
    options.UseSqlServer(appSetting.SqlServerConnection);
    options.UseLazyLoadingProxies();
});


#endregion

#region HttpClient

builder.Services.AddHttpClient<INacionalidadeRepository, NacionalidadeRepository>(options =>
{
    options.BaseAddress = new Uri(appSetting.ApiNacionalidade);
});

builder.Services.AddHttpClient<IBrasilApiRepository, BrasilApiRepository>(options => { });


#endregion

#endregion

#region AppConfiguration

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();


#endregion
