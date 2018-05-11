using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CollegeLolaGonzalezControl.Startup))]

namespace CollegeLolaGonzalezControl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuthentication(app);
        }
    }
}