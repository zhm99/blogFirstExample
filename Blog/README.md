## About solution
- Solution is implemented in .NET Core 2.1
- Implemented Postman for testing


## Create Post

### Request

`POST /api/blogposts`

          curl -X POST "https://localhost:44370/api/blogposts" -H "accept: application/json"

### Response

[
    {
        "postId": 4,
        "slug": "augmented-reality-ios-application",
        "title": "Augmented Reality iOS Application",
        "description": "Software Development and furniture are proud to launch an augmented reality app.",
        "body": "The app is simple to use, and will help you decide on your best furniture fit.",
        "createdAt": "2018-05-18T03:22:56.637",
        "updatedAt": "2018-05-18T03:48:35.824",
        "postsCount": 0
    },
    {
        "postId": 3,
        "slug": "augmented-reality-ios-application",
        "title": "Augmented Reality iOS Application",
        "description": "Software Development and furniture are proud to launch an augmented reality app.",
        "body": "The app is simple to use, and will help you decide on your best furniture fit.",
        "createdAt": "2018-05-18T03:22:56.637",
        "updatedAt": "2018-05-18T03:48:35.824",
        "postsCount": 0
    },
    {
        "postId": 2,
        "slug": "augmented-reality-ios-application",
        "title": "Augmented Reality iOS Application",
        "description": "Software Development and furniture are proud to launch an augmented reality app.",
        "body": "The app is simple to use, and will help you decide on your best furniture fit.",
        "createdAt": "2018-05-18T03:22:56.637",
        "updatedAt": "2018-05-18T03:48:35.824",
        "postsCount": 0
    },
    {
        "postId": 1,
        "slug": "Martin",
        "title": "Test",
        "description": "",
        "body": "Testing",
        "createdAt": "0001-01-01T00:00:00",
        "updatedAt": "2019-09-12T18:18:02.19",
        "postsCount": 0
    }
]

## Get Blog Post 

### Request
`POST /api/blogposts`

          curl -X POST "https://localhost:44370/api/blogposts" -H "accept: application/json"

### Response

[
    {
        "postId": 4,
        "slug": "augmented-reality-ios-application",
        "title": "Augmented Reality iOS Application",
        "description": "Software Development and furniture are proud to launch an augmented reality app.",
        "body": "The app is simple to use, and will help you decide on your best furniture fit.",
        "createdAt": "2018-05-18T03:22:56.637",
        "updatedAt": "2018-05-18T03:48:35.824",
        "postsCount": 0
    },

## Update Blog Post

### Request

`PUT /api/BlogPosts/5

           curl -X PUT "https://localhost:44370/api/BlogPosts/5"


## Delete a Thing

### Request

`DELETE /api/BlogPosts/5

    curl -X DELETE "https://localhost:44370/api/BlogPosts/5 'Accept: application/json'





