using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VoNguyenKhoa_2080600032_BigSchool.Startup))]
namespace VoNguyenKhoa_2080600032_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
