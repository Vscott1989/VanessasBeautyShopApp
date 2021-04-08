using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanessasBeautyShop.Data;

namespace VanessasBeautyShop.Models.CustomerModels
{
   public class CustomerEdit
    {

        public int Id { get; set; }
        
        public string Name { get; set; }

       
        public Guid OwnerId { get; set; }
        public string PhoneNumber { get; set; }


        public virtual List<Appointment> Appointments { get; set; } = new List<Appointment>();

        public int? BeautyShopId { get; set; }
        public BeautyShop BeautyShop { get; set; }
    }
}
