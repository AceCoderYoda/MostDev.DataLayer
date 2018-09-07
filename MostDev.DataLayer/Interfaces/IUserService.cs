#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.IUserService.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Collections.Generic;
using MostDev.DataLayer.Models;
using MostDev.DataLayer.Models.Interfaces;

#endregion

namespace MostDev.DataLayer.Interfaces
{
    public interface IUserService : IService<IUserModel>
    {
        IEnumerable<IUserModel> GetLockedOutUsers();
    }
}