# 💍 MarriageRegistrationApp

MarriageRegistrationApp is a Blazor Server-based web application designed to streamline civil marriage registration and record management. It enables users to register new marriages, view existing records, and perform updates or deletions—all within a responsive and user-friendly interface.

---

## ✨ Features

- Register new marriages with validated form inputs  
- View all marriage records in a searchable table  
- Edit, view details, or delete existing records  
- Form validation using DataAnnotations  
- Navigation menu with active page highlighting  
- Bootstrap styling with icon-enhanced UI  
- Redirect and feedback after successful registration  

---

## 🛠️ Tech Stack

- **Frontend**: Blazor Server (Razor Components)  
- **Backend**: ASP.NET Core  
- **Language**: C# (.NET 8)  
- **Database**: SQL Server via Entity Framework Core  
- **Styling**: Bootstrap 5 + Bootstrap Icons  
- **Data Access**: DbContextFactory for scoped EF operations  

---

## 📂 Folder Structure

- `Pages/` — Razor components like CreateMarriage, EditMarriage, MarriageRecords  
- `Models/` — Marriage.cs model with validation attributes  
- `Data/` — EF Core DbContext setup  
- `Shared/` — Layout and navigation components  
- `wwwroot/css/` — Custom styling and theme overrides  
- `appsettings.json` — Configuration file for database connection  
- `_Host.cshtml` — Layout and head section for Blazor Server setup  

---

## 🖼️ UI Overview

- **Sidebar Navigation**:  
  - 📋 Marriage Records  
  - ➕ Register Marriage  

- **Form Fields**:  
  - Partner One  
  - Partner Two  
  - Marriage Date  
  - Status  

- **Table Columns**:  
  - Groom  
  - Bride  
  - Marriage Date  
  - Status  
  - Actions: ✏️ Edit | 🔍 Details | 🗑️ Delete  

- **Buttons**:  
  - Register New Marriage (with icon)  
  - Back to Records  

- **Styling**:  
  - Purple-themed Bootstrap cards and buttons  
  - Input focus glow  
  - Validation messages in red  
  - Icons from Bootstrap Icons for enhanced UX  

---

## 👩‍💻 Author

Built by [Birori Sonia](https://github.com/soniabirori) — Software Engineering student at AUCA, passionate about building practical management systems and exploring AI, data science, and cloud-native technologies.

---

## 📄 License

This project is open-source and free to use under the MIT License.
