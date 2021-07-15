using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliaDresses.Models
{
    public interface IDressRepository
    {
        IEnumerable<Dress> AllDresses { get; }
        IEnumerable<Dress> DressesOfTheWeek { get; }
        Dress GetDressById(int DressId);
    }
}
