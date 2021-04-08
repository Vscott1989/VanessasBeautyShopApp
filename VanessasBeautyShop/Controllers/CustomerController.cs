using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VanessasBeautyShop.Models.CustomerModels;
using VanessasBeautyShop.Services;

namespace VanessasBeautyShop.Controllers
{
    [Authorize]
    public class CustomerController : ApiController
    {
        private CustomerServices CreateCustomerService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new CustomerServices(userId);
            return service;
        }

        //Create the Customer...
        [HttpPost]
        public IHttpActionResult Post(CustomerCreate model)
        {
            if (model is null)
            {
                return BadRequest("???");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var service = CreateCustomerService();
            bool isSuccessful = service.CreateCustomer(model);
            if (isSuccessful)
            {
                return Ok($"Customer Created: {model.Name}");
            }
            //if all fails..
            return InternalServerError();
        }
    }
}
