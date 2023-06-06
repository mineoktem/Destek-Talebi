using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(DestekTaleplerim.MvcWebUI.App_Start.Startup1))]

namespace DestekTaleplerim.MvcWebUI.App_Start
{
    

    public class Startup1 
    {
        
        public void ConfigureServices(IServiceCollection services)
        {


        }


        public void Configuration(IAppBuilder app)
        {
            // Uygulamanızı nasıl yapılandıracağınız hakkında daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=316888 adresini ziyaret edin

            app.UseCookieAuthentication(new CookieAuthenticationOptions()
                {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/Account/Login")
                
               



        }) ;
            

        }
        
    }
}
