using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Couronne.Core.Models.DTO;
using Couronne.Core.Services;
using CouronneWeb.ViewModels;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;

namespace CouronneWeb.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var model = new HomeViewModel();
            var service = new CouronneService();

            model.TopPlayersYear = await service.GetTopPlayersYear();
            model.TopPlayersMonth = await service.GetTopPlayersMonth(DateTime.Now.Month.ToString());
            return View(model);
        }



    }
}
