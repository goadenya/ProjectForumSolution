using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Services
{
    interface IPostDAL
    {
        Task<Models.Post> AddPost(Models.Post Post);
        Task UpdatePost(string editId, Models.Post Post);
        Task<Models.Post> GetPost(string id);
        Task<List<Models.Post>> GetPosts();
        Task<Models.Post> DeletePost(string id); 
    }
}
