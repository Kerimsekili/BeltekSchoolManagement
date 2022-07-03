using System.ComponentModel.DataAnnotations;

namespace Beltek66.HelloMvc.Models
{
    public class Ders
    {
        public int DersId { get; set; }
        [Display(Name = "Adı")]//Attribute
        public string DersAdi { get; set; }

        [Display(Name = "Dersi Veren Öğretmen")]
        public int OgretmenId { get; set; }

        [Display(Name = "Bolum")]
        public string Bolum { get; set; }


    }
}