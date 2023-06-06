using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DestekTaleplerim.MvcWebUI.Entity
{
    public class DestekTalebi
    {
        
        public int Id { get; set; }


        //Data Annotations
        [DisplayName("Talep Numarası")]
        public int TalepNo { get; set; } 

        




        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public string Tarih { get; set; } = DateTime.Now.ToString(); //göndere tıklanıldığında otomatik gelecek
        [StringLength(maximumLength:50,ErrorMessage = "En fazla 50 karakter girebilirsiniz.")]
        public string Konu { get; set; } //başlık


        public EnumDurum Durum { get; set; } //yeni-cevaplandı-cevapladınız-kapalı
        public List<Mesajlar> Mesaj { get; set; } //mesaj içeriğinin tümü
        public int MesajlarId { get; set; }
        public Mesajlar Mesajlar { get; set; }
        [DisplayName("Kullanici Adi")]
        public string IslemYapan { get; set; } //username
        public EnumOncelik Oncelik { get; set; } //orta-yüksek-düşük
        

        
        


    }
}