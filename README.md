# .NET-CORE-API
A simple API Restfull using ASP.NET Core, MVC and Entity Framework Core with Database connection in Memory

## How to run the application local:
> $ dotnet watch run
The application will be running on port 5000

## How to build the project:
> $ dotnet run build

## Endpoints(routes)

### Get all Products => (Method GET)
- /api/v1/products
Should be return a list of products and status code(200):
```
[
  {
    "id": 1,
    "title": "Mouse",
    "description": "Mouse microsoft",
    "price": 100
  },
  {
    "id": 2,
    "title": "Mouse",
    "description": "Mouse microsoft",
    "price": 100
  }
  ...
]
```

### Create a Product => (Method POST)
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
Should be created a product and return a message string:
```
"Product saved!"
```

### Get a Product by ID => (Method GET)
- /api/v1/products/{product_id}
comming soon...

### Update a Full Product by ID => (Method PUT)
- /api/v1/products/{product_id}
comming soon...

### Update a item of Product by ID => (Method PATCH)
- /api/v1/products/{product_id}
comming soon...

### Delete a Product by ID => (Method DELETE)
- /api/v1/products/{product_id}
comming soon...
