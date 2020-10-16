using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Plaboo.Models
{
    public class allCouncilPostcode
    {
        //attributes of the allcouncilpostcode data table
        [Key]
        public string postcode { get; set; }
        public string council { get; set; }
    }
}