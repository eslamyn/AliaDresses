using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliaDresses.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Soiree",Description="Soiree dress for the evening."},
                new Category{CategoryId=2, CategoryName="Casual", Description="Casual clothes for all occasions."},
                new Category{CategoryId=3, CategoryName="Kids", Description="Casual and soiree clothes for your kid."}

            };
    }
}
