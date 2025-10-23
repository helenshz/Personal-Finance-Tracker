namespace FinanceTrackerApp.Data
{
    using FinanceTrackerApp.Models;
    using Microsoft.EntityFrameworkCore;

    // 继承 DbContext 是 EF Core 的要求
    public class ApplicationDbContext : DbContext
    {
        // 构造函数，用于接收配置选项（如数据库连接字符串）
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // 数据库集 (DbSet) 对应 SQL 数据库中的一个表 (Table)
        public DbSet<Transaction> Transactions { get; set; }

        // 如果您有其他模型，比如 Category，您可以在这里添加 DbSet<Category>
    }
}