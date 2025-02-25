### MADE BY
- Avi Mahari | Nikita Sayenko | Kfir Moscovich

# UniversityApp

## Introduction
UniversityApp is a desktop application developed in C# using WinForms. The application serves as a management system for university administration, allowing users to register, search, and manage students, lecturers, and departments.

## Requirements
- Windows OS
- .NET Framework 4.8 or above
- Visual Studio (Recommended)
- Basic understanding of object-oriented programming (OOP), including classes, inheritance, abstraction, and polymorphism.

## Installation
To run the application, follow these steps:

1. Clone the repository or download the ZIP file.
2. Open the solution (`UniversityApp.sln`) in Visual Studio.
3. Build the solution using **Ctrl + Shift + B**.
4. Run the application using **F5** or the "Start" button in Visual Studio.

## Project Structure
The project is organized into several directories and files:

- **`UniversityApp.sln`** - Solution file for Visual Studio.
- **`UniversityApp/`** - Main project directory.
  - **`src/Models/`** - Contains the core models such as `User.cs`, `Student.cs`, `Lecturer.cs`, and `Department.cs`.
  - **`src/Forms/`** - Includes all WinForms UI components, such as `LoginForm.cs`, `SignUpForm.cs`, `ProfileForm.cs`, and `DepartmentManagementForm.cs`.
  - **`src/Data/`** - Stores JSON files for user and department data.
  - **`src/Utils/`** - Contains utility classes for error handling, file operations, and data processing.

## How to Run the Application
1. Ensure you have Visual Studio installed.
2. Open the solution file (`UniversityApp.sln`).
3. Build the solution (`Ctrl + Shift + B`).
4. Run the application (`F5`).
5. The application will open the main login screen.

## User Interface
Upon launching the application, users will interact with a graphical user interface built with WinForms. 

### Main Features
- **User Registration & Authentication**: Sign up and log in as a student, lecturer, or administrator.
- **User Management**: View and edit user details.
- **Department Management**: Add, edit, or remove departments and assign lecturers to courses.
- **Messaging System**: Send and receive messages within the university.
- **Search Functionality**: Search for students and faculty by name or ID.
- **Customizable Display**: Switch between light and dark mode, adjust text size.

## Functionalities
### Authentication & User Management
- **Sign Up**: Register as a new student, lecturer, or administrator.
- **Login**: Secure authentication with user credentials.
- **Edit Profile**: Update user details such as email, phone number, and department.

### Messaging System
- **Send Messages**: Communicate between students, lecturers, and administrators.
- **View Messages**: Organized inbox with sorting by date and importance.

### Department & Course Management
- **Create & Delete Departments**: Admins can add or remove departments.
- **Assign Lecturers**: Manage faculty assignments.
- **Search for Departments**: Find specific departments and view their details.

## Error Handling
The application includes error handling mechanisms for invalid inputs, missing fields, and incorrect credentials. Users will receive appropriate notifications and guidance.

## File Handling
Data persistence is managed through JSON files stored in the `src/Data/` directory. This ensures that all user information, messages, and department details are saved and reloaded upon startup.

## Conclusion
UniversityApp provides an efficient system for managing students, lecturers, and departments in a university setting. Built with C# and WinForms, the application showcases object-oriented programming concepts and practical user interface design.

---
