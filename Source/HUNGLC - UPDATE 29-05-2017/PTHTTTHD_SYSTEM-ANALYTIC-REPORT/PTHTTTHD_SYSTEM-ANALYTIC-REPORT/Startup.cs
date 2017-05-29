using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PTHTTTHD_SYSTEM_ANALYTIC_REPORT.Startup))]
namespace PTHTTTHD_SYSTEM_ANALYTIC_REPORT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
