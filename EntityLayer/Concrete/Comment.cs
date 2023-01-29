using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; } 
        public string CommentUsername { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentTitle { get; set; }        
        public string CommentDescription { get; set; }
        public bool CommentState { get; set; }
        public int ProductID { get; set; } //yapılan yorum hangi ürün için yapıldı. Bu yüzden PRoductID getirmek zorundayız. 
        public Product Product { get; set; }

    }
}
