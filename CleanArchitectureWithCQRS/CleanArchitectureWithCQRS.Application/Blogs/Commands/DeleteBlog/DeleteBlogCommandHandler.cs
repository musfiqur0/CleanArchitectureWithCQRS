using CleanArchitectureWithCQRS.Domain.Repository;
using MediatR;

namespace CleanArchitectureWithCQRS.Application.Blogs.Commands.DeleteBlog
{
    public class DeleteBlogCommandHandler(IBlogRepository _blogRepository)
        : IRequestHandler<DeleteBlogCommand, int>
    {
        public async Task<int> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
        {
            return await _blogRepository.DeleteAsync(request.Id);
        }
    }
}
