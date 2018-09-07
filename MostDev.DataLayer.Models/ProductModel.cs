#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Models.ProductModel.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using MostDev.DataLayer.Models.Interfaces;

#endregion

namespace MostDev.DataLayer.Models
{
    public class ProductModel : IModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Guid Id { get; set; }
    }
}