using Asp_Angular.Models.Domain;

namespace Asp_Angular.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
