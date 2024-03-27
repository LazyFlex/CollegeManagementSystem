using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CollegeManagementSystem.Areas.Staff.Models;
using CollegeManagementSystem.Areas.Student.Models;
using CollegeManagementSystem.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Builder;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


var connectionStringCollege = builder.Configuration.GetConnectionString("CollegeContext") ?? throw new InvalidOperationException("Connection string 'CollegeContext' not found.");

builder.Services.AddDbContext<CollegeContext>(options => options.UseSqlServer(connectionStringCollege));

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
}).AddEntityFrameworkStores<CollegeContext>();

builder.Services.AddIdentityCore<Staff>().AddEntityFrameworkStores<CollegeContext>();
builder.Services.AddIdentityCore<Student>().AddEntityFrameworkStores<CollegeContext>();






builder.Services.AddRazorPages();


var app = builder.Build();


app.UseAuthorization();

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



app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
