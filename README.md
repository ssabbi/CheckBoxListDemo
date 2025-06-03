# CheckBoxListDemo

This project is an ASP.NET MVC 5 sample application that demonstrates editing movies with selectable genres using checkbox lists. The solution targets **.NET Framework 4.5** and was originally created with **Visual Studio 2013**.

## Projects

- `CheckBoxListDemo.Web` – main MVC web application
- `CheckBoxListDemo.Lib` – auxiliary library project (currently contains only assembly metadata)

NuGet packages are stored under the `packages/` folder.

## Building

1. Restore NuGet packages:
   ```bash
   nuget restore CheckBoxListDemo.sln
   ```
   or with MSBuild:
   ```bash
   msbuild CheckBoxListDemo.sln -t:Restore
   ```
2. Build the solution:
   ```bash
   msbuild CheckBoxListDemo.sln
   ```

`msbuild` and `nuget` must be available in your environment (e.g., from a Visual Studio Developer Command Prompt). The solution may also be opened directly in Visual Studio.

## Running

After building, run `CheckBoxListDemo.Web` using Visual Studio or any IIS/IIS Express host. The web project uses a LocalDB database located in `App_Data/Movies.mdf` which is configured in `Web.config` under the `MovieEntities` connection string.

### Login Page

A basic login form is available at `/Login` and is handled by `LoginController`. The login check uses an in-memory credential set (`admin` / `password`) for demonstration only. Successful logins redirect to the movie list.

## Repository Contents

- **Controllers** – MVC controllers for movies and login
- **ViewModels** – View models used by Razor views
- **Views** – Razor views including editor templates
- **DataAccess** – Entity Framework models and data managers
- **Scripts** and **Content** – JavaScript and CSS assets (Bootstrap, jQuery, etc.)

## Notes

This repository does not include automated tests. Building the project requires a Windows environment with the .NET Framework SDK. The login page is not intended for production use; add a proper authentication mechanism for real deployments.

