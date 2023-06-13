using Autofac;
using Autofac.Integration.Wcf;
using NUnit.Framework;
using StockTracking.Services;
using StockTracking.Services.Contracts;
using System;
using System.ServiceModel;

namespace StockTracking.Test
{
    public class Tests
    {
        IContainer container = null;
        ServiceHost svcproductHost = null;
        Uri svcProductServiceURI = new Uri("http://localhost:18850/ProductService.svc");


        [SetUp]
        public void Setup()
        {

            try
            {
                container = Bootstrapper.BuildContainer();

                svcproductHost = new ServiceHost(typeof(ProductService), svcProductServiceURI);

                svcproductHost.AddDependencyInjectionBehavior<IProductService>(container);

                svcproductHost.Open();
            }
            catch (Exception ex)
            {
                svcproductHost = null;
            }
        }

        [Test]
        public void test_self_host_connection()
        {
            Assert.That(svcproductHost.State, Is.EqualTo(CommunicationState.Opened));
        }


        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}