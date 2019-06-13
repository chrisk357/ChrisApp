using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChrisApp.Models
{
    public interface ISlimeRepository
    {
        IEnumerable<Slime> GetAllSlimes();
        Slime GetSlimeById(int slimeId);
    }
}
