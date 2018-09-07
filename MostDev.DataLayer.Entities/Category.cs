#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Entities.Category.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MostDev.DataLayer.Entities.Interfaces;
using MostDev.DataLayer.Entities.Interfaces.Core;

#endregion

namespace MostDev.DataLayer.Entities
{
    public class Category : IIdentifiable
    {
        public string Name { get; set; }
        [Key]
        public Guid Id { get; set; }
    }
}