# SampleNETapp
Sample project showcasing RESTful with .NET and C#.

# Endpoints Implemented

POST
/api/categories/
```
Request:
{
  "name" : "sample"
}

Response:
{
  "id" : 10,
  "name" : "sample"
}
```

LIST
/api/categories/
```
Response:
[
  {
    "id" : 10,
    "name" : "sample"
  },
  {
    "id" : 11,
    "name" : "sample"
  },
  {
    "id" : 12,
    "name" : "sample"
  }
]
```

PUT
/api/categories/
```
Request:
{
  "id" : 10,
  "name" : "newSample"
}

Response:
{
  "id" : 10,
  "name" : "newSample"
}
```

POST
/api/products/
```
Request:
{
  "name": "sample",
  "quantityInPackage": 1,
  "unitOfMeasurement": 2,
  "categoryId": 10
}

{
  "id": 10,
  "name": "sample",
  "quantityInPackage": 1,
  "unitOfMeasurement": "MG",
  "category": {
    "id": 10,
    "name": "newSample"
  }
}
```
