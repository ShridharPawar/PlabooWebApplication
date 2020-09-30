using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Plaboo.Models
{
    public class RecyclingCentre
    {
        [Key]
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string Address { get; set; }

        public string DetailedAddress { get; set; }

        public string Contact { get; set; }
    }
}