using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChipWebClient.Startup))]
namespace ChipWebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
