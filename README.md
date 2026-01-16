# Práctica API C#

[Español](README.es.md)

ASP.NET Core learning exercise using controllers, Entity Framework Core and MySQL.

## Stack

C# · ASP.NET Core 8 · EF Core · Pomelo MySQL.

## Scope and configuration

Configure ConnectionStrings:DefaultConnection locally (for example through .NET user secrets). MySQL must be reachable; the application detects its version when configuring the DbContext.

## Posts API

[PostsController](Controllers/PostsController.cs) exposes `GET /api/posts`, `GET /api/posts/{id}`, `POST /api/posts`, `PUT /api/posts/{id}` and `DELETE /api/posts/{id}`. The [Post model](Models/Post.cs) contains `Id`, `Titulo`, `Contenido` and `FechaCreacion`.

Creation assigns `FechaCreacion` on the server and returns `201`. Updating requires the body ID to match the route ID (`400` otherwise), changes title/content and returns `204`; deletion also returns `204`. Individual operations return `404` for missing posts. [Program.cs](Program.cs) maps controllers without configuring authentication or automatic application of EF migrations; do not assume either is provided by this exercise.

## Local development

Use a toolchain compatible with the project descriptor.

```sh
dotnet restore
dotnet build
dotnet run
```

## Related repositories

- [Atlas API](https://github.com/matigaleanodev/proyecto-atlas-api)
