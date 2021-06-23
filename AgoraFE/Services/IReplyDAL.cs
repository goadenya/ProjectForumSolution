using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AgoraFE.Services
{
    interface IReplyDAL
    {
        Task<Uri> AddReply(Models.Reply reply);
        Task<Models.Reply> UpdateReply(Models.Reply reply);
        Task<Models.Reply> GetReply(int id);
        Task<HttpStatusCode> DeleteReply(int id);
        Task<List<Models.Reply>> GetAllReplies();
        void InitiateRequest();
    }
}
