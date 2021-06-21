using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AgoraFE.Services
{
    interface IPostDAL
    {
        Task<Uri> AddPost(Models.Post Post);
        Task<Models.Post> UpdatePost(Models.Post Post);
        Task<Models.Post> GetPost(string id);
        Task<HttpStatusCode> DeletePost(string id);
        Task<List<Models.Post>> GetAllPosts ();
        void InitiateRequest();
    }
}
