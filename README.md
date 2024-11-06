# Starter app for Create a web UI with ASP.NET Core

Welcome! This is the homework for the Challenge 02:
- Integrate with Entity Framework Core, connect with SQL Server database
- Using code first to create category model
- Seed hard-coded category data to Entity Framework Core
- Change get category endpoint from hard-coded data to retrieve data from Entity Framework Core
- Run and test endpoint with postman"	

## Completed version


## Contributing

This project welcomes contributions and suggestions.  

## Step-by-step guide to run the web app


Step 1: Set Up Your Development Environment
1. Install .NET SDK: Ensure you have the latest .NET SDK installed. You can download it from the .NET download page.
2. Install an IDE: Use Visual Studio, Visual Studio Code, or any other preferred IDE.

Step 2: Set Up the Project for Entity Framework Core
1. Install Required NuGet Packages
You need to install the following NuGet packages for Entity Framework Core:
	• Microsoft.EntityFrameworkCore.SqlServer (for SQL Server database provider)
	• Microsoft.EntityFrameworkCore.Tools (for EF Core tools)
	• Microsoft.EntityFrameworkCore.Design (for design-time support)
Open your terminal and run the following commands in your project folder:
	dotnet add package Microsoft.EntityFrameworkCore --version 8.0.2
	dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.2
	dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.2
These packages will allow us to interact with SQL Server and run migrations for creating the database schema.

Step 3: Configure the Database Connection
You need to update your connection string for your SQL Server instance (replace the Server name and Database name) in the appsettings.json file.
Make sure that your SQL Server instance is running and you have a database named 'master' (or you can change the name in the connection string).

Step 4: Create and Apply Migrations
Entity Framework uses migrations to generate and update the database schema based on the models.
1. Add Initial Migration
Run the following commands in your terminal to create the first migration, which will generate the necessary SQL to create the Categories table in the database.
	dotnet ef migrations add InitialCreate
This command will generate migration files in the Migrations folder. It will also include the SQL code needed to create the Categories table.
2. Apply the Migration to the Database
Next, apply the migration to create the Categories table in the SQL Server database.	
	dotnet ef database update
This will create the CategoryDb database (if it doesn’t already exist) and the Categories table.

Step 5: Test the API Endpoint
	1. Run the Application:
		○ Open the terminal in your project folder and run:	dotnet run
		○ The application should now be running with the connection to the SQL Server database.
	2. Test the Endpoint with Postman:
		○ Open Postman and create a new GET request to http://localhost:5000/api/categories.(you should replace 5000 by the port that your system is listening on
		○ You should see the list of categories returned from the database, not the hard-coded list.
