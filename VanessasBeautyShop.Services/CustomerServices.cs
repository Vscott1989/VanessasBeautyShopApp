using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanessasBeautyShop.Data;
using VanessasBeautyShop.Models.CustomerModels;

namespace VanessasBeautyShop.Services
{
   public class CustomerServices
    {
        private readonly Guid _userId;

        public CustomerServices(Guid userId)
        {
            _userId = userId;

        }

        //Need to Create Customer Method
        public bool CreateCustomer(CustomerCreate customerCreate)
        {
            //Map customer create to customer
            var customer = new Customer
            {
                OwnerId = _userId,
                Name=customerCreate.Name,
                PhoneNumber=customerCreate.PhoneNumber,
                BeautyShopId=(customerCreate.BeautyShopId!=null)? customerCreate.BeautyShopId:null


            };

            //Accessing Database to save customer
            using(var ctx = new ApplicationDbContext())
            {
                //add customer to custome table 
                ctx.Customers.Add(customer);

                //saving to database
                return ctx.SaveChanges()>0;
            }
        }
    }
}
