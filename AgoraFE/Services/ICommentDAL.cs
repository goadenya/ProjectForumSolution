using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AgoraFE.Services
{
    interface ICommentDAL
    {
        Task<Uri> AddComment(Models.Comment Comment);
        Task<Models.Comment> UpdatePost(Models.Comment Comment);
        Task<Models.Comment> GetComment(int id);
        Task<HttpStatusCode> DeleteComment(int id);
        Task<List<Models.Comment>> GetAllComments();
        void InitiateRequest();
    }
}
