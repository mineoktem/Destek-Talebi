using DestekTaleplerim.MvcWebUI.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DestekTaleplerim.MvcWebUI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        //protected override void Seed(IdentityDataContext context)
        //{
        //    // var roleStore = new RoleStore<IdentityRole>(context); //Pass the instance of your DbContext here
        //    // var roleManager = new RoleManager<IdentityRole>(roleStore);

        //    // roleManager.Create(new IdentityRole { Name = "admin" });
        //    // roleManager.Create(new IdentityRole { Name = "user" });

        //    // var user = new ApplicationUser() { Name = "Gece", Surname = "Öktem", UserName = "geceoktem", Email = "mineoktem0@gmail.com" };
        //    // var store = new UserStore<ApplicationUser>(context);
        //    // var manager = new UserManager<ApplicationUser>(store);
        //    // manager.AddToRole(user.Id, "admin");
        //    //manager.AddToRole(user.Id, "user");


        //    //Rolleri
        //    if (context.Roles.Any(i => i.Name == "admin"))
        //    {
        //        var store = new RoleStore<ApplicationRole>(context);
        //        var manager = new RoleManager<ApplicationRole>(store);

        //        var role = new ApplicationRole() { Name = "admin", Description = "admin rolü" };

        //        manager.Create(role);

        //    }

        //    if (context.Roles.Any(i => i.Name == "user"))
        //    {
        //        var store = new RoleStore<ApplicationRole>(context);
        //        var manager = new RoleManager<ApplicationRole>(store);

        //        var role = new ApplicationRole() { Name = "user", Description = "user rolü" };

        //        manager.Create(role);

        //    }








        //    //User

        //    if (!context.Roles.Any(i => i.Name == "mineoktem"))
        //    {
        //        var store = new UserStore<ApplicationUser>(context);
        //        var manager = new UserManager<ApplicationUser>(store);

        //        var user = new ApplicationUser() { Name = "Mine", Surname = "Öktem", UserName = "mineoktem", Email = "mineoktem0@gmail.com" };

        //        manager.Create(user, "1907Mine");
        //        manager.AddToRole(user.Id, "admin");
        //        manager.AddToRole(user.Id, "user");

        //    }

        //    if (!context.Roles.Any(i => i.Name == "isiloktem"))
        //    {
        //        var store = new UserStore<ApplicationUser>(context);
        //        var manager = new UserManager<ApplicationUser>(store);

        //        var user = new ApplicationUser() { Name = "Işıl", Surname = "Öktem", UserName = "isiloktem", Email = "isiloktem@gmail.com" };

        //        manager.Create(user, "123456");
        //        manager.AddToRole(user.Id, "user");

        //    }



        //    base.Seed(context);
        //}
    }

}