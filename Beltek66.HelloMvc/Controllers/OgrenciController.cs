
using Beltek66.HelloMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Beltek66.HelloMvc.Controllers
{
    public class OgrenciController : Controller
    {
        public ViewResult Index()//Action
        {
            //string isim = "Ahmet";
            //ViewData["name"] = isim;
            //ViewData["surname"] = "Mehmet";
            //ViewData["age"] = 25;

            //ViewData["name1"] = "Ali";
            //ViewData["surname1"] = "Veli";
            //ViewData["age1"] = 30;

            //ViewBag.name = "Ali";
            //ViewBag.surname = "Veli";
            //ViewBag.age = 25;

            //string isim = "Ahmet";
            //var name = "Ali";
            //dynamic _name = "Osman";

            var ogr = new Ogrenci();
            ogr.Ad = "Ahmet";
            ogr.Soyad = "Mehmet";
            ogr.Yas = 25;

            ViewData["ogrenci"] = ogr;
            ViewBag.student = ogr;

            dynamic st = new Ogrenci();



            return View();
        }
        //ViewData: Controller'dan View'lere veri taşımak için kullanılır.
        //Key-Value Pair
        //Dictionary Yapısı
        //Collection-> Dizilerin eleman sayısı belirlenmeden kullanılabilen hali.
        //ViewBag arka planda ViewData koleksiyonunu kullanır.
        //ViewBag dynamic bir yapıdır. Dynamic yapıların tipine, runtime sırasında karar verilir.

        public ViewResult OgrenciListe()
        {
            var ogrenciler = new List<Ogrenci>();         
        
            ogrenciler.Add(new Ogrenci { Ad = "Ali", Soyad = "Veli", Yas = 20 });
            ogrenciler.Add(new Ogrenci { Ad = "Ahmet", Soyad = "Mehmet", Yas = 25 });
            ogrenciler.Add(new Ogrenci { Ad = "Hakan", Soyad = "Yılmaz", Yas = 22 });


            var ogretmenler = new List<Ogretmen>();
            ogretmenler.Add(new Ogretmen { Ad = "Ali", Soyad = "Veli", Bolum = "Bilgisayar" });
            ogretmenler.Add(new Ogretmen { Ad = "Ahmet", Soyad = "Mehmet", Bolum = "Endüstri" });

            var lst = new ListViewModel();
            lst.Ogretmenler = ogretmenler;
            lst.Ogrenciler = ogrenciler;

            // ViewData["lst"]= ogrenciler;


            // ViewBag.lst = ogretmenler;
            return View(lst);
        }

        public string OgrenciDetay(int id)
        {
            string ogr;

            if (id == 1)
                ogr = "Ali";
            else if (id == 2)
                ogr = "Veli";
            else
                ogr = "Bu id ile kayıtlı öğrenci yok";

            return ogr;
        }

        [HttpGet]
        public ViewResult OgrenciEkle()
        {
            return View();  
        }

        [HttpPost]
        public ViewResult OgrenciEkle(Ogrenci ogr)
        {

            return View();
        }

    }
}
//IIS: Internet Information Services