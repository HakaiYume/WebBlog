using WebBlog.Data.Models;

namespace WebBlog.Services
{
    public interface IPostService
    {
        Task<List<Post>> Get();

        Task<List<Post>> GetById(int Id);

        Task<List<Post>> GetTop();
    }
}