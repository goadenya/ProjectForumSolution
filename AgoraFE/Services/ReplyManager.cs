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
    public class ReplyManager : IReplyDAL
    {
        private readonly HttpClient _client;
        private const string Url = "api/Replies";
        public string Path { get; set; }
        public ReplyManager(HttpClient client)
        {
            _client = client;
        }

        public async Task<Uri> AddReply(Models.Reply reply)
        {
            InitiateRequest();
            HttpResponseMessage response = await _client.PostAsJsonAsync(
                Url, reply);
            response.EnsureSuccessStatusCode();
        
            // return URI of the created resource.
            return response.Headers.Location;
        }

        public async Task<Models.Reply> UpdateReply(Models.Reply reply)
        {
            InitiateRequest();

            HttpResponseMessage response = await _client.PutAsJsonAsync(
                $"{Url}/{reply.id}", reply);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            reply = await response.Content.ReadFromJsonAsync<Models.Reply>();
            return reply;
        }

        public async Task<Models.Reply> GetReply(int id)
        {
            InitiateRequest();
            Path = $"{Url}/{id}";
            Models.Reply reply = null;
            HttpResponseMessage response = await _client.GetAsync(Path);
            if (response.IsSuccessStatusCode)
            {
                reply = await response.Content.ReadFromJsonAsync<Models.Reply>();
            }
            return reply;
        }

        public async Task<HttpStatusCode> DeleteReply(int id)
        {
            HttpResponseMessage response = await _client.DeleteAsync(
              $"{Url}/{id}");
            return response.StatusCode;
        }
        public async Task<List<Models.Reply>> GetAllReplies()
        {
            InitiateRequest();

            List<Models.Reply> replyList = null;
            HttpResponseMessage response = await _client.GetAsync(Url);
            if (response.IsSuccessStatusCode)
            {
                replyList = await response.Content.ReadFromJsonAsync<List<Models.Reply>>();
            }
            return replyList;
        }
        public void InitiateRequest()
        {
            _client.BaseAddress = new Uri("https://localhost:44337/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
