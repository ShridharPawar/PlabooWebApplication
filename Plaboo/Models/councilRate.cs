using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Plaboo.Models
{
    public class councilRate
    {
        //attributes of the councilrate data table
        [Key]
        public string council { get; set; }
        public string rate { get; set; }
        public string rank { get; set; }
    }
}