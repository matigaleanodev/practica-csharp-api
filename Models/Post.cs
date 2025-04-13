namespace PracticaApiEfMysql.Models;

public class Post
{
  public int Id { get; set; }
  public string Titulo { get; set; } = string.Empty;
  public string Contenido { get; set; } = string.Empty;
  public DateTime FechaCreacion { get; set; } = DateTime.Now;
}