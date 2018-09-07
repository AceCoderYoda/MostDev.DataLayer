#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.BaseService.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;
using MostDev.DataLayer.Converters.Core;
using MostDev.DataLayer.EF;
using MostDev.DataLayer.Models.Interfaces;

#endregion

namespace MostDev.DataLayer.Core
{
    public class BaseService<TEntity, TModel>
        where TModel : IModel
    {
        private MostDevContext context;

        public MostDevContext Context => context ?? (context = new MostDevContext());

        public virtual IConverter<TEntity, TModel> Converter { get; set; }

        public virtual void AddOrUpdate(Guid userId, TModel viewModel)
        {
        }

        public virtual bool Delete(TModel model)
        {
            return false;
        }

        public virtual IEnumerable<TModel> GetAllItems()
        {
            return default(IEnumerable<TModel>);
        }

        public virtual TModel GetItem(Guid id)
        {
            return default(TModel);
        }
    }
}