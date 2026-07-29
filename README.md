<h1 align="center">
  <br>
  Rudrani's Library Management System (LMSystem)
  <br>
</h1>

<h4 align="center">A premium, web-based Library Management application built with ASP.NET Core 8 MVC and Entity Framework Core.</h4>

<p align="center">
  <a href="#features">Features</a> •
  <a href="#tech-stack">Tech Stack</a> •
  <a href="#screenshots">Screenshots</a> •
  <a href="#how-to-run">How To Run</a>
</p>

---

## 🌟 Overview

The **Library Management System (LMSystem)** is an advanced digital solution developed to automate and streamline the operations of a modern library. It provides a seamless, highly responsive, and visually stunning web interface designed with a premium **Dark Pink & White aesthetic**. 

The system efficiently tracks books, students, librarians, publications (newspapers/magazines), and library circulation (borrow/return) while providing administrators with real-time data visualizations via an interactive dashboard.

## ✨ Features

- **🔒 Secure Authentication:** Session-based user login to protect administrative operations.
- **📊 Real-time Dashboard:** Interactive Chart.js data visualizations for library inventory and borrowing trends.
- **📚 Book Circulation Management:** Automated borrow and return workflows that instantly update book availability.
- **👥 User Profiles:** Manage Student and Librarian records with dedicated profile cards and server-side search.
- **📰 Publication Tracking:** Unified management for daily Newspapers and monthly Magazines using enum discriminators.
- **🎨 Premium UI/UX:** Responsive Bootstrap 5 card-grid layouts replacing outdated HTML tables, with CSS hover micro-animations.

## 🛠️ Tech Stack

- **Backend:** C# / ASP.NET Core 8 MVC
- **Database:** SQLite & Entity Framework Core 8 (Code-First)
- **Frontend:** HTML5, CSS3, Bootstrap 5.3
- **Data Visualization:** Chart.js 4
- **Typography & Icons:** Google Fonts (Outfit), Bootstrap Icons

---

## 📸 Screenshots

Here is a look at the application's premium user interface:

### 1. Secure Login Page
![Login](screenshots/01_login.png)

### 2. Analytics Dashboard
![Dashboard](screenshots/02_dashboard.png)

### 3. Books Catalog
![Books](screenshots/03_books.png)

### 4. Student Directory
![Students](screenshots/04_students.png)

### 5. Librarian Management
![Librarians](screenshots/05_librarians.png)

### 6. Newspapers Collection
![Newspapers](screenshots/06_newspapers.png)

### 7. Magazines Collection
![Magazines](screenshots/07_magazines.png)

---

## 🚀 How To Run

Follow these step-by-step instructions to get the project running on your local machine.

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed on your machine.
- Visual Studio 2022 or Visual Studio Code.
- Git (optional).

### Step 1: Open the Project
Open your terminal or command prompt and navigate to the project directory:
```bash
cd "path/to/rudrani project/LMSystem"
```

### Step 2: Restore Dependencies
Restore all the necessary NuGet packages:
```bash
dotnet restore
```

### Step 3: Apply Database Migrations (Optional)
The project comes with an existing SQLite database file (`library.db`). If you need to recreate the database from scratch, run:
```bash
dotnet ef database update
```

### Step 4: Run the Application
Start the local development server:
```bash
dotnet run
```

### Step 5: Access the Web App
1. Open your web browser (Chrome/Edge/Firefox).
2. Navigate to the local URL provided in the terminal (usually `http://localhost:5074`).
3. Use the following credentials to log in:
   - **Username / Email:** `admin`
   - **Password:** `12345`

---

<p align="center">
  <b>Developed by Rudrani Sarkar</b><br>
  <i>Advance Software Engineering, MPOnline Internship</i>
</p>
