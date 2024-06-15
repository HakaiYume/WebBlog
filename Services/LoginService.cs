using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebBlog.Data.Models;
using WebBlog.Data.Requests;
using WebBlog.Data.Responses;

namespace WebBlog.Services
{
    public class LoginService:ILoginService
    {
        private readonly HttpClient _http;

        public LoginService(HttpClient http)
        {
            _http = http;
        }

        public async Task<LoginResponse> Login(LoginRequest request)
        {
            var response = await _http.PostAsJsonAsync("api/login", request);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<LoginResponse>();
                return result;
            }
            else
            {
                return new LoginResponse { Token = string.Empty };
            }
        }
    }
}
