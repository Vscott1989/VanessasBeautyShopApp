using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanessasBeautyShop.Data
{
   public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public Guid OwnerId { get; set; }
        public string PhoneNumber { get; set; }

        public virtual List<Appointment> Appointments { get; set; } = new List<Appointment>();


    }
}
