#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Entities.Mutable.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using MostDev.DataLayer.Entities.Interfaces;
using MostDev.DataLayer.Entities.Interfaces.Core;

#endregion

namespace MostDev.DataLayer.Entities.Core
{
    public abstract class Mutable : IMutable
    {
        public Guid LastUser { get; set; }
        public Guid CreateUser { get; set; }
        public long LastDate { get; set; }
        public long CreatedDate { get; set; }
    }
}