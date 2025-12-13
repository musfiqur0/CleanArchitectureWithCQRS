using CleanArchitectureWithCQRS.Application.Blogs.Queries.GetBlogs;
using CleanArchitectureWithCQRS.Domain.Entity;
using CleanArchitectureWithCQRS.Domain.Repository;
using MediatR;

namespace CleanArchitectureWithCQRS.Application.Blogs.Commands.UpdateBlog
{
    public class UpdateBlogCommandHandler(IBlogRepository _blogRepository)
        : IRequestHandler<UpdateBlogCommand, int>
    {
        public async Task<int> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var updateBlogEntity = new Blog()
            {
                Id = request.Id,
                Author = request.Author,
                Description = request.Description,
                Name = request.Name
            };

            return await _blogRepository.UpdateAsync(request.Id, updateBlogEntity);
        }
    }
}
