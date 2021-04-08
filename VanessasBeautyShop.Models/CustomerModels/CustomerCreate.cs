using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanessasBeautyShop.Data;

namespace VanessasBeautyShop.Models.CustomerModels
{
    public class CustomerCreate
    {

        [Required]
        public string Name { get; set; }


        public string PhoneNumber { get; set; }



        public int? BeautyShopId { get; set; }
        public BeautyShop BeautyShop { get; set; }
    }
}
