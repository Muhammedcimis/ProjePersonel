using Microsoft.EntityFrameworkCore;
using PersonelProjesi.Controllers;
using PersonelProjesiBusiness.Core;
using PersonelProjesiBusiness.Services;
using PersonelProjesiDataAccess;
using PersonelProjesiDataAccess.Core;
using PersonelProjesiDataAccess.Repository;
using PersonelProjesiDataAccess.UnitOfWork;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnection"),
       sqlOptions => sqlOptions.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName))
);

builder.Services.AddHttpClient<PersonelController>();
builder.Services.AddHttpClient<PersonelService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IPersonelRepository), typeof(PersonelRepository));
builder.Services.AddScoped(typeof(IService<>), typeof(BaseService<>));
builder.Services.AddScoped(typeof(IPersonelService), typeof(PersonelService));

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
