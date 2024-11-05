using MinimalAPI.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
var categories = new List<Category>
{
    new Category { ID = 1, Name = "Toys" },
    new Category { ID = 2, Name = "Food" },
    new Category { ID = 3, Name = "Clothing" }
};

app.MapGet("/categories", () => categories)
.WithName("GetCategories");

app.Run();
