using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Projet_Biblio.DbContext;
using Projet_Biblio.Extensions;
using Projet_Biblio.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//Custom Services 
builder.Services.AddPersistenceServices(); 


var connectionString = builder.Configuration.GetConnectionString("biblioConnectionString");

builder.Services.AddDbContext<BiblioDbContext>(options => options.UseSqlServer(connectionString)); // Connect to the sqlServer using a connectionString
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<BiblioDbContext>();   

builder.Services.AddRazorPages();

#region Session 
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(3);
    options.Cookie.HttpOnly = true;
});

#endregion

#region Authentication Services 

builder.Services.Configure<IdentityOptions>(options =>
{
    // This section allow to set Password
    options.Password.RequireDigit = false; 
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 2;
    options.Password.RequiredUniqueChars = 0;

    // Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    // User settings.
    options.User.AllowedUserNameCharacters =
    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true; 

});


#endregion

#region Cookie Authentication  
builder.Services.ConfigureApplicationCookie(options =>
{
    //Cookie settings 
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromHours(3);
    options.LoginPath = "/Account/Login"; // Once the section expired where to redirect the user
    options.SlidingExpiration = true;

});
#endregion 

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseMiddleware<LogoutMiddleware>();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
