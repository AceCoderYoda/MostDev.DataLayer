#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Models.IModel.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using Newtonsoft.Json;

#endregion

namespace MostDev.DataLayer.Models.Interfaces
{
    public interface IModel
    {
        [JsonProperty]
        string Id { get; set; }
    }
}