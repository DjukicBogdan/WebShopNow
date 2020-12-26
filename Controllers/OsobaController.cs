using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;
using WebShop.Models;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Controllers
{
   
    public class OsobaController : Controller 
    {
      
        [HttpGet]
        public IActionResult Index()
        {          
            return View();
        }

        public IActionResult Ubaci()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ubaci(Porucbenica os)
        {
            WebShopServiceClient client = new WebShopServiceClient();
             Porucbenica os1 = new Porucbenica();
            Global.proizvod = os.StaPorucujete;
            Global.kolicina = os.Kolicina;
            os1.ImePrezime = os.ImePrezime;
            os1.Telefon = os.Telefon;
            os1.Ulica = os.Ulica;
            os1.KucniBroj = os.KucniBroj;
            os1.PostanskiBroj = os.PostanskiBroj;
            os1.Mesto = os.Mesto;
            os1.StaPorucujete = os.StaPorucujete;
            os1.Kolicina = os.Kolicina;
            client.OpenAsync();
            
            client.PreuzmiOsobeAsync(os1);
                
            client.CloseAsync();
            
            return RedirectToAction("Index");

        }
    }
}