using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using FinanceTrackerApp.Data; // 确保添加这行来引用您的 Data 命名空间

var builder = WebApplication.CreateBuilder(args);


// 配置 SQLite 数据库连接
// 1. 获取连接字符串
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? 
    "DataSource=app.db"; // 如果配置中没有，则使用 app.db 文件

// 2. 注册 DbContext 服务
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
