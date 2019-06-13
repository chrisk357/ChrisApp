using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChrisApp.Models;
using ChrisApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChrisApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISlimeRepository _slimeRepository;
        public HomeController(ISlimeRepository slimeRepository)
        {
            _slimeRepository = slimeRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {

            var slimes = _slimeRepository.GetAllSlimes().OrderBy(s => s.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Slime Store",
                Slimes = slimes.ToList()
        };


            return View(homeViewModel);
        }
    }
}
