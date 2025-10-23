using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinanceTrackerApp.Data; // 确保引用您的 DbContext 命名空间
using FinanceTrackerApp.Models; // 确保引用您的 Transaction 模型命名空间

namespace FinanceTrackerApp.Controllers
{
    // Controller 名称必须以 "Controller" 结尾，路由会识别 "Transactions" 部分
    public class TransactionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        // 构造函数：注入 DbContext
        public TransactionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Transactions
        public async Task<IActionResult> Index()
        {
            // 使用 LINQ/EF Core 从数据库中获取所有交易记录，并传递给视图
            return View(await _context.Transactions.ToListAsync());
        }

        // 您还需要添加其他动作方法，如 Create, Edit, Delete。

        // GET: Transactions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transactions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Description,Amount,Date,Category")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); // 创建成功后返回列表页
            }
            return View(transaction);
        }

        // 关键：方法名必须是 Delete，参数必须是 int? id 或 int id
        public async Task<IActionResult> Delete(int? id)
        {
            // 1. 检查传入的 ID 是否为空，以及 DbContext 是否初始化成功
            if (id == null || _context.Transactions == null)
            {
                // 如果 ID 为空或者 DbSet 不可用，返回 404 错误
                return NotFound();
            }

            // 2. 根据 ID 从数据库中查找对应的交易记录
            var transaction = await _context.Transactions
                // FirstOrDefaultAsync 尝试找到匹配的记录，如果没有则返回 null
                .FirstOrDefaultAsync(m => m.Id == id);

            // 3. 检查记录是否存在
            if (transaction == null)
            {
                // 如果数据库中找不到该 ID 对应的记录，返回 404 错误
                return NotFound();
            }

            // 4. 将找到的记录传递给 'Delete.cshtml' 视图，以显示确认信息
            return View(transaction);
        }
        

        // [ActionName("Delete")] 确保它匹配 /Transactions/Delete 路由
        [HttpPost, ActionName("Delete")] 
        [ValidateAntiForgeryToken] 
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // ... (完整的 DeleteConfirmed POST 方法代码) ...
            if (_context.Transactions == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Transactions' is null.");
            }
            
            var transaction = await _context.Transactions.FindAsync(id);
            
            if (transaction != null)
            {
                _context.Transactions.Remove(transaction); 
                await _context.SaveChangesAsync(); 
            }
            
            return RedirectToAction("Index", "Transactions");
        }        
        // 更多 CRUD 方法（Edit, Details, Delete）...
    }
}