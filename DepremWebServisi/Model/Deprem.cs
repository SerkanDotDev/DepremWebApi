using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DepremWebServisi.Model
{
    public class Deprem
    {
        [Key]
        public long eventID { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int depthkm { get; set; }
        public string magType { get; set; }
        public double magnitude { get; set; }
        public string eventLocationName { get; set; }

    }
}
