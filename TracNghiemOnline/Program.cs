using Microsoft.EntityFrameworkCore;
using TracNghiemOnline.EFReponsitory;
using TracNghiemOnline.Models;
using TracNghiemOnline.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString =
builder.Configuration.GetConnectionString("WebsiteBanHangConnection");
builder.Services.AddDbContext<TracNghiemOnlineContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<ILophocRepository, EFLophocRepository>();
builder.Services.AddScoped<IMonhocRepository, EFMonhocRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
