# Práctica API C#

[English](README.md)

Ejercicio de aprendizaje ASP.NET Core con controladores, Entity Framework Core y MySQL.

## Stack

C# · ASP.NET Core 8 · EF Core · Pomelo MySQL.

## Alcance y configuración

Configurar ConnectionStrings:DefaultConnection localmente (por ejemplo mediante user secrets de .NET). MySQL debe estar accesible; la aplicación detecta su versión al configurar el DbContext.

## API de publicaciones

[PostsController](Controllers/PostsController.cs) expone `GET /api/posts`, `GET /api/posts/{id}`, `POST /api/posts`, `PUT /api/posts/{id}` y `DELETE /api/posts/{id}`. El [modelo Post](Models/Post.cs) contiene `Id`, `Titulo`, `Contenido` y `FechaCreacion`.

El alta asigna `FechaCreacion` en el servidor y devuelve `201`. La actualización exige que el ID del body coincida con el de la ruta (`400` en caso contrario), modifica título/contenido y devuelve `204`; el borrado también devuelve `204`. Las operaciones individuales devuelven `404` si no existe la publicación. [Program.cs](Program.cs) registra los controladores sin configurar autenticación ni aplicación automática de migraciones EF; este ejercicio no proporciona esas capacidades.

## Desarrollo local

Usar un entorno compatible con el descriptor del proyecto.

```sh
dotnet restore
dotnet build
dotnet run
```

## Repositorios relacionados

- [Atlas API](https://github.com/matigaleanodev/proyecto-atlas-api)
