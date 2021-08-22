# BlazingShop

Hello and thanks for dropping by!

This is the repository for the ["Blazor WebAssembly E-Commerce Series" on YouTube](https://www.youtube.com/watch?v=ITk2MTFpiA4&list=PLF1jhYUTnHo6oK14WD3D_abbluAj0aiRb&ab_channel=PatrickGod).

And here's how you can run this application.

## 1. Install SQL Server & Entity Framework

Since we're using SQL Server Express and Entity Framework Core in this application, you have to install these first.
It's demonstrated in the series on YouTube, but you could also just search for SQL Server Express and maybe also SQL Server Management Studio and download both.
Regarding Entity Framework, we need some tools you can install with the following command in the Package Manager Console:

`dotnet tool install --global dotnet-ef`

## 2. Update the ConnectionString

In the `appsettings.json` file of the Server project, you will find the connection string to connect to your database.
If you're using SQL Server Express on the same machine then this should already work. Otherwise, I assume you know what you're doing, so don't forget to update the string.

## 3. Update the Database

To create the database with all the seeded data, make sure to change to the Server directory of this solution.

`cd .\BlazingShop\Server`

Then you can run all the migrations of EF Core or update the database, respectively.

`dotnet ef database update`

## 4. Run the Application

And finally, you can run the app.

`dotnet watch run`

Happy coding!

Patrick
