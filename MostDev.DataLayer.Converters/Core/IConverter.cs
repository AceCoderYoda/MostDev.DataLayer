#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Converters.Converter.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Collections.Generic;

#endregion

namespace MostDev.DataLayer.Converters.Core
{
    public interface IConverter<TEntity, TModel>
    {
        TModel ToModel(TEntity product);

        TEntity ToEntity(TModel product);

        IEnumerable<TModel> ToModels(IEnumerable<TEntity> products);

        IEnumerable<TEntity> ToEntities(IEnumerable<TModel> products);
    }
}