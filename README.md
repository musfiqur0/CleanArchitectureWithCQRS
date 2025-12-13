
# CleanArchitectureWithCQRS

This repository demonstrates a simple CRUD API for blog posts using Clean Architecture with CQRS. Below you will find an overview of the available endpoints and example request bodies.

## API Endpoints

The API exposes a set of routes for working with `Blog` resources. Each route uses a conventional HTTP verb:

- **GetAll (GET)**: `/api/Blog/` – returns a list of all blog posts.
- **GetById (GET)**: `/api/Blog/{id}` – returns a single post by its identifier.
- **Create (POST)**: `/api/Blog/` – creates a new blog post.
- **Update (PUT)**: `/api/Blog/{id}` – updates an existing post.
- **Delete (DELETE)**: `/api/Blog/{id}` – removes a post by its identifier.

## Sample Payloads

Use the following JSON payloads as examples when creating or updating a blog post.

### Create

```json
{
  "name": "Hello",
  "description": "World",
  "author": "string"
}
```

### Update

```json
{
  "id": 4,
  "name": "4",
  "description": "4",
  "author": "4"
}
```

