using ProductsandCategories.Models; // Project name
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddHttpContextAccessor();  // AddHttpContextAccessor gives our views direct access to session so that session data doesn't need to be repeatedly passed into the ViewBag.
builder.Services.AddSession();  // add this line before calling the builder.Build() method

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
// Adds database connection - must be before app.Build();
builder.Services.AddDbContext<MyContext>(options =>  //dbnameContext 
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSession();    // add this line before calling the app.MapControllerRoute() method

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();