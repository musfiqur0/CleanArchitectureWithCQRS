using CleanArchitectureWithCQRS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureWithCQRS.Domain.Repository
{
    public interface IBlogRepository
    {
        Task<List<Blog>> GetAllBlogsAsync();
        Task<Blog> GetByIdAsync(int id);
        Task<Blog> CreateAsync(Blog blog);
        Task<int> UpdateAsync(int id, Blog blog);
        Task<int> DeleteAsync(int id);
    }
}
