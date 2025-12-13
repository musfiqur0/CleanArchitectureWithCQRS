using AutoMapper;
using CleanArchitectureWithCQRS.Application.Blogs.Queries.GetBlogs;
using CleanArchitectureWithCQRS.Domain.Repository;
using MediatR;

namespace CleanArchitectureWithCQRS.Application.Blogs.Queries.GetBlogById
{
    public class GetBlogByIdQueryHandler(IBlogRepository _blogRepository, IMapper _mapper) 
        : IRequestHandler<GetBlogByIdQuery, BlogVm>
    {
        public async Task<BlogVm> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var blog = await _blogRepository.GetByIdAsync(request.BlogId);
            return _mapper.Map<BlogVm>(blog);
        }
    }
}
