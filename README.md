# Práctica API C#

[Español](README.es.md)

ASP.NET Core learning exercise using controllers, Entity Framework Core and MySQL.

## Stack

C# · ASP.NET Core 8 · EF Core · Pomelo MySQL.

## Scope and configuration

Configure ConnectionStrings:DefaultConnection locally (for example through .NET user secrets). MySQL must be reachable; the application detects its version when configuring the DbContext.

## Local development

Use a toolchain compatible with the project descriptor.

```sh
dotnet restore
dotnet build
dotnet run
```

## Related repositories

- [Atlas API](https://github.com/matigaleanodev/proyecto-atlas-api)
