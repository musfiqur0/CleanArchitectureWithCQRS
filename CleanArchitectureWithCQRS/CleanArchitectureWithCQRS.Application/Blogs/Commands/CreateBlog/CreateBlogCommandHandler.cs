using AutoMapper;
using CleanArchitectureWithCQRS.Application.Blogs.Queries.GetBlogs;
using CleanArchitectureWithCQRS.Domain.Entity;
using CleanArchitectureWithCQRS.Domain.Repository;
using MediatR;

namespace CleanArchitectureWithCQRS.Application.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommandHandler(IBlogRepository _blogRepository, IMapper _mapper)
        : IRequestHandler<CreateBlogCommand, BlogVm>
    {
        public async Task<BlogVm> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var blogEntity = new Blog() 
            { 
                Name = request.Name, 
                Description = request.Description, 
                Author = request.Author 
            };

            var Result = await _blogRepository.CreateAsync(blogEntity);

            return _mapper.Map<BlogVm>(Result);
        }
    }
}
