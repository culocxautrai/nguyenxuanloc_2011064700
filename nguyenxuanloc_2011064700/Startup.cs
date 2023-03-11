using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nguyenxuanloc_2011064700.Startup))]
namespace nguyenxuanloc_2011064700
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
