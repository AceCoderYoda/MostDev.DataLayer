#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Models.IUserModel.cs
// By            ::    Arjan Crielaard

#endregion

using Newtonsoft.Json;

namespace MostDev.DataLayer.Models.Interfaces
{
    public interface IUserModel: IModel
    {
        [JsonProperty]
        string UserName { get; set; }
        [JsonProperty]
        string FullName { get; set; }
        [JsonProperty]
        string Email { get; set; }
        [JsonProperty]
        string Password { get; set; }
        [JsonProperty]
        bool Active { get; set; }
        [JsonProperty]
        bool LockedOut { get; set; }
    }
}