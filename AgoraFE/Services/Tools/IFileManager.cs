using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Services.Tools
{
    interface IFileManager
    {
        string UploadFile(IFormFile file);
    }
}
