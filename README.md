# .NET 6 HR Management System

## Objectives

The main objective was to track employee leave.

- Track types of employee leave (sick, vacation, etc.)
- Let employees see how much leave they are allocated and leave remaining
- Allow admin to approve or reject request of leave

### Development
- ASP.NET Core
- Entity Framework Core
- C# and .Net Core Web Syntax
- MVC (Models, Views and Controllers) Pattern
- Repository and Unit Of Work Patterns and Dependency Injection
- User Authentication using ASP.NET Core Identity
- Manage Packages with NuGet Manager
- Bootstrap to style and manipulate the overall layout
- Implemented Website Layout using bootstrap theme

### App on Azure
[Live Link](hrmanagementweb20230818105522.azurewebsites.net)

- Login using: Username: admin@localhost.com | Password: P@ssword1

Registration will not work on deployed app.  If you want to test functionality download locally.

### To Configure For Local Use
Clone Repository To Local Computer
Open Project in Visual Studio
In HRManagementWeb/appsettings.json edit "DefaultConnection" to point to preferred database
Open Package Console Manager and run the command "Update-Database"
Download Papercut SMPT
When completed hit Control+F5 to run application

Future Feature
- Track employee hours 
