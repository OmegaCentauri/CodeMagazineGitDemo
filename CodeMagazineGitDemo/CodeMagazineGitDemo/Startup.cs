using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeMagazineGitDemo.Startup))]
namespace CodeMagazineGitDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
        //Development branch changes.
    }
}
