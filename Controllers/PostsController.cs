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

  [HttpGet("{id}")]
  public async Task<ActionResult<Post>> GetPost(int id)
  {
    var post = await _context.Posts.FindAsync(id);
    if (post == null)
    {
      return NotFound();
    }
    return post;
  }

  [HttpPost]
  public async Task<ActionResult<Post>> CreatePost(Post post)
  {
    post.FechaCreacion = DateTime.Now;
    _context.Posts.Add(post);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetPost), new { id = post.Id }, post);
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> UpdatePost(int id, Post updatedPost)
  {
    if (id != updatedPost.Id)
    {
      return BadRequest();
    }

    var existingPost = await _context.Posts.FindAsync(id);
    if (existingPost == null)
    {
      return NotFound();
    }

    existingPost.Titulo = updatedPost.Titulo;
    existingPost.Contenido = updatedPost.Contenido;

    await _context.SaveChangesAsync();
    return NoContent();
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> DeletePost(int id)
  {
    var post = await _context.Posts.FindAsync(id);
    if (post == null)
    {
      return NotFound();
    }

    _context.Posts.Remove(post);
    await _context.SaveChangesAsync();
    return NoContent();
  }
}
