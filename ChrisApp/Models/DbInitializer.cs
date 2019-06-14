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
                    new Slime { Id = 1, Name = "Butter Slime", Price = 4.99M, ShortDescription = "The Classic Butter Slime", LongDescription = "A smooth butter-like texture with a light creamy yellow color to it. Similar to most classic Butter-Slimes with our little twist. Custom colors available at request.", ImageUrl = "https://www.pinterest.com/pin/93309023513282663/",  ImageThumbnailUrl = "https://www.pinterest.com/pin/93309023513282663/", IsSlimeOfTheWeek = false, IsInStock = true },
                    new Slime { Id = 2, Name = "Unicorn Snot", Price = 12.99M, ShortDescription = "Sparkly Exotic Rare Slime", LongDescription = "Whats more rare than a Unicorn? How about our famouse in house creation Unicorn Snot. This is a slime you will not find anywhere else and while the colors created very. All of them will leave you smiling", ImageUrl = "https://www.pinterest.com/pin/282882420325472636/", ImageThumbnailUrl = "https://www.pinterest.com/pin/282882420325472636/", IsSlimeOfTheWeek = false, IsInStock = false },
                    new Slime { Id = 3, Name = "Radioactive Waste", Price = 9.99M, ShortDescription = "Bright Green Glowing Slime", LongDescription = "O NO! A truck carrying radioactive waste crashed on the freeway and all the chemicals spilled out onto the street! Thats ok, we grabbed as much as could and decided me Slimify It! But be prepared for a bright glowing green goop", ImageUrl = "https://www.pinterest.com/pin/739716307519755085/", ImageThumbnailUrl = "https://www.pinterest.com/pin/739716307519755085/", IsSlimeOfTheWeek = false, IsInStock = true },
                    new Slime { Id = 4, Name = "Magnetic Slime", Price = 6.99M, ShortDescription = "Slime With A Sticky Secret", LongDescription = "While Nasa was training future Astronauts for their next space mission we were tasked out with creating their slime. With all of Nasa's resources at our disposal we created a slime that can attach itself to metal surfaces so it would not be lost in outer space!", ImageUrl = "https://www.pinterest.com/pin/384072674454146291/", ImageThumbnailUrl = "https://www.pinterest.com/pin/384072674454146291/", IsSlimeOfTheWeek = true, IsInStock = true },
                    new Slime { Id = 5, Name = "Crazy Slime", Price = 7.99M, ShortDescription = "Our Crazy Classic Slime", LongDescription = "Everyone loves our classic crazy slime, it will have you grinning from ear to ear for hours. Colors very and for an adiotional $1 you can request a custom color or colors to your liking.", ImageUrl = "https://www.pinterest.com/pin/352758583305163268/", ImageThumbnailUrl = "https://www.pinterest.com/pin/352758583305163268/", IsSlimeOfTheWeek = false, IsInStock = false },
                    new Slime { Id = 6, Name = "Alien Poop", Price = 8.99M, ShortDescription = "Out Of The World Slime", LongDescription = "While we weere in outer space we ran into some extra-terrastrial beings. Not only are they friendly creatures but they poop out really neat slimme. Check out this slime and how some support to the aliens that created it.", ImageUrl = "https://www.pinterest.com/pin/450782243947484925/",  ImageThumbnailUrl = "https://www.pinterest.com/pin/450782243947484925/", IsSlimeOfTheWeek = false, IsInStock = true },
                    new Slime { Id = 7, Name = "Engine Oil", Price = 5.99M, ShortDescription = "Straight From Nascar", LongDescription = "Hear the engines revving with this fast selling top fuel race car slime. This slime has been rated at 495 hp so hold on tight while playing with it, first or last baby", ImageUrl = "https://www.pinterest.com/pin/552183604302819115/", ImageThumbnailUrl = "https://www.pinterest.com/pin/552183604302819115/", IsSlimeOfTheWeek = false, IsInStock = true }

                    );

                context.SaveChanges();
            }
        }
    }
}
