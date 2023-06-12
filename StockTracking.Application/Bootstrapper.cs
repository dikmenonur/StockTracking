using Autofac;
using Business.Services;
using Business.Services.Contracts;
using StockTracking.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF.DependencyInjection.Web
{
    public static class Bootstrapper
    {
        /// <summary>
        /// Configures and builds Autofac IOC container.
        /// </summary>
        /// <returns></returns>
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            // register services
            
            builder.RegisterType<ProductService>().As<IProductService>();

            // register repositories and UnitOfWork
            builder.RegisterType<ProductDataSource>().As<IProductDataSource>();
            builder.RegisterType<ProductDbContext>();

            // build container
            return builder.Build();
        }
    }
}