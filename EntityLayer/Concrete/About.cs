using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string AboutName { get; set; }
        public string AboutDescription { get; set; }
        public string AboutImage { get; set; }
        public string AboutTitle2 { get; set; }
        public string AboutDescription2 { get; set; }
        public string InstagramUrl { get; set; }
        public bool AboutStatus { get; set; }
        public string WebSites { get; set; }

    }
}
