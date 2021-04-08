using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanessasBeautyShop.Data
{
    public class BeautyShop
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ShopName { get; set; }
        
        public string ShopPhoneNumber { get; set; }
        
        public string Address { get; set; }

        public virtual List<Customer> Customers { get; set; }

    }
}
