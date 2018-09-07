#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Converters.Extensions.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using MostDev.DataLayer.Entities;
using MostDev.DataLayer.Models;
using MostDev.DataLayer.Models.Interfaces;

#endregion

namespace MostDev.DataLayer.Converters
{
    public static class Extensions
    {
        public static void UpdateEntity(this User entity, IUserModel model)
        {
            var fn = "";
            var ij = "";
            var ln = "";

            var parts = model.FullName.Split(' ');
            fn = parts[0];
            ln = parts[parts.Length - 1];

            if (parts.Length > 2)
                for (var i = 1; i < parts.Length - 1; i++)
                    ij += parts[i] + " ";

            entity.Interjection = ij;
            entity.FirstName = fn;
            entity.LastName = ln;
            entity.Email = model.Email;
            entity.Active = model.Active;
            entity.Id = model.Id;
            entity.Password = model.Password;
            entity.UserName = model.UserName;
        }

        public static void UpdateEntity(this Product entity, ProductModel model)
        {
            entity.Id = model.Id;
            entity.Name = model.Name;
            entity.Price = model.Price;
        }
    }
}