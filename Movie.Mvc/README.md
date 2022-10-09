
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

```