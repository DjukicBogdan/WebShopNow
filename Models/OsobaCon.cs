using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebShopClient.Models
{

    [DataContract]
    public class OsobaCon
    {
        [DataMember]
        public int OsobaId { get; set; }

        [DataMember(IsRequired = false)]
        public string ImePrezime { get; set; }

        [DataMember(IsRequired = false)]
        public string Telefon { get; set; }
        [DataMember(IsRequired = false)]
        public string Ulica { get; set; }
        [DataMember(IsRequired = false)]
        public string KucniBroj { get; set; }
        [DataMember(IsRequired = false)]
        public string PostanskiBroj { get; set; }
        [DataMember(IsRequired = false)]
        public string Mesto { get; set; }
        [DataMember(IsRequired = false)]
        public string StaPorucujete { get; set; }
        [DataMember(IsRequired = false)]
        public int Kolicina { get; set; }
    }
    
}
