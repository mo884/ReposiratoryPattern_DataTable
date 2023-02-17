using Microsoft.EntityFrameworkCore;
using ReposiratoryPattern.BL.Interface;
using ReposiratoryPattern.BL.Mapper;
using ReposiratoryPattern.BL.Reposiratory;
using ReposiratoryPattern.DAL.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Enhancement ConnectionString
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DBApplication>(options =>
options.UseSqlServer(connectionString));

//Reposoratory Patteren
//AddScope 
builder.Services.AddScoped(typeof(IBaseReposaratory<>),typeof(BaseReposaratory<>));


//Auto Mapper
builder.Services.AddAutoMapper(x => x.AddProfile(new DomainProfile()));



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
