using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //öne çıkanlar alanı
    public class Highlight
    {
        [Key]
        public int HighlightID { get; set; }
        public string HighlightName { get; set; }
        public string HighlightDescription { get; set; }
        public string HighlightImage { get; set; }
        public bool HighlightStatus { get; set; }
    }
}
