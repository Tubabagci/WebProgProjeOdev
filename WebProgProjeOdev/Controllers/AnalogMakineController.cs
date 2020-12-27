using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebProgProjeOdev.Models;

namespace WebProgProjeOdev.Controllers
{
    public class AnalogMakineController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var siralama = c.AnalogMakines.ToList(); //sql deki verileri çekip listeleme kodu
            return View(siralama);
        }
        [HttpGet]
        public IActionResult YeniMakine()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniMakine(AnalogMakine m )
        {
            c.AnalogMakines.Add(m);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult MakineSil(int id)
        {
            var makine = c.AnalogMakines.Find(id);
            c.AnalogMakines.Remove(makine);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult MakineGetir(int id)
        {
            var makine = c.AnalogMakines.Find(id);
            return View("MakineGetir", makine);
        }

        public IActionResult MakineGuncelle(AnalogMakine m)
        {
            var makine = c.AnalogMakines.Find(m.AnalogMakineID);
            makine.MakineAd = m.MakineAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}