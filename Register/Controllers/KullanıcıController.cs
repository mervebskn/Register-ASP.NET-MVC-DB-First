using Register.Entity;
using Register.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Register.Controllers
{
    public class KullanıcıController : Controller
    {
        // GET: Kullanıcı
        [HttpGet]
        public ActionResult Kaydol()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kaydol(RegisterViewModel model)
        {
            Kullanıcılar newkullanici = new Kullanıcılar { Ad = model.Ad, Soyad = model.Soyad, Id = model.Id, KullanıcıAdı = model.KullaniciAdi, Mail = model.Mail, Telefon = model.Telefon, IsActive = true, IsDelete = true, IsOnline = true, KayitTarihi = DateTime.Now, Sifre = model.Sifre };
            int basaridurumu = 0;
            using (KullaniciEntities1 context=new KullaniciEntities1())
            {
                context.Kullanıcılar.Add(newkullanici);
                basaridurumu = context.SaveChanges();
            }
            if (basaridurumu > 0)
            {
                TempData["Message"] = "Kayıt Başarılı.Bilgiler veritabanına eklendi.";
            }
            else
            {
                TempData["Message"] = "Kayıt başarısız.";

            }

            return View();
        }
    }
}