using CleanArchitectureWithCQRS.Domain.Entity;
using CleanArchitectureWithCQRS.Domain.Repository;
using CleanArchitectureWithCQRS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureWithCQRS.Infrastructure.Repository
{
    public class BlogRepository(BlogDbContext _blogDbContext) : IBlogRepository
    {
        public async Task<Blog> CreateAsync(Blog blog)
        {
            await _blogDbContext.Blogs.AddAsync(blog);
            await _blogDbContext.SaveChangesAsync();
            return blog;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _blogDbContext.Blogs
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();
        }

        public async Task<List<Blog>> GetAllBlogsAsync()
        {
            return await _blogDbContext.Blogs.AsNoTracking().ToListAsync();
        }

        public async Task<Blog> GetByIdAsync(int id)
        {
            return await _blogDbContext.Blogs.AsNoTracking()
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<int> UpdateAsync(int id, Blog blog)
        {
            return await _blogDbContext.Blogs
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.Name, blog.Name)
                    .SetProperty(m => m.Description, blog.Description)
                    .SetProperty(m => m.Author, blog.Author)
                    );
        }
    }
}
