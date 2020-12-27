using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using WebProgProjeOdev.Models;

namespace WebProgProjeOdev.Controllers
{
    public class GirisController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    

        public async Task<IActionResult> GirisYap(Admin ad)
        {
            var veriler = c.Admins.FirstOrDefault(a => a.Kullanici==ad.Kullanici && a.Sifre==ad.Sifre);
            if (veriler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier,ad.Kullanici)
                };
                var useridentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "AnalogFotograf");
            }
            return View();
        }
    }
}