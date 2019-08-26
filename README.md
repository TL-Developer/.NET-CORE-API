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

![](https://memecreator.org/static/images/memes/3972468.jpg)


### Update a Full Product by ID => (Method PUT)
- /api/v1/products/{product_id}

![](https://scontent.fudi1-1.fna.fbcdn.net/v/t1.0-9/23380181_1716534031704055_1886599748466546100_n.jpg?_nc_cat=103&_nc_oc=AQlqOFNIVsnt6eVtMBSCZjS_jmiq4gEFDpnFIpa39BH3ap9AI_aQqdWjuEJijHvziPE&_nc_ht=scontent.fudi1-1.fna&oh=2ae28f91b361eacea8431284580601f1&oe=5E0D3B63)

### Update a item of Product by ID => (Method PATCH)
- /api/v1/products/{product_id}

![](https://www.meme-arsenal.com/memes/988153b3b4703e114594963e0633b207.jpg)

### Delete a Product by ID => (Method DELETE)
- /api/v1/products/{product_id}

![](https://www.memecreator.org/static/images/memes/5035134.jpg)
