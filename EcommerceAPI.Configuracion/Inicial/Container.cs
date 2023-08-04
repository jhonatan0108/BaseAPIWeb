﻿using AutoMapper;
using EcommerceAPI.Infraestructura.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCore.AutoRegisterDi;
using System.Reflection;

namespace EcommerceAPI.Configuracion.Inicial
{
    public class Container
    {
        public static void ConfiguracionDependencias(IServiceCollection services, IConfiguration configuration)
        {
            #region [Configuracion de AUTO Mapper]
            var configMapper = new MapperConfiguration(cfg => cfg.AddProfile(new PerfilAutoMapper()));
            var mapper = configMapper.CreateMapper();
            services.AddSingleton(mapper);
            #endregion

            #region [Inyectar depencia de Contexto de BD]
           
            services.AddDbContext<EcommerceContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddSingleton<IConfiguration>(configuration);
            #endregion

            #region [Registro de Inyección de Dependencias]
            // services.AddScoped<CifradoHelper, ICifradoHelper>();
            var assembliesToScan = new[]
            {
                Assembly.GetExecutingAssembly(),
                Assembly.Load("ECommerceAPI.Dominio"),
                Assembly.Load("ECommerceAPI.Infraestructura"),
                Assembly.Load("ECommerceAPI.Comunes"),
            };
            services.RegisterAssemblyPublicNonGenericClasses(assembliesToScan)
                .Where(c => c.Name.EndsWith("Repository") ||
                       c.Name.EndsWith("Service") ||
                       c.Name.EndsWith("Helper"))
                .AsPublicImplementedInterfaces();
            #endregion

            #region [Configuración de CORS]
            services.AddCors(options =>
            {
                options.AddPolicy("PoliticaCors", builder =>
                {
                    builder.AllowAnyHeader();
                    builder.AllowAnyMethod();
                    builder.AllowAnyOrigin();
                });
            });
            #endregion
        }
    }
}
