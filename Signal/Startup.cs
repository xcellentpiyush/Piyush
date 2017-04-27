using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Signal.Startup))]
namespace Signal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
