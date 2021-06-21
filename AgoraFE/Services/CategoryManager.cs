using AgoraFE.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AgoraFE.Services
{
    public class CategoryManager : ICategoryDAL
    {
        private readonly HttpClient _client;
        private const string Url = "api/Categories";

        public string Path { get; set; }
        public CategoryManager(HttpClient client)
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

        public async Task<Uri> AddCategory(Category category)
        {
            InitiateRequest();
            HttpResponseMessage response = await _client.PostAsJsonAsync(
                "api/Categories", category);
            response.EnsureSuccessStatusCode();
            
            // return URI of the created resource.
            return response.Headers.Location;
        }

        public async Task<Category> GetCategory(string id)
        {
            InitiateRequest();
            Path = $"{Url}/{id}";
            Category category = null;
            HttpResponseMessage response = await _client.GetAsync(Path);
            if (response.IsSuccessStatusCode)
            {
                category = await response.Content.ReadFromJsonAsync<Category>();
            }
            return category;
        }

        public async Task<List<Models.Category>> GetAllCategories()
        {
            InitiateRequest();

            List<Category> categoryList = null;
            HttpResponseMessage response = await _client.GetAsync(Url);
            if (response.IsSuccessStatusCode)
            {
                categoryList = await response.Content.ReadFromJsonAsync<List<Category>>();
            }
            return categoryList;
        }


        public async Task<Category> UpdateCategory(Category category)
        {
            InitiateRequest();

            HttpResponseMessage response = await _client.PutAsJsonAsync(
                $"api/categories/{category.Id}", category);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            category = await response.Content.ReadFromJsonAsync<Category>();
            return category;
        }

        public async Task<HttpStatusCode> DeleteCategory(string id)
        {
            HttpResponseMessage response = await _client.DeleteAsync(
                $"api/categories/{id}");
            return response.StatusCode;
        }

    }
}
