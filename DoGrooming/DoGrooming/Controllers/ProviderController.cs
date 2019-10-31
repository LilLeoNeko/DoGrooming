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
        [Route("provider/index")]
        public ActionResult Index()
        {
            var providerList = new ProviderList
            {
                Providers = GetProviders()
            };
            return View(providerList);
        }
        [Route("provider/detail/{id}")]
        public ActionResult Detail(int id)
        {
            var curProvider = GetProviders().Find(x => x.Id == id);
            if (curProvider == null)
                return HttpNotFound();
            return View(curProvider);
        }
        public List<Provider> GetProviders()
        {
            var providers = new List<Provider>
            {
                new Provider { Id = 1, Name = "Charming", Address = "105/130 Country Street"},
                new Provider { Id = 2, Name = "Beauty Dog", Address = "666/233 Newtown Road"}
            };
            return providers;
        }
    }
}