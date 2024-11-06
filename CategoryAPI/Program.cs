using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using CategoryAPI;
using CategoryAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register other services (if any)
var app = builder.Build();


// Seed data into the database if it doesn't exist
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.EnsureCreated(); // Ensures that the database is created (if not already)
    
    // Check if the Categories table is empty, and seed it if necessary
    if (!dbContext.Categories.Any())
    {
        dbContext.Categories.AddRange(new Category
        {
            Name = "Electronics"
        },
        new Category
        {
            Name = "Books"
        },
        new Category
        {
            Name = "Clothing"
        });

        dbContext.SaveChanges();
    }
}

// Define your endpoints
app.MapGet("/api/categories", async (AppDbContext db) =>
{
    var categories = await db.Categories.ToListAsync();
    return Results.Ok(categories);
});

app.Run();
