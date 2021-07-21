using GradeList.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GradeList.Application.Interfaces;
using GradeList.Application.UseCases;

namespace GradeList.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IGradeBL _gradeBl;
        public HomeController(ILogger<HomeController> logger, IGradeBL gradeBl)
        {
            _logger = logger;
            _gradeBl = gradeBl;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> GradeList()
        {

            return View(await _gradeBl.RetreiveGradeSubjectDtos(""));
        }
    }
}
