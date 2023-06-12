using Business.Services.Contracts;
using StockTracking.Core.Entity;
using StockTracking.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductDataSource _blogRepository;

        public ProductService(ProductDataSource blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public void Add(Product article)
        {
            throw new NotImplementedException();
        }
    }
}
