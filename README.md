# Products API — Clean Architecture + CQRS (MediatR)

Requirements: .NET 8 SDK, SQL Server / LocalDB.

## Run
    dotnet restore
    dotnet tool install --global dotnet-ef        # once
    dotnet ef migrations add InitialCreate -p Products.Infrastructure -s Products.API -o Persistence/Migrations
    dotnet run --project Products.API

In Development the migration is applied automatically at startup. Open /swagger.

## Endpoints
- GET  /api/products
- GET  /api/products/{id}
- POST /api/products   { "name": "Keyboard", "price": 49.99 }

## Dependencies
API -> Application, Infrastructure | Infrastructure -> Application -> Domain
