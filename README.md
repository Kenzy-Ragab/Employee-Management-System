# 🧑‍💼 Employee Management System (Console App)

A simple and interactive employee management application built with **C#**.
You can add, view, update, delete employees, and filter or summarize employee data using a clean, user-friendly console interface.

---
  
## 💻 Features

- ➕ **Add new employees** with detailed info (ID, Name, Age, Department, Position, Work Schedule, Salary, Address)
- 📋 **View all employees** in a neatly formatted table
- 🔄 **Update existing employee data** with option to keep current values
- ❌ **Delete employees** with confirmation prompt
- 🔍 **Filter employees** by department for easier management
- 💰 **View total salary** expenditure of all employees
- 💾 **Persistent data storage** in a local text file (`employees.txt`)
- 🛠️ **Modular design** with separation of concerns (Models, Services, Screens, Helpers)

---

## 🧱 Project Structure

```
EmployeeManagementSystem/
├── Helpers/    # Input validation and reading helpers
├── Models/     # Employee and Address data models with enums
├── Services/   # Business logic for employee management + file storage
├── Screens/    # UI screens for Add, View, Update, Delete, Main
└── Program.cs  # Application entry point
```

---

## 🛠️ Technologies Used

-  **C#** (.NET Console Application)
-  **File I/O** (System.IO)
-  **Object-Oriented Programming**
-  **Console User Interface**
-  **Clean Code Architecture** (Separation of concerns)

---

## 🚀 How to Run

1. **Clone the repository**:
   ```bash
   git clone https://github.com/YourUsername/EmployeeManagementSystem.git
   ```

2. **Open in Visual Studio or VS Code**
3. **Build and run the project**

---

## 📸 Preview

```
╔══════════════════════════════════════╗
║          MAIN MENU SCREEN            ║
╠══════════════════════════════════════╣
║[1] Add New Employee                  ║
║[2] View Employees Menu               ║
║[3] Update Employee                   ║
║[4] Delete Employee                   ║
║[5] View Total Salaries               ║
║[6] Exit                              ║
╚══════════════════════════════════════╝
```

---

## 🧠 What I Learned

- Designing modular console applications in C#
- Implementing CRUD operations with validation
- Managing persistent data using file storage
- Creating interactive console menus and user-friendly interfaces
- Structuring code cleanly with Models, Services, and Screens

---

## 📂 Example Employee Record Format (Saved in File)

```
1|John Doe|30|IT|Employee|FullTime|5000|New York|Manhattan|5th Avenue|12
2|Jane Smith|28|Finance|Manager|PartTime|6000|Los Angeles|Downtown|Sunset Blvd|8
```

---

## 📌 Future Enhancements

- 🔍 Search employees by name or ID
- 📊 Generate reports and analytics
- 📤 Export employee data to CSV or Excel
- 🔔 Add notifications for employee anniversaries or birthdays
- 🌐 Develop a GUI or web-based frontend

---

## 🤍 Task Requirement in Breakin Point (Student Activity)

[Link to Task Requirements (Google Drive)](https://drive.google.com/drive/folders/10U8n-uBXCUBl6RGIvcKfzueng_af0lCA)

Made with ❤️ by **Kenzy Ragab**
Feel free to **fork**, **use**, or **contribute** to this project!
