
# StudentCRUD-MVC

A simple ASP.NET Core MVC application for managing students.  
This project demonstrates CRUD (Create, Read, Update, Delete) operations with Entity Framework Core and SQL Server.

---

## Features

- Add, edit, delete, and view students.
- MVC architecture (Models, Views, Controllers).
- Entity Framework Core database integration.
- Simple and clean UI with Bootstrap.
- Proper handling of validation and errors.

---

## Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- Visual Studio 2022 or later
- SQL Server or LocalDB

---

## Getting Started

1. **Clone the repository**

```bash
git clone https://github.com/hasnah98/StudentCRUD-MVC.git
cd StudentCRUD-MVC
```

2. **Restore NuGet packages**

```bash
dotnet restore
```

3. **Update the connection string**  
Open `appsettings.json` and update the connection string for your database.

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=StudentDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

4. **Apply migrations and create the database**

```bash
dotnet ef database update
```

5. **Run the application**

```bash
dotnet run
```

6. Open your browser and navigate to `https://localhost:5001` (or `http://localhost:5000`).

---

## Project Structure

- `Controllers/` - Handles HTTP requests and application logic.
- `Models/` - Defines data models (e.g., `Student`).
- `Views/` - Razor views for UI.
- `Data/` - Database context and EF Core migrations.
- `wwwroot/` - Static files (CSS, JS, images).

---

## Contributing

Feel free to fork this project and submit pull requests.  
Please follow the existing code style and commit messages format.

---

## License

This project is open-source and available under the MIT License.
