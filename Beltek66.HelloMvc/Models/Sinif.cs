using System.Collections.Generic;

namespace Beltek66.HelloMvc.Models
{
    public class Sinif
    {
        public int Sinifid { get; set; }
        public string Sinifad { get; set; }

        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
