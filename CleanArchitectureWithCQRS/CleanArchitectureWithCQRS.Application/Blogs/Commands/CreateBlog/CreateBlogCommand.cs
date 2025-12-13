using CleanArchitectureWithCQRS.Application.Blogs.Queries.GetBlogs;
using MediatR;

namespace CleanArchitectureWithCQRS.Application.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommand : IRequest<BlogVm>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}
