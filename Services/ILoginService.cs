using WebBlog.Data.Requests;
using WebBlog.Data.Responses;
using System.Threading.Tasks;

namespace WebBlog.Services
{
    public interface ILoginService
    {
        Task<LoginResponse> Login(LoginRequest request);
    }
}
