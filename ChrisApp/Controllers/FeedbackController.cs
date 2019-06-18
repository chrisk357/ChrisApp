using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChrisApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChrisApp.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository _feedbackRepository;
        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}