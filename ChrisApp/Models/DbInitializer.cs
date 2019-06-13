using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChrisApp.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if(!context.Slimes.Any())
            {
                context.AddRange
                    (
                    new Slime { Id = 1, Name = "Butter Slime", Price = 4.99M, ShortDescription = "The Classic Butter Slime", LongDescription = "A smooth butter-like texture with a light creamy yellow color to it. Similar to most classic Butter-Slimes with our little twist. Custom colors available at request." },
                    new Slime { Id = 2, Name = "Unicorn Snot", Price = 12.99M, ShortDescription = "Sparkly Exotic Rare Slime", LongDescription = "Whats more rare than a Unicorn? How about our famouse in house creation Unicorn Snot. This is a slime you will not find anywhere else and while the colors created very. All of them will leave you smiling" },
                    new Slime { Id = 3, Name = "Radioactive Waste", Price = 9.99M, ShortDescription = "Bright Green Glowing Slime", LongDescription = "O NO! A truck carrying radioactive waste crashed on the freeway and all the chemicals spilled out onto the street! Thats ok, we grabbed as much as could and decided me Slimify It! But be prepared for a bright glowing green goop" },
                    new Slime { Id = 4, Name = "Magnetic Slime", Price = 6.99M, ShortDescription = "Slime With A Sticky Secret", LongDescription = "While Nasa was training future Astronauts for their next space mission we were tasked out with creating their slime. With all of Nasa's resources at our disposal we created a slime that can attach itself to metal surfaces so it would not be lost in outer space!" },
                    new Slime { Id = 5, Name = "Crazy Slime", Price = 7.99M, ShortDescription = "Our Crazy Classic Slime", LongDescription = "Everyone loves our classic crazy slime, it will have you grinning from ear to ear for hours. Colors very and for an adiotional $1 you can request a custo color or colors." },
                    new Slime { Id = 6, Name = "Alien Poop", Price = 8.99M, ShortDescription = "Out Of The World Slime", LongDescription = "While we weere in outer space we ran into some extra-terrastrial beings. Not only are they friendly creatures but they poop out really neat slimme. Check out this slime and how some support to the aliens that created it." },
                    new Slime { Id = 7, Name = "Engine Oil", Price = 5.99M, ShortDescription = "Straight From Nascar", LongDescription = "Hear the engines revving with this fast selling top fuel race car slime. This slime has been rated at 495 hp so hold on tight while playing with it, first or last baby" }

                    );

                context.SaveChanges();
            }
        }
    }
}
