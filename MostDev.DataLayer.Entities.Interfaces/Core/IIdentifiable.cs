#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Entities.IIdentifiable.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace MostDev.DataLayer.Entities.Interfaces.Core
{
    public interface IIdentifiable
    {
        Guid Id { get; set; }
    }
}