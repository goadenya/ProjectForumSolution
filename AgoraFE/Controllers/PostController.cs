using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Controllers
{
    public class PostController : Controller
    {
        public PostController()
        {

        }
        public IActionResult AddPost()
        {

            return View();
        }
    }
}
