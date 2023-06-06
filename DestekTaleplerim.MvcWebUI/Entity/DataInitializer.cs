using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DestekTaleplerim.MvcWebUI.Entity
{
    public class DataInitializer: DropCreateDatabaseIfModelChanges<DataContext>
    {
        //protected override void Seed(DataContext context)
        //////{
        //////    var mesajlars = new List<Mesajlar>() {

        //////        new Mesajlar(){Tipi= EnumTipi.Müşteri , Icerik="Merhaba, siteye giriş yapamıyorum." },
        //////         new Mesajlar(){Tipi= EnumTipi.TeknikEkip , Icerik="Merhaba, hemen kontrol ediyorum." },
        //////         new Mesajlar(){Tipi= EnumTipi.TeknikEkip , Icerik="Sorununuz çözüldü." },
        //////         new Mesajlar(){Tipi= EnumTipi.Müşteri , Icerik="Teşekkürler"}


        //////    };

        //////    foreach (var kisi in mesajlars)
        //////    {
        //////        context.Mesajlars.Add(kisi);
        //////    }
        //////    context.SaveChanges();

        //////    List<DestekTalebi> talepler = new List<DestekTalebi>()
        //////    {
        //////        new DestekTalebi(){TalepNo=1, Tarih=DateTime.Now.ToString(), Konu ="Siteye Giremiyorum" ,  IslemYapan="admin" , Oncelik= EnumOncelik.Orta},
        //////        new DestekTalebi(){TalepNo=2, Tarih=DateTime.Now.ToString(), Konu="Bilgisayarım Çalışmıyor" ,IslemYapan="admin", Oncelik= EnumOncelik.Düşük},
        //////        new DestekTalebi(){TalepNo=3, Tarih=DateTime.Now.ToString(), Konu="Sistem Çöktü" ,  IslemYapan="admin", Oncelik= EnumOncelik.Yüksek}
                

        //////    };

        //////    foreach (var talep in talepler)
        //////    {
        //////        context.DestekTalepleri.Add(talep);
        //////    }
        //////    context.SaveChanges();


        ////    base.Seed(context);
        //}
    }
}