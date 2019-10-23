using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoGrooming.Models;

namespace DoGrooming.ViewModels
{
    public class ProviderServiceViewModel
    {
        public Provider Provider { get; set; }
        public List<Service> Services { get; set; }
    }
}