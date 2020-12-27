using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgProjeOdev.Models
{
    public class AnalogFotograf
    {
        [Key]
        public int AnalogFotografID { get; set; }
        public string FotografAd { get; set; }
        public string FotografKonum { get; set; }

        public int analogMakineID { get; set; }
        public AnalogMakine analogMakine { get; set; } //bire çok ilişki için AnalogMakine sınıfından AnalogMakine değeri türettim
    }
}
