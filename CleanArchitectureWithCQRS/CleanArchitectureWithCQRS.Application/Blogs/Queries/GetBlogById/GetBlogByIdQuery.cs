using CleanArchitectureWithCQRS.Application.Blogs.Queries.GetBlogs;
using MediatR;

namespace CleanArchitectureWithCQRS.Application.Blogs.Queries.GetBlogById
{
    public class GetBlogByIdQuery : IRequest<BlogVm>
    {
        public int BlogId { get; set; }
    }
}
