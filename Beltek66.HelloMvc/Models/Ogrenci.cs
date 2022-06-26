using System.ComponentModel.DataAnnotations;

namespace Beltek66.HelloMvc.Models
{
    public class Ogrenci
    {
        public int Ogrenciid { get; set; }
        [Display(Name = "Adı")]//Attribute
        public string Ad { get; set; }

        [Display(Name = "Soyadı")]
        public string Soyad { get; set; }
        
        [Display(Name ="Yaşı")]
        public byte Yas { get; set; }

        public int Sinifid { get; set; }
        //Navigation Property
        public Sinif Sinifi { get; set; }
    }
}
