using ChrisApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChrisApp.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Slime> Slimes { get; set; }
    }
}
