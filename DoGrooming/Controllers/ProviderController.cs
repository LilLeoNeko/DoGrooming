using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoGrooming.Models;
using DoGrooming.Views.ViewModel;


namespace DoGrooming.Controllers
{
    public class ProviderController : Controller
    {
        // GET: Provider
        public ActionResult Display()
        {
            var provider = new Provider() { Name = "hello" };
            var services = new List<Service>
            {
                new Service {Name = "Clean"},
                new Service {Name = "haircut"},
                new Service {Name = "nail clipping"}
            };
            var viewModel = new ProviderServiceViewModel
            {
                Provider = provider,
                Services = services
            };
            return View(viewModel);
        }
        public ActionResult About(int id)
        {   
            return Content(""+id);
        }
    }
}