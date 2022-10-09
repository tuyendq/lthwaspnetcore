
[Get started with ASP.NET Core MVC](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio-code)

- ASP.NET Core 6 
- Visual Studio Code 

```powershell

# Get started
dotnet new mvc -o Movie.Mvc
cd $$
ni -Type File README.md
dotnet build
dotnet run

# Add Controller
ni -Type File .\Controllers\HelloWorldController.cs


# Add View
ni -Force -Type File .\Views\HelloWorld\Index.cshtml
ni -Force -Type File .\Views\HelloWorld\Welcome.cshtml

# Add Model
ni -Type File .\Models\Movie.cs



dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer


# Scaffold movie pages
dotnet-aspnet-codegenerator controller -name MoviesController -m Movie -dc MovieMvcContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite


```