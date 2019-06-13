using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChrisApp.Models
{
    public class SlimeRepository : ISlimeRepository
    {
        private readonly AppDbContext _appDbContext;
        public SlimeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Slime> GetAllSlimes()
        {
            return _appDbContext.Slimes;
        }

        public Slime GetSlimeById(int slimeId)
        {
            return _appDbContext.Slimes.FirstOrDefault(s => s.Id == slimeId);
        }
    }
}
