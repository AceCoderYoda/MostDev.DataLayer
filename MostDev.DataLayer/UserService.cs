#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.UserService.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using MostDev.DataLayer.Converters;
using MostDev.DataLayer.Core;
using MostDev.DataLayer.EF;
using MostDev.DataLayer.Entities;
using MostDev.DataLayer.Entities.Interfaces;
using MostDev.DataLayer.Interfaces;
using MostDev.DataLayer.Models;
using MostDev.DataLayer.Models.Interfaces;

#endregion

namespace MostDev.DataLayer
{
    public class UserService : BaseService<IUser, IUserModel>, IUserService, IDisposable
    {
        public UserService()
        {
            base.Converter = new UserConverter();
        }

        public override void AddOrUpdate(Guid userId, IUserModel model)
        {
            var user = Context.Users.FirstOrDefault(u => u.Id == Guid.Parse(model.Id));
            if (user == default(IUser))
            {
                user = (User)Converter.ToEntity(model) ;
                user.CreateUser = userId;
                user.CreatedDate = DateTimeOffset.Now.Ticks;
            }
            else
            {
                user.UpdateEntity(model);
                user.LastUser = userId;
                user.LastAccessed = DateTimeOffset.Now.Ticks;
            }

            Context.SaveChanges();

        }

        public override IUserModel GetItem(Guid id)
        {
            return Converter.ToModel(Context.Users.FirstOrDefault(u => u.Id == id));
        }

        public override IEnumerable<IUserModel> GetAllItems()
        {
            return Converter.ToModels(Context.Users.Where(u => u.Active).ToList());
        }

        public IEnumerable<IUserModel> GetLockedOutUsers()
        {
            yield break;
        }

        public override bool Delete(IUserModel model)
        {
            var e = base.Context.Set<User>().FirstOrDefault(u => u.Id.ToString("N") == model.Id);
            Context.Set<User>().Remove(e);
            return true;

        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}