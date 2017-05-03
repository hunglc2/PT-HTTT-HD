using HTTTHD.WebAPI._02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;
using HTTTHD.WebAPI._02.Models;

namespace HTTTHD.WebAPI._02
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            /*config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );*/

            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<BRANCH>("branches");
            builder.EntitySet<ACCOUNT_TYPE>("account_types");
            builder.EntitySet<ACCOUNT>("accounts");
            builder.EntitySet<OWNER>("owners");
            builder.EntitySet<CUSTOMER>("customers");
            builder.EntitySet<POSITION_EMP>("position_emps");
            builder.EntitySet<EMPLOYEE>("employees");
            builder.EntitySet<TYPE_SAVINGS_ACCOUNT>("type_savings_accounts");
            builder.EntitySet<SAVINGS_ACCOUNT>("savings_account");
            builder.EntitySet<TRANSACTION_TYPES>("transaction_types");
            builder.EntitySet<TRANSACTION>("transactions");
            config.Routes.MapODataServiceRoute("api", "api", builder.GetEdmModel());
        }
    }
}
