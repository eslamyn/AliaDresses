using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliaDresses.Models
{
    public class MockDressRepository : IDressRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Dress> AllDresses =>
            new List<Dress>
            {
                new Dress{DressId=1, Model="Dress1", Color="purple", Price=499,ShortDescription="Tall purple dress" , LongDescription="Chase your dreams in high heels and tall dress.",Category = _categoryRepository.AllCategories.ToList()[0], InStock=true ,IsDressOfTheWeek=false},
                new Dress{DressId=2, Model="Dress2", Color="baby blue", Price=399,ShortDescription="Tall baby blue dress" , LongDescription="Shine bright in the sky.",Category = _categoryRepository.AllCategories.ToList()[0],InStock=true ,IsDressOfTheWeek=false},
                new Dress{DressId=3, Model="Dress3", Color="white", Price=999,ShortDescription="Tall white simple dress" , LongDescription="Be the princess of the party.", Category = _categoryRepository.AllCategories.ToList()[0],InStock=true ,IsDressOfTheWeek=false},
                new Dress{DressId=4, Model="Dress4", Color="Black and White", Price=299,ShortDescription="casual dress" , LongDescription="A casual dress is the best choise in summer.",Category = _categoryRepository.AllCategories.ToList()[1],InStock=true ,IsDressOfTheWeek=true}


            };
        public IEnumerable<Dress> DressesOfTheWeek { get; }
        public Dress GetDressById(int DressId)
        {
            return AllDresses.FirstOrDefault(D => D.DressId == DressId);
        }
    }
    
    
}
