using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComplaintBox.Startup))]
namespace ComplaintBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
