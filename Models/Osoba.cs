﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Osoba
    {
        public int OsobaId { get; set; }
        public string ImePrezime { get; set; }
        public string Telefon { get; set; }
        public string Ulica { get; set; }
        public string KucniBroj { get; set; }
        public string PostanskiBroj { get; set; }
        public string Mesto { get; set; }
        public string StaPorucujete { get; set; }
        public int Kolicina { get; set; }
        
    }
}
