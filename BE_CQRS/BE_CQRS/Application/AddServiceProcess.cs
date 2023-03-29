using BE_CQRS.Application.DTOs.Command.CreateCommand;
using BE_CQRS.Interface;
using BE_CQRS.Models.Entities.Core;
using MediatR;
using BE_CQRS.Models;
using BE_CQRS.Interface.InterfaceModel;
using BE_CQRS.Repository.RepositoryModel;
using BE_CQRS.Application.DTOs.Handlers.CreateHandlers;
using BE_CQRS.Application.Data.Queries.GetByIdQuery;
using BE_CQRS.Application.Data.Handlers.GetByIdHandler;
using BE_CQRS.Application.DTOs.Command.UpdateCommand;
using BE_CQRS.Application.DTOs.Handlers.UpdateHandlers;
using BE_CQRS.Application.DTOs.Command.DeleteCommand;
using BE_CQRS.Application.DTOs.Handlers.DeleteHandlers;
using BE_CQRS.Application.Data.Queries.GetAllQuery;
using BE_CQRS.Application.Data.Handlers.GetAllHandler;
using Microsoft.Extensions.DependencyInjection;
using BE_CQRS.Repository;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.AspNetCore.Hosting;
using Autofac.Core;
using System.Reflection;

namespace BE_CQRS.Application
{
    public static class AddServiceProcess
    {
        public static IServiceCollection AddServiceHandlerQuery(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddMediatR(typeof(AddServiceProcess)); //Đăng ký MediatR
            //services.AddMediatR(typeof(CreateTypeUnitCommand));
            //services.AddMediatR(typeof(UpdateTypeUnitCommand));
            //services.AddMediatR(typeof(DeleteTypeUnitCommand));
            //services.AddMediatR(typeof(GetAllTypeUnitQuery));
            //services.AddMediatR(typeof(GetByIdTypeUnitQuery));

            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));


            // Đăng ký IDbContext và các lớp Repository
            //services.AddScoped<IRepository<TypeUnit>, Repository<TypeUnit>>();
            //services.AddScoped<IDbContext, PostgreDbContext>();
            //services.AddScoped<ITypeProduct, TypeProductRepo>();

            //services.AddScoped<GetAllTypeUnitQuery>();
            //services.AddScoped<GetByIdTypeUnitQuery>();
            //services.AddScoped<CreateTypeUnitCommand>();
            //services.AddScoped<UpdateTypeUnitCommand>();
            //services.AddScoped<DeleteTypeUnitCommand>();

            // Đăng ký các Command Handler và Query Handler
            //services.AddScoped<IQueryHandler<GetAllTypeUnitQuery, IEnumerable<TypeUnit>>, GetAllTypeUnitHandler>();
            //services.AddScoped<IQueryHandler<GetByIdTypeUnitQuery, TypeUnit>, GetByIdTypeUnitHandler>();
            //services.AddScoped<ICommandHandler<CreateTypeUnitCommand, TypeUnit>, CreateTypeUnitHandler>();
            //services.AddScoped<ICommandHandler<UpdateTypeUnitCommand, bool>, UpdateTypeUnitHandler>();
            //services.AddScoped<ICommandHandler<DeleteTypeUnitCommand, bool>, DeleteTypeUnitHandler>();


            // Đăng ký Mediator để xử lý Command và Query
            services.AddScoped<MediatR.IMediator, Mediator>();

            return services;
        }
    }
}
