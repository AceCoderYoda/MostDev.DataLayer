#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Entities.SubCategory.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MostDev.DataLayer.Entities.Interfaces;
using MostDev.DataLayer.Entities.Interfaces.Core;

#endregion

namespace MostDev.DataLayer.Entities
{
    public class SubCategory : IIdentifiable
    {
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string Name { get; set; }

        [Key]
        public Guid Id { get; set; }
    }
}