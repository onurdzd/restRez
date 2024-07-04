using Microsoft.EntityFrameworkCore;
using RestoranRezervasyon.Models;

var builder = WebApplication.CreateBuilder(args);

// DbContext'i servis koleksiyonuna ekleyin
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// MVC servisini ekleyin
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Middleware yapılandırması
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Varsayılan rota yapılandırması
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    
app.MapControllerRoute(
    name: "customer",
    pattern: "Customer/{action=Index}/{id?}",
    defaults: new { controller = "Customer" });

app.MapControllerRoute(
    name: "reservation",
    pattern: "Reservation/{action=Index}/{id?}",
    defaults: new { controller = "Reservation" });

app.Run();
