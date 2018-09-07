#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Entities.User.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.ComponentModel.DataAnnotations;
using MostDev.DataLayer.Entities.Core;
using MostDev.DataLayer.Entities.Interfaces;

#endregion

namespace MostDev.DataLayer.Entities
{
    public class User : Mutable, IUser
    {
        [Key]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string Interjection { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public bool LockedOut { get; set; }
        public long LastAccessed { get; set; }
    }
}