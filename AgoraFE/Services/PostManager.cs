using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AgoraFE.Services
{
    public class PostManager : IPostDAL
    {
        private readonly HttpClient _client;
        private const string Url = "api/Posts";

        public string Path { get; set; }
        public PostManager(HttpClient client)
        {
            _client = client;
        }

        public void InitiateRequest()
        {
            _client.BaseAddress = new Uri("https://localhost:44337/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Uri> AddPost(Models.Post post)
        {
            InitiateRequest();
            HttpResponseMessage response = await _client.PostAsJsonAsync(
                "api/Categories", post);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }
        public async Task<Models.Post> UpdatePost(Models.Post post)
        {
            InitiateRequest();

            HttpResponseMessage response = await _client.PutAsJsonAsync(
                $"api/posts/{post.id}", post);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            post = await response.Content.ReadFromJsonAsync<Models.Post>();
            return post;
        }
        public async Task<Models.Post> GetPost(int id)
        {
            InitiateRequest();
            Path = $"{Url}/{id}";
            Models.Post post = null;
            HttpResponseMessage response = await _client.GetAsync(Path);
            if (response.IsSuccessStatusCode)
            {
                post = await response.Content.ReadFromJsonAsync<Models.Post>();
            }
            return post;
        }
        public async Task<HttpStatusCode> DeletePost(int id)
        {
            HttpResponseMessage response = await _client.DeleteAsync(
                $"api/posts/{id}");
            return response.StatusCode;
        }
        public async Task<List<Models.Post>> GetAllPosts()
        {
            InitiateRequest();

            List<Models.Post> postList = null;
            HttpResponseMessage response = await _client.GetAsync(Url);
            if (response.IsSuccessStatusCode)
            {
                postList = await response.Content.ReadFromJsonAsync<List<Models.Post>>();
            }
            return postList;
        }
    }
}
