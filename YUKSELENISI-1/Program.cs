using Microsoft.EntityFrameworkCore;
using YUKSELENISI_1.Data;

var builder = WebApplication.CreateBuilder(args);

// appsettings.json'daki baðlantý dizesini oku
var connectionString = builder.Configuration.GetConnectionString("YukselenIsiDb");

// DbContext'i SQL Server saðlayýcýsýyla DI konteynerine kaydet
builder.Services.AddDbContext<YukselenisiDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();