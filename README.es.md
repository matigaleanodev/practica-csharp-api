# Práctica API C#

[English](README.md)

Ejercicio de aprendizaje ASP.NET Core con controladores, Entity Framework Core y MySQL.

## Stack

C# · ASP.NET Core 8 · EF Core · Pomelo MySQL.

## Alcance y configuración

Configurar ConnectionStrings:DefaultConnection localmente (por ejemplo mediante user secrets de .NET). MySQL debe estar accesible; la aplicación detecta su versión al configurar el DbContext.

## Desarrollo local

Usar un entorno compatible con el descriptor del proyecto.

```sh
dotnet restore
dotnet build
dotnet run
```

## Repositorios relacionados

- [Atlas API](https://github.com/matigaleanodev/proyecto-atlas-api)
