using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using TraversalCoreProject.Models;
using BusinessLayer.Container;
using Serilog;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddLogging(x =>
{
    x.ClearProviders();
    x.SetMinimumLevel(LogLevel.Error);
    x.AddDebug();
});

builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>()
    .AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<Context>();


builder.Services.AddHttpClient();

builder.Services.AddControllersWithViews();

builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.ContainerDependencies();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.RegisterValidator();

builder.Services.AddMvc();
//builder.Services.Configure<IdentityOptions>(options => {
//	options.Password.RequiredLength = 6;
//	options.Password.RequireLowercase = false;
//	options.Password.RequireUppercase = false;
//	options.Password.RequireDigit = false;
//	options.Password.RequireNonAlphanumeric = false;

//	options.User.RequireUniqueEmail = true;

//	options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
//	options.Lockout.MaxFailedAccessAttempts = 5;



//});
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login/SingIn";
});


builder.Logging.ClearProviders(); // Önceki log saðlayýcýlarýný temizle

builder.Logging.AddSerilog(new LoggerConfiguration()
    .WriteTo.File("Logs/Lo1.txt") // Loglarý dosyaya yaz
    .CreateLogger());

var app = builder.Build(); 



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();

app.UseRouting();

app.UseCors();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});


app.Run();
