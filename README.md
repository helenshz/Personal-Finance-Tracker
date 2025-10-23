# Personal Finance Tracker

This is a simple web application built with ASP.NET Core MVC and Entity Framework Core (EF Core), designed to help users locally track and manage personal income and expense transactions.

This project serves as a portfolio piece to showcase proficiency in C# backend development, SQL database operations (via EF Core), and basic Web UI design.

## 🛠️ Tech Stack

| Area | Technology / Framework | Purpose |
| :--- | :--- | :--- |
| **Backend** | C# / .NET 9 (or version used) | Core business logic (Controllers, Models) |
| **Framework** | ASP.NET Core MVC | Web application architecture and routing |
| **Data Access** | Entity Framework Core (EF Core) | Object-Relational Mapping (ORM) for database interaction |
| **Database** | SQLite (or MSSQL LocalDB) | Local data persistence and storage |
| **Frontend** | Razor Views (`.cshtml`) | Dynamic HTML rendering and templating |
| **Styling** | Bootstrap 5 | Responsive layout and minimal, Apple-inspired UI |

## ✨ Core Features

* **Transaction History (Index):** Displays a list of all recorded transactions.
* **Record Creation (Create):** Enables input of new income or expense items.
* **Record Deletion (Delete):** Provides a confirmation page to remove unwanted transactions.
* **Data Model:** Includes core fields such as `Date`, `Description`, `Amount`, and `Category`.
* **Minimalist UI:** Features a clean, Apple-inspired design focused on readability.

## 🚀 Getting Started

To run this project locally, you must have the [.NET SDK](https://dotnet.microsoft.com/download) installed.

1.  **Clone the Repository:**
    ```bash
    git clone [https://github.com/helenshz/Personal-Finance-Tracker.git](https://github.com/helenshz/Personal-Finance-Tracker.git)
    cd Personal-Finance-Tracker
    ```

2.  **Build and Run Migrations (Database Setup):**
    * The project uses EF Core Code-First. Ensure you have the global tool installed.
    ```bash
    # Install EF Core tool globally if needed
    dotnet tool install --global dotnet-ef 
    # Create and update the database schema (The SQLite file finance.db will be generated)
    dotnet ef database update 
    ```

3.  **Run the Application:**
    ```bash
    # Use watch mode for live updates during development
    dotnet watch 
    ```

4.  **Access the App:**
    * Open your browser and navigate to: `http://localhost:5002` (or the port shown in the terminal)

## 📌 Future Plans

This project is a work in progress. Planned future enhancements include:

* User authentication and multi-user support.
* Monthly/Annual statistical reporting and chart visualization.
* Budget tracking functionality.
* Data import/export capabilities (CSV/Excel).
