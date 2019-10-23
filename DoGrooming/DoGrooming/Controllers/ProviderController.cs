using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoGrooming.Models;
using DoGrooming.ViewModels;

namespace DoGrooming.Controllers
{
    public class ProviderController : Controller
    {
        // GET: Provider
        public ActionResult Display()
        {
            var provider = new Provider {Name = "Number1"};
            var services = new List<Service>
            {
                new Service {Name= "Hair Cut"},
                new Service {Name = "Body Clean"}
            };
            var content = new ProviderServiceViewModel
            {
                Provider = provider,
                Services = services
            };
            return View(content);
        }
        [Route("provider/{id}/{name}")]
        public ActionResult Test(int id, string name)
        {
            return Content(id + "/" + name);
        }
    }
}