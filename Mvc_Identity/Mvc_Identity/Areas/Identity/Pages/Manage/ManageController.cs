using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mvc_Identity.Areas.Identity.Pages.Manage
{
    public class ManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
