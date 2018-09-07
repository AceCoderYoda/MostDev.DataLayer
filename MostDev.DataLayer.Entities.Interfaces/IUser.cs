#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Entities.Interfaces.IUser.cs
// By            ::    Arjan Crielaard

#endregion

using System;
using MostDev.DataLayer.Entities.Interfaces.Core;

namespace MostDev.DataLayer.Entities.Interfaces
{
    public interface IUser: IIdentifiable
    {
        string UserName { get; set; }
        string FirstName { get; set; }
        string Interjection { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        bool Active { get; set; }
        bool LockedOut { get; set; }
        long LastAccessed { get; set; }
    }
}