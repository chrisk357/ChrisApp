using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChrisApp.Models
{
    public class MockSlimeRepository : ISlimeRepository
    {
        private List<Slime> _slimes;
        public MockSlimeRepository()
        {
            if(_slimes == null)
            {
                InitializeSlimes();
            }
        }

        private void InitializeSlimes()
        {
            _slimes = new List<Slime>
            {
                new Slime {Id = 1, Name= "Butter Slime", Price = 4.99M, ShortDescription = "The Classic Butter Slime", LongDescription = "A smooth butter-like texture with a light creamy yellow color to it. Similar to most classic Butter-Slimes with our little twist. Custom colors available at request." }, 
                new Slime {Id = 2, Name= "Unicorn Snot", Price = 12.99M, ShortDescription = "Sparkly Exotic Rare Slime", LongDescription = "Whats more rare than a Unicorn? How about our famouse in house creation Unicorn Snot. This is a slime you will not find anywhere else and while the colors created very. All of them will leave you smiling" },
                new Slime {Id = 3, Name= "Radioactive Waste", Price = 9.99M, ShortDescription = "Bright Green Glowing Slime", LongDescription = "O NO! A truck carrying radioactive waste crashed on the freeway and all the chemicals spilled out onto the street! Thats ok, we grabbed as much as could and decided me Slimify It! But be prepared for a bright glowing green goop" },
                new Slime {Id = 3, Name= "Magnetic Slime", Price = 6.99M, ShortDescription = "Slime With A Sticky Secret", LongDescription = "While Nasa was training future Astronauts for their next space mission we were tasked out with creating their slime. With all of Nasa's resources at our disposal we created a slime that can attach itself to metal surfaces so it would not be lost in outer space!" }
            };
        }
        public IEnumerable<Slime> GetAllSlimes()
        {
            return _slimes;
        }
        public Slime GetSlimeById(int slimeId)
        {
            return _slimes.FirstOrDefault(s => s.Id == slimeId);
        }

    }
}
