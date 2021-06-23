using AgoraPostAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraPostAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubforumController : ControllerBase
    {
        private readonly AgoraPostContext _context;

        public SubforumController(AgoraPostContext context)
        {
            _context = context;
        }

        // GET: api/Subforum/categoryName
        [HttpGet("{categoryName}")]
        public async Task<ActionResult<Category>> GetCategory(string categoryName)
        {
            var category = await _context.Category.Where(x => x.Name == categoryName).Include(x => x.Posts).FirstOrDefaultAsync();

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }
    }
}
