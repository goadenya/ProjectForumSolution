using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AgoraFE.Services
{
    interface ICategoryDAL
    {
        Task<Uri> AddCategory(Models.Category Category);
        Task<Models.Category> UpdateCategory(Models.Category Category);
        Task<Models.Category> GetCategory(string id);
        Task<HttpStatusCode> DeleteCategory(string id);
        Task<List<Models.Category>> GetAllCategories();
        void InitiateRequest();
    }
}
