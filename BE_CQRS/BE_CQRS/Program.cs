using Autofac.Core;
using BE_CQRS.Application;
using BE_CQRS.Application.Data.Handlers.GetAllHandler;
using BE_CQRS.Application.Data.Handlers.GetByIdHandler;
using BE_CQRS.Application.Data.Queries.GetAllQuery;
using BE_CQRS.Application.Data.Queries.GetByIdQuery;
using BE_CQRS.Application.DTOs.Command.CreateCommand;
using BE_CQRS.Application.DTOs.Command.DeleteCommand;
using BE_CQRS.Application.DTOs.Command.UpdateCommand;
using BE_CQRS.Application.DTOs.Handlers.CreateHandlers;
using BE_CQRS.Application.DTOs.Handlers.DeleteHandlers;
using BE_CQRS.Application.DTOs.Handlers.UpdateHandlers;
using BE_CQRS.Interface;
using BE_CQRS.Interface.Commands;
using BE_CQRS.Interface.InterfaceModel;
using BE_CQRS.Interface.Query;
using BE_CQRS.Models;
using BE_CQRS.Models.Entities.Core;
using BE_CQRS.MongoDBText;
using BE_CQRS.Repository.RepositoryModel;
using BE_CQRS.Repository.RepositotyMongo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Reflection;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<ProductDatabaseSetting>(builder.Configuration.GetSection(nameof(ProductDatabaseSetting)));
builder.Services.AddSingleton<IProductDatabaseSetting>(sp => sp.GetRequiredService<IOptions<ProductDatabaseSetting>>().Value);
builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(builder.Configuration.GetValue<string>("MongoDBConnection:ConnectionString")));


builder.Services.AddControllersWithViews().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// add AutoMapper to DI
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Add MediatR
builder.Services.AddMediatR(cfg=>cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

//builder.Services.AddScoped<IDbContext, PostgreDbContext>();
//builder.Services.AddScoped<BE_CQRS.Repository.RepositotyMongo.ITypeUnitRepo, BE_CQRS.Repository.RepositotyMongo.TypeUnitRepo>;
builder.Services.AddScoped<ITypeUnit, BE_CQRS.Repository.RepositoryPostgre.TypeUnitRepo>();
builder.Services.AddScoped<ITypeUnitRepo, TypeUnitRepo>();

// kết nối db mongodb
//builder.Services.AddSingleton<MongoDbContext>();

// Add PostgreSQL
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<PostgreDbContext>(option =>
option.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQLDatabase")));

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
