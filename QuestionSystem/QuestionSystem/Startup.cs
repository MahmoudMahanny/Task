using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuestionSystem.Startup))]
namespace QuestionSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
