using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //Referans kısmı
    public class Testimonial
    {
        [Key]
        public int TestimonialID { get; set; }
        public string Customer { get; set; }
        public string Comment { get; set; }
        public string CustomerImage { get; set; }
        public bool CustomerStatus { get; set; }
    }
}
