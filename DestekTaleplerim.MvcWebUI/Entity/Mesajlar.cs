using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DestekTaleplerim.MvcWebUI.Entity
{
    public class Mesajlar
    {
        public int Id { get; set; }

        
        public EnumTipi Tipi { get; set; } //müşteri,teknip ekip
        [DisplayName("Mesaj")]
        public string Icerik { get; set; }
        
        public int? DestekTalebiId { get; set; } 
        public DestekTalebi DestekTalebi { get; set; }

       
    }
}