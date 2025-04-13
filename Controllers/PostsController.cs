using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticaApiEfMysql.Data;
using PracticaApiEfMysql.Models;

namespace PracticaApiEfMysql.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostsController : ControllerBase
{
  private readonly AppDbContext _context;

  public PostsController(AppDbContext context)
  {
    _context = context;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
  {
    return await _context.Posts.ToListAsync();
  }

  [HttpPost]
  public async Task<ActionResult<Post>> CrearPost(Post post)
  {
    _context.Posts.Add(post);
    await _context.SaveChangesAsync();
    return CreatedAtAction(nameof(GetPosts), new { id = post.Id }, post);
  }
}
