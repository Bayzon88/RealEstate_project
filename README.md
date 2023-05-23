
# MyLessee - Rental App

The idea behind MyLessee is to create a space in which people can post their new listings, find roomates, share housing oportunities and build a housing market community. 


## Demo

![](https://github.com/Bayzon88/RealEstate_project/blob/main/MyLessee_fullstack.gif?raw=true)


## Run Locally

Clone the project

```bash
  git clone https://github.com/Bayzon88/RealEstate_project.git
```

Install dependencies

```bash
  npm install
```

Start the vuejs server

```bash
  npm run serve
```

Start asp.NET API and create database
```bash
  update-database
```
Run front end 
```bash
  http://localhost:8080/
```


## Screenshots
#### Create Admin User
![Sign up](https://github.com/Bayzon88/RealEstate_project/blob/main/realestate_front/public/images/signup.png?raw=true)

#### Skip login 
![Sign up](https://github.com/Bayzon88/RealEstate_project/blob/main/realestate_front/public/images/login.png?raw=true)


## API Reference

#### Get all listings

```http
  GET /api/listing
```

#### Get Listing details 

```http
  GET /api/listing/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | Id of Housing Listing             |

#### Create new Housing Listing 

```http
  POST /api/listing
```

#### Modify Listing details 

```http
  PUT /api/listing/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | Id of Housing Listing             |

#### Delete Housing Listing 

```http
  DELETE /api/listing/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | Id of Housing Listing             |


