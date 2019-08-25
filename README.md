# .NET-CORE-API
Simple API Rest with ASPNET CORE MVC and EF, Database in Memomry

## How to run the application:
> $ dotnet watch run

The application will be running on port 5000

## Routes

### GET
- /api/v1/products

### POST
- /api/v1/products
  - headers
    - "Content-Type": "application/json"

  - body(entity)
  ```
  {
    "title": "Mouse",
    "description": "Mouse microsoft",
    "price": 100.00
  }
  ```
