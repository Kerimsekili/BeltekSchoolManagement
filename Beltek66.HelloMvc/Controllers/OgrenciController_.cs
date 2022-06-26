
using Beltek66.HelloMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Beltek66.HelloMvc.Controllers
{
    public class OgrenciController_ : Controller
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
            List<Ogrenci> lst = null;
            using (var ctx = new OkulDbContext())
            {
                lst = ctx.Ogrenciler.ToList();
            }
            return View(lst);
        }       


        public ViewResult OgrenciEkle()
        {
            return View();
        }

        [HttpPost]
        public ViewResult OgrenciEkle(Ogrenci ogr)
        {
            using (var ctx = new OkulDbContext())
            {
                ctx.Ogrenciler.Add(ogr);
                ctx.SaveChanges();
            }
            return View();
        }

        public IActionResult OgrenciSil(int id)
        {
            using (var ctx = new OkulDbContext())
            {
                var ogr = ctx.Ogrenciler.Find(id);
                ctx.Ogrenciler.Remove(ogr);
                ctx.SaveChanges();
            }
            return RedirectToAction("OgrenciListe");
        }

        public IActionResult OgrenciDetay(int id)
        {
            using (var ctx = new OkulDbContext())
            {
                var ogr = ctx.Ogrenciler.Find(id);
                return View(ogr);
            }
        }

        [HttpPost]
        public IActionResult OgrenciDetay(Ogrenci ogr)
        {            
            using (var ctx = new OkulDbContext())
            {
                ctx.Entry(ogr).State = EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("OgrenciListe");
            }
        }
    }
}
//IIS: Internet Information Services