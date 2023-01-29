using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }        
        public string Image { get; set; }        
        public bool Status{ get; set; }
        public int Capacity { get; set; }
        public List<Comment> Comments { get; set; } //yorumların listeleneceği kısım olduğu için List yapısını kullandık. Product kısmında yorumlar listelenecek. 
        

    }
}
