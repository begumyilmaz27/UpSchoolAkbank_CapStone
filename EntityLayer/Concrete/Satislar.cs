using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Satislar
    {
        [Key]
        public int SaleID { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string PersonCount { get; set; }
        
        public DateTime SalesDate { get; set; }
        public string SaleDescription { get; set; }
        public string Status { get; set; }

        //product tablosu ile ilişki kurmak için yaptık. 
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
