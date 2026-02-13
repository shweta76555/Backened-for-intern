# Backend Intern Assignment - ASP.NET Core Web API

## 📌 Project Overview

This project is a backend Web API built using ASP.NET Core.  
It includes authentication, role-based access control, async CRUD operations, API versioning, validation, global error handling, and security best practices.

---

## 🚀 Features Implemented

- User Registration with BCrypt password hashing
- Login with JWT authentication
- Role-Based Access Control (User & Admin)
- Admin-only endpoints
- Async CRUD operations for ProjectItem (Service Layer)
- API Versioning (v1)
- Input Validation using DataAnnotations
- Global Exception Handling Middleware
- Postman API Documentation
- Security Best Practices

---

## 🛠 Tech Stack

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- JWT Authentication
- BCrypt Password Hashing
- API Versioning
- Postman for API Documentation

---

## 🔐 Authentication & Authorization

- Passwords are securely hashed using BCrypt.
- JWT token is generated on successful login.
- Role-based authorization implemented using:
  
  - User Role
  - Admin Role
  - Admin-only endpoints

- Protected routes require Bearer token.

---

## 📦 CRUD Operations (ProjectItem)

- Create ProjectItem
- Get All ProjectItems
- Get ProjectItem by ID
- Update ProjectItem
- Delete ProjectItem

All CRUD operations:
- Implemented using Service Layer
- Async database operations
- JWT protected

---

## 🧪 API Endpoints (v1)

### Authentication

POST `/api/v1/auth/register`  
POST `/api/v1/auth/login`

---

### User

GET `/api/v1/user/profile`  
GET `/api/v1/user/admin-data` (Admin only)

---

### ProjectItem

POST `/api/v1/projectitem`  
GET `/api/v1/projectitem`  
GET `/api/v1/projectitem/{id}`  
PUT `/api/v1/projectitem/{id}`  
DELETE `/api/v1/projectitem/{id}`  

---

## 🧾 Input Validation

- Required fields validation
- Email format validation
- Password minimum length rule
- Strong password regex (if applied)

---

## ⚠ Global Error Handling

Custom middleware implemented to return structured error responses:

```json
{
  "statusCode": 500,
  "message": "Something went wrong",
  "details": "Error details here"
}
```

---

## 🔒 Security Practices

- Password hashing using BCrypt
- Secure JWT secret configuration
- Environment variable support for secret key
- EF Core parameterized queries (SQL Injection safe)
- Input validation & sanitization

---

## 📚 API Documentation

Postman Collection is provided for:

- Authentication APIs
- Role-based APIs
- CRUD APIs

Import the Postman collection and set the environment variable:

```
baseUrl = http://localhost:5052
```

---

## 🏗 How To Run The Project

1. Clone the repository
2. Open the project in Visual Studio or VS Code
3. Update connection string in `appsettings.json`
4. Run database migration:

```
dotnet ef database update
```

5. Run the application:

```
dotnet run
```

6. Test APIs using Postman collection

---

## 📈 Scalability Approach

This application can be scaled using:

- Microservices architecture
- Redis caching
- Load balancing
- Docker containerization
- Horizontal scaling
- Cloud deployment (AWS / Azure)

---

## ✅ Project Status

✔ Authentication implemented  
✔ JWT authorization working  
✔ Role-based access control complete  
✔ Async CRUD operations complete  
✔ API versioning implemented  
✔ Input validation applied  
✔ Global error handling implemented  
✔ Security best practices applied  

---

## 👩‍💻 Author

Shweta  
Backend Developer Assignment Submission
