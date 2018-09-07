#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Models.UserModel.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.ComponentModel;
using MostDev.DataLayer.Models.Interfaces;

#endregion

namespace MostDev.DataLayer.Models
{
    public class UserModel : IUserModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public bool LockedOut { get; set; }
    }
}