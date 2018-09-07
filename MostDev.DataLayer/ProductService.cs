using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostDev.DataLayer.Converters;
using MostDev.DataLayer.Core;
using MostDev.DataLayer.Entities;
using MostDev.DataLayer.Interfaces;
using MostDev.DataLayer.Models;

namespace MostDev.DataLayer
{
    public class ProductService : BaseService<Product, ProductModel>, IProductService, IDisposable
    {
        public ProductService()
        {
            base.Converter = new ProductConverter();
        }

        public override void AddOrUpdate(Guid userId, ProductModel model)
        {
            var product = Context.Products.FirstOrDefault(u => u.Id == model.Id);
            if (product == default(Product))
            {
                product = Converter.ToEntity(model);
            }
            else
            {
                product.UpdateEntity(model);
                
            }

            Context.SaveChanges();

        }

        public override ProductModel GetItem(Guid id)
        {
            return Converter.ToModel(Context.Products.FirstOrDefault(u => u.Id == id));
        }

        public override IEnumerable<ProductModel> GetAllItems()
        {
            return Converter.ToModels(Context.Products);
        }

         public override bool Delete(ProductModel model)
        {
            var e = base.Context.Set<Product>().FirstOrDefault(u => u.Id == model.Id);
            Context.Set<Product>().Remove(e);
            return true;

        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
