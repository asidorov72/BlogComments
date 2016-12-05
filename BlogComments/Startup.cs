using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogComments.Startup))]
namespace BlogComments
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
