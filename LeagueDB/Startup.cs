using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeagueDB.Startup))]
namespace LeagueDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
