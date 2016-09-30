using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleChess.Startup))]
namespace SimpleChess
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
