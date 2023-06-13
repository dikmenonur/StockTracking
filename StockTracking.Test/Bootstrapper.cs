using Autofac;
using Moq;
using StockTracking.Core.Entity;
using StockTracking.Core.Repositories;
using StockTracking.Services;
using StockTracking.Services.Contracts;
using StockTracking.Test;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.ServiceModel;
using System.Web;
namespace StockTracking.Test
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

            // register proxies
            builder.Register(c => new ChannelFactory<IProductService>("BasicHttpBinding_IProductService"))
                .InstancePerLifetimeScope();

            // DbFactory
            var _productRepository = new Mock<IProductDataSource>();
            _productRepository.Setup(x => x.GetAll()).ReturnsAsync(new List<Product>()
                {
                    new Product() {
                        ID = 1,
                        Code= "PRD-01",
                        Amount=2500,
                        CreateDate= DateTime.Now,
                        Desc="Deneme 1",
                        Name="Kalem"
                    }
                });
            builder.RegisterInstance(_productRepository.Object).As<IProductDataSource>();
            builder.RegisterType<ClientInjectionClass>();
            // build container
            return builder.Build();
        }
    }
}