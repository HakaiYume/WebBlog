using System.Net.Http.Json;
using WebBlog.Data.Models;

namespace WebBlog.Services
{
    public class PostService:IPostService
    {
        private readonly HttpClient _http;

        public PostService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Post>> Get()
        {
            var response = await _http.GetAsync("api/post");

            if (response.IsSuccessStatusCode){
                var result = await response.Content.ReadFromJsonAsync<List<Post>>();
                return result;
            }else{
                return new List<Post>();
            }
        }

        public async Task<List<Post>> GetById(int Id)
        {
            var response = await _http.GetAsync("api/post?Id=" + Id.ToString());

            if (response.IsSuccessStatusCode){
                var result = await response.Content.ReadFromJsonAsync<List<Post>>();
                return result;
            }else{
                return new List<Post>();
            }
        }

        public async Task<List<Post>> GetTop()
        {
            var response = await _http.GetAsync("api/post?PageSize=3");

            if (response.IsSuccessStatusCode){
                var result = await response.Content.ReadFromJsonAsync<List<Post>>();
                return result;
            }else{
                return new List<Post>();
            }
        }
    }
}