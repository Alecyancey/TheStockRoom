using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheStockRoom.WebMVC.Startup))]
namespace TheStockRoom.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
