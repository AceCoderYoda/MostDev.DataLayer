#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Entities.Product.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.ComponentModel.DataAnnotations;
using MostDev.DataLayer.Entities.Interfaces;
using MostDev.DataLayer.Entities.Interfaces.Core;

#endregion

namespace MostDev.DataLayer.Entities
{
    public class Product : IMutable, IIdentifiable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        [Key] public Guid Id { get; set; }
    }
}