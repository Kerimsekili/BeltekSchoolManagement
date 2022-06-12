using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Beltek66.EfApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var ogr = new Ogrenci { Ad = "Ali", Soyad = "Veli", Numara = 123 };
            //using (var ctx=new OkulDbContext())
            //{
            //    ctx.Ogrenciler.Add(ogr);
            //    ctx.SaveChanges();
            //}

            //using (var ctx = new OkulDbContext())
            //{
            //    var ogrenci = ctx.Ogrenciler.Find(1);
            //    ogrenci.Numara = 789;
            //    ctx.Entry(ogrenci).State = EntityState.Modified;

            //    if (ctx.SaveChanges() > 0)
            //    {
            //        Console.WriteLine("İşlem Başarılı");
            //    }
            //}

            //using (var ctx = new OkulDbContext())
            //{
            //    var ogr = ctx.Ogrenciler.Find(1);
            //    ctx.Ogrenciler.Remove(ogr);
            //    ctx.SaveChanges();
            //}

            using (var ctx = new OkulDbContext())
            {
                var lst = ctx.Ogrenciler.ToList();
                foreach (var item in lst)
                {
                    Console.WriteLine($"Ad:{item.Ad} Soyad:{item.Soyad} Numara:{item.Numara}");
                }
            }
        }
    }

    class Ogrenci
    {
        public int Ogrenciid { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Numara { get; set; }

    }

    class OkulDbContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=OkulDbBeltek;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ogrenci>().ToTable("tblOgrenciler");
            modelBuilder.Entity<Ogrenci>().Property(o => o.Ad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o => o.Soyad).HasColumnType("varchar").HasMaxLength(40).IsRequired();
        }
    }
}
//Code First Tekniği
//DbContext: EF'de veritabanı işlemlerini yapan class
//ConnectionString: Veritabanının bulunduğu sunucu adresi, veritabanı adı, kullanıcıadı şifre bilgilerinin bulunduğu bir string.
//Fluent Api: EF Code First yöntemi, EF'nin oluşturduğu alanların ve tabloların özelliklerini belirlemekte kullanılır.