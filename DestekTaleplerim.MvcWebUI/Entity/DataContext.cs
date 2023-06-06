using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DestekTaleplerim.MvcWebUI.Entity
{
    public class DataContext:DbContext
    {

        public DataContext() : base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }

        

        public DbSet<DestekTalebi> DestekTalepleri { get; set; }
        public DbSet<Mesajlar> Mesajlars { get; set; }
    }
}