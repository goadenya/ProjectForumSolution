using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Services
{
    interface IPostDAL
    {
        Task<Models.PostModel> AddPost(Models.PostModel Post);
        Task UpdatePost(string editId, Models.PostModel Post);
        Task<Models.PostModel> GetPost(string id);
        Task<List<Models.PostModel>> GetPosts();
        Task<Models.PostModel> DeletePost(string id); 
    }
}
