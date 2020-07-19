using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_UI.Models;

namespace Sol_UI.Controllers
{
    public class DemoController : Controller
    {

        public DemoController()
        {
            CounterM = new CounterModel();
        }

        [BindProperty]
        public CounterModel CounterM { get; set; }

        public IActionResult Index()
        {
            CounterM.CurrentCount = 2;
            return View(CounterM);
        }
    }
}