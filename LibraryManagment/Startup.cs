using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibraryManagment.Startup))]
namespace LibraryManagment
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
