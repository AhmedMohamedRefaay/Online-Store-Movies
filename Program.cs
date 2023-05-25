using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Online__Store_Movies.Models.Domain;
using Online__Store_Movies.Repository.Abstract;
using Online__Store_Movies.Repository.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MoviesDb>(
    option => option.UseSqlServer(builder.Configuration.GetConnectionString("MoviesDataBase"))
    );

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<MoviesDb>().AddDefaultTokenProviders();

builder.Services.AddScoped<IUserAuthntication, UserAuthntication>();

builder.Services.AddScoped<IGenereService, GenereService>();
//builder.Services.ConfigureApplicationCookie(option => option.LoginPath = "/UserAuthntication/login");
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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
