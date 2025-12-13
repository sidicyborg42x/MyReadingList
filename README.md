# 📚 MyReadingList

**MyReadingList** is a full-stack .NET application designed to track books, reading status, and personal reviews.

I am building this project to learn modern **.NET Development** by following a "Vertical Slice" architecture, moving from the database layer all the way to the frontend UI for each feature.

## 🚀 Tech Stack

* **Framework:** .NET 10.0
* **Backend:** ASP.NET Core Web API
* **Frontend:** to be decided
* **Database:** SQL Server
* **ORM:** Entity Framework Core

## 🗺️ Project Roadmap (Vertical Slices)

I am building this app in 3 distinct stages ("Slices") to master specific concepts.

### ✅ Slice 1: The Foundation (Current Focus)
*Goal: Basic CRUD (Create, Read, Update, Delete) and Database connection.*
- [ ] Create `Book` Data Model
- [ ] Setup EF Core & SQLite Connection
- [ ] Build API Endpoint: `GET /api/books` (Fetch all)
- [ ] Build API Endpoint: `POST /api/books` (Add new)
- [ ] Blazor Page: Display list of books
- [ ] Blazor Form: Add a new book

### 🚧 Slice 2: Status Tracking
*Goal: Business Logic and Updates.*
- [ ] Add `IsRead` or `Status` column to Database
- [ ] Build API Endpoint: `PUT /api/books/{id}`
- [ ] Blazor UI: Checkbox/Dropdown to update status
- [ ] UI Logic: Strikethrough text for "Read" books

### 🚧 Slice 3: Reviews & Details
*Goal: Relationships and Routing.*
- [ ] Add `Review` and `Rating` (1-5) columns
- [ ] Blazor Page: Book Details View (`/books/{id}`)
- [ ] Navigation: Clickable titles in the main list

---

## 🛠️ How to Run Locally

Since this uses a database, you must set up the local environment first.

**Prerequisites:**
* Visual Studio 2022 (Community Edition)
* .NET 8 SDK

**Installation Steps:**

1.  **Clone the repository** (or open the folder):
    ```bash
    git clone [https://github.com/your-username/MyReadingList.git](https://github.com/your-username/MyReadingList.git)
    ```

2.  **Database Setup:**
    Open the **Package Manager Console** in Visual Studio (View -> Other Windows -> Package Manager Console).
    Select the **API Project** as the default project and run:
    ```powershell
    Update-Database
    ```
    *This creates the `books.db` SQLite file locally.*

3.  **Run the App:**
    * Right-click the Solution in Solution Explorer.
    * Select **"Set Startup Projects"**.
    * Choose **"Multiple Startup Projects"** and set both **API** and **Client (Blazor)** to "Start".
    * Press **F5**.

---

## 📝 Learning Notes

* **Entity Framework:** Learned how to use `[Required]` data annotations to enforce database constraints.
* **API:** Learned that `[HttpGet]` and `[HttpPost]` determine how the browser talks to the server.
* *(Add more notes here as you learn!)*
