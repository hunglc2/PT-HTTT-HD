using System.Web;
using System.Web.Mvc;

namespace PTHTTTHD_SYSTEM_ANALYTIC_REPORT
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
