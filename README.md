# UserManagementAPI

This is a back-end RESTful API project built using ASP.NET Core for managing users.
It was developed as part of the Microsoft Back-End Development Specialization using Microsoft Copilot.

The API supports full CRUD operations, logging, error handling, and token-based authentication via middleware.

## 🔧 Technologies Used
- ASP.NET
- Microsoft Copilot
- C#
- Postman (for testing)

## 📡 API Endpoints

| Method | Endpoint        | Description             |
|--------|------------------|-------------------------|
| GET    | /api/users       | Get all users           |
| GET    | /api/users/{id}  | Get user by ID          |
| POST   | /api/users       | Create a new user       |
| PUT    | /api/users/{id}  | Update an existing user |
| DELETE | /api/users/{id}  | Delete user by ID       |

## 🧩 Middleware Implemented

- **Error Handling Middleware**: Catches unhandled exceptions and returns JSON error responses.
- **Token Authentication Middleware**: Requires a valid token in the `Authorization` header (e.g., `Bearer VALID_TOKEN`).
- **Logging Middleware**: Logs HTTP method, path, and status code of all requests and responses.

📌 Middleware Order:
1. Error Handling
2. Token Authentication
3. Logging

## 🚀 Getting Started

### Prerequisites:
- .NET SDK 7+
- Git

### Run Locally:
```bash
git clone https://github.com/YOUR_USERNAME/UserManagementAPI.git
cd UserManagementAPI
dotnet run
```
The API will start at: `http://localhost:5000` or `https://localhost:5001`

## 🧪 Testing the API

Use Postman or cURL with a valid `Authorization` header:

```
Authorization: Bearer VALID_TOKEN
```

Try GET, POST, PUT, DELETE requests to test user management.

## 🤖 Copilot Assistance Summary

- Used Copilot to generate the base controller for CRUD operations.
- Used Copilot suggestions to add model validation and error handling logic.
- Generated all middleware (logging, error handling, and token auth) using Copilot prompts.
- Copilot also suggested fixes for common exceptions and helped streamline the controller logic.
