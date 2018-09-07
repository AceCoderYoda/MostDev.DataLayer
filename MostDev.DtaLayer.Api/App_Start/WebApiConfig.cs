#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Api.WebApiConfig.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Web.Http;

#endregion

namespace MostDev.DtaLayer.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            // Web API routes
            config.MapHttpAttributeRoutes();
        }
    }
}