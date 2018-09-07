#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Converters.UserConverter.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;
using System.Linq;
using MostDev.DataLayer.Converters.Core;
using MostDev.DataLayer.Entities;
using MostDev.DataLayer.Entities.Interfaces;
using MostDev.DataLayer.Models;
using MostDev.DataLayer.Models.Interfaces;

#endregion

namespace MostDev.DataLayer.Converters
{
    public class UserConverter : IConverter<IUser, IUserModel>
    {
        public IUserModel ToModel(IUser product)
        {
            return new UserModel
            {
                Active = product.Active,
                Email = product.Email,
                FullName = string.IsNullOrEmpty(product.Interjection)
                    ? $"{product.FirstName} {product.LastName}"
                    : $"{product.FirstName} {product.Interjection} {product.LastName}",
                Id = product.Id.ToString("N"),
                LockedOut = product.LockedOut,
                Password = product.Password,
                UserName = product.UserName
            };
        }

        public IUser ToEntity(IUserModel product)
        {
            var fn = "";
            var ij = "";
            var ln = "";

            var parts = product.FullName.Split(' ');
            fn = parts[0];
            ln = parts[parts.Length - 1];

            if (parts.Length > 2)
                for (var i = 1; i < parts.Length - 1; i++)
                    ij += parts[i] + " ";

            return new User
            {
                Interjection = ij,
                FirstName = fn,
                LastName = ln,
                Email = product.Email,
                Active = product.Active,
                Id = Guid.Parse(product.Id),
                Password = product.Password,
                UserName = product.UserName
            };
        }

        public IEnumerable<IUserModel> ToModels(IEnumerable<IUser> products)
        {
            return products.Select(ToModel).ToList();
        }

        public IEnumerable<IUser> ToEntities(IEnumerable<IUserModel> products)
        {
            return products.Select(ToEntity).ToList();
        }
    }
}