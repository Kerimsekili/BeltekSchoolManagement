using System.ComponentModel.DataAnnotations;

namespace Beltek66.HelloMvc.Models
{
    public class Ogretmen
    {
        public int OgretmenId { get; set; }
        [Display(Name = "Adı")]//Attribute
        public string Ad { get; set; }

        [Display(Name = "Soyadı")]
        public string Soyad { get; set; }

        [Display(Name = "Bolum")]
        public string Bolum { get; set; }
        

    }
}
