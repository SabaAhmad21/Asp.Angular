using Asp_Angular.Data;
using Asp_Angular.Models.Domain;
using Asp_Angular.Repositories.Interface;

namespace Asp_Angular.Repositories.Implmentations
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryRepository(ApplicationDbContext dbContext) 
        {
        
        _dbContext = dbContext;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();

            return category;

        }
    }
}
