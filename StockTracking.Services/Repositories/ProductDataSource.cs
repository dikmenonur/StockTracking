using StockTracking.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Core.Repositories
{
    public class ProductDataSource : IProductDataSource
    {
        private readonly ProductDbContext _productDbContext;
        public ProductDataSource(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _productDbContext.Product.ToListAsync();
        }

        public async Task<Product> GetById(long id)
        {
            return await _productDbContext.Product.FirstOrDefaultAsync(t => t.ID == id);
        }


        public async Task<Product> UpdateStockAsync(long id, int quantity)
        {
            var product = await _productDbContext.Product.FirstOrDefaultAsync(t => t.ID == id);
            product.StockProduct.Quantity = quantity;
            this._productDbContext.Entry(product.StockProduct).State = EntityState.Modified;
            return product;
        }

        public async Task<Product> SellProductAsync(long id, int quantity)
        {
            var product = await _productDbContext.Product.FirstOrDefaultAsync(t => t.ID == id);
            product.StockProduct.Quantity = quantity;
            this._productDbContext.Entry(product.StockProduct).State = EntityState.Modified;

            SellProduct sellProduct = new SellProduct()
            {
                ProductId = product.ID,
                SellDate = DateTime.Now,
            };

            this._productDbContext.Entry(sellProduct).State = EntityState.Added;
            await this._productDbContext.SaveChangesAsync();

            return product;
        }

        public async Task<long> AddNewProductAsync(Product product)
        {
            this._productDbContext.Entry(product).State = EntityState.Added;
            await this._productDbContext.SaveChangesAsync();
            return product.ID;
        }

        public async Task<long> UpdateNewProductAsync(Product product)
        {
            this._productDbContext.Entry(product).State = EntityState.Modified;
            await this._productDbContext.SaveChangesAsync();
            return product.ID;
        }

        public async Task<bool> BulkInsertProductAsync(List<Product> products)
        {
            bool IsComplete = false;
            using (var context = _productDbContext)
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (var product in products)
                        {
                            await AddNewProductAsync(product);
                        }

                        context.SaveChanges();

                        dbContextTransaction.Commit();
                        IsComplete = true;
                    }
                    catch (Exception)
                    {
                        IsComplete = false;
                        dbContextTransaction.Rollback();
                        throw;
                    }
                }
            }

            return IsComplete;

        }
    }
}
