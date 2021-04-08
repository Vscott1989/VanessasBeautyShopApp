using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanessasBeautyShop.Data
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        public string TimeOfArrival { get; set; }

        public string BeautitionName { get; set; }

        //Since there are many Appointments for one customer this appointment object needs a Forgin Key that points to a specific customer
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
