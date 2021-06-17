using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Services
{
    interface ICategoryDAL
    {
        Task<Models.Category> AddCategory(Models.Category Post);
        Task UpdateCategory(string editId, Models.Category Post);
        Task<Models.Category> GetCategory(string id);
        Task<List<Models.Category>> GetCategory();
        Task<Models.Category> DeleteCategory(string id);
    }
}
