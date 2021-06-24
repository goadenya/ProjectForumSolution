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
    public class CommentManager : ICommentDAL
    {
        private readonly HttpClient _client;
        private const string Url = "api/Comments";
        public string Path { get; set; }
        public CommentManager(HttpClient client)
        {
            _client = client;
        }

        public async Task<Uri> AddComment(Models.Comment comment)
        {
            InitiateRequest();
            HttpResponseMessage response = await _client.PostAsJsonAsync(
                Url, comment);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }
        public async Task<Models.Comment> UpdatePost(Models.Comment comment)
        {
            InitiateRequest();

            HttpResponseMessage response = await _client.PutAsJsonAsync(
                $"{Url}/{comment.id}", comment);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            comment = await response.Content.ReadFromJsonAsync<Models.Comment>();
            return comment;
        }
        public async Task<Models.Comment> GetComment(int id)
        {
            InitiateRequest();
            Path = $"{Url}/{id}";
            Models.Comment comment = null;
            HttpResponseMessage response = await _client.GetAsync(Path);
            if (response.IsSuccessStatusCode)
            {
                comment = await response.Content.ReadFromJsonAsync<Models.Comment>();
            }
            return comment;
        }
        public async Task<HttpStatusCode> DeleteComment(int id)
        {
            HttpResponseMessage response = await _client.DeleteAsync(
                $"{Url}/{id}");
            return response.StatusCode;
        }
        public async Task<List<Models.Comment>> GetAllComments()
        {
            InitiateRequest();

            List<Models.Comment> commentList = null;
            HttpResponseMessage response = await _client.GetAsync(Url);
            if (response.IsSuccessStatusCode)
            {
                commentList = await response.Content.ReadFromJsonAsync<List<Models.Comment>>();
            }
            return commentList;
        }
        public void InitiateRequest()
        {
            _client.BaseAddress = new Uri("https://agorapostapi.azurewebsites.net/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
