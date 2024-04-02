using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using wad_backend.Context;
using wad_backend.Models;
using wad_backend.Repository;

namespace wad_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;

        public PostController(IPostRepository postRepository)
        {
            this._postRepository = postRepository;
        }

        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns>Get All Users</returns>
        [HttpGet("")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _postRepository.getAllPosts();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPostById(int id)
        {
            var user = await _postRepository.getPostById(id);
            return Ok(user);
        }
    }
}
