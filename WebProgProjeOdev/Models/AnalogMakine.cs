using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgProjeOdev.Models
{
    public class AnalogMakine
    {
        [Key]
        public int AnalogMakineID { get; set; }
        public string MakineAd { get; set; }

        public IList<AnalogFotograf> AnalogFotografs { get; set; } //bir interface listesi formatında ilişkiye alacağımız alan

        public string detay { get; set; }

    }
}

