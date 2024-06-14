using WebBlog.Data.Models;

namespace WebBlog.Services
{
    public interface IPostService
    {
        Task<List<Post>> Get();
    }
}