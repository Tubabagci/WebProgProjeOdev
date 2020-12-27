using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebProgProjeOdev.Models;

namespace WebProgProjeOdev.Controllers
{
    public class AnalogFotografController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var fotobilgi = c.AnalogFotografs.Include(a=>a.analogMakine).ToList();
            return View(fotobilgi);
        }
        [HttpGet]
        public IActionResult YeniAnalogFotograf()
        {
            List<SelectListItem> aaa=(from a in c.AnalogMakines.ToList()
                                          select new SelectListItem
                                          {
                                              
                                              Value=a.MakineAd.ToString()
                                          }).ToList();
            ViewBag.a = aaa;
            return View();
        }
        //[HttpPost]
        //public IActionResult YeniAnalogFotograf(AnalogFotograf foto)
        //{
        //    var s = c.AnalogMakines.Add(foto);
        //    c.SaveChanges();
        //    return RedirectToAction("Index",s);
        //}
        
    }
}