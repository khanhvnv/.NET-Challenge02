# Starter app for Create a web UI with ASP.NET Core

Welcome! This is the homework for the Challenge 01:
- Create a new .Net Core minimal API
- Create a new class model Category (ID, Name)
- Create one endpoint to get category data (hard-coded data)
- Run and test endpoint with postman

## Completed version


## Contributing

This project welcomes contributions and suggestions.  

## Step-by-step guide to run the web app


Step 1: Set Up Your Development Environment
1. Install .NET SDK: Ensure you have the latest .NET SDK installed. You can download it from the .NET download page.
2. Install an IDE: Use Visual Studio, Visual Studio Code, or any other preferred IDE.

Step 2: Run Your API
1. In your terminal, run the following command to start the application:

	dotnet run

2. Open your browser and navigate to  http://localhost:5000/categories (you can replace 5000 by the port specified in your terminal) to see the list of categories.

## Run and test endpoint with postman

Step 1: Open Postman and Create a New Request
1. Open Postman.
2. Click on the New button and select HTTP Request.

Step 2: Configure the Request
1. Set the request type to GET.
2. Enter the URL for your endpoint, for example: http://localhost:5000/categories.
3. Click on the Send button.

Step 3: View the Response
1. After clicking Send, you should see the response from your API in the lower section of Postman.
2. The response should be a JSON array of your Category objects, like this:

[
{
"id": 1,
"name": "Toys"
},
{
"id": 2,
"name": "Food"
},
{
"id": 3,
"name": "Clothing"
}
]
