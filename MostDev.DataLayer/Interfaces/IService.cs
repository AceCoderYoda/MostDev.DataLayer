#region ...   [Usings]   ...

using System;
using System.Collections.Generic;

#endregion

namespace MostDev.DataLayer.Interfaces
{
    public interface IService<TModel>
    {
        void AddOrUpdate(Guid userId, TModel viewModel);
        bool Delete(TModel model);
        TModel GetItem(Guid id);
        IEnumerable<TModel> GetAllItems();
    }
}