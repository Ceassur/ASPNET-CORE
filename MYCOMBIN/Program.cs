using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MYCOMBIN.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Uygulama ayağa kalkarken buradaki verilen işlemler ile çalışır.
builder.Services.AddDbContext<DataContext>( 
    
    options => {
        var confing = builder.Configuration;
        var connectionstring = confing.GetConnectionString("database");
        options.UseSqlServer(connectionstring);
    }
);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{Id?}");

app.Run();
