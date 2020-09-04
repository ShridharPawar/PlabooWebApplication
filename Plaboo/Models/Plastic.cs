using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plaboo.Models
{
    public class Plastic
    {
        public int Plasticid { get; set; }
        public string Description { get; set; }

        public string Alternative { get; set; }

        public string Reason { get; set; }

        public string Image { get; set; }

        public int Harmindex { get; set; }

        public string Classification { get; set; }

        public string HarmMeasure { get; set; }
    }
}