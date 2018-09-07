#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Converters.ProductConverter.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Collections.Generic;
using System.Linq;
using MostDev.DataLayer.Converters.Core;
using MostDev.DataLayer.Entities;
using MostDev.DataLayer.Models;

#endregion

namespace MostDev.DataLayer.Converters
{
    public class ProductConverter : IConverter<Product, ProductModel>
    {
        public ProductModel ToModel(Product product)
        {
            return new ProductModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }

        public Product ToEntity(ProductModel product)
        {
            return new Product
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }

        public IEnumerable<ProductModel> ToModels(IEnumerable<Product> products)
        {
            return products.Select(ToModel).ToList();
        }

        public IEnumerable<Product> ToEntities(IEnumerable<ProductModel> products)
        {
            return products.Select(ToEntity).ToList();
        }
    }
}