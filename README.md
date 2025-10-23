# Personal Finance Tracker (个人财务追踪器)

这是一个基于 ASP.NET Core MVC 和 Entity Framework Core (EF Core) 构建的简单 Web 应用程序，旨在帮助用户在本地追踪和管理个人收支交易记录。本项目主要用于展示 C# 后端开发、SQL 数据库操作（通过 EF Core 实现）和基本的 Web 界面设计能力。

## 🛠️ 技术栈 (Tech Stack)

| 领域 | 技术/框架 | 用途 |
| :--- | :--- | :--- |
| **后端** | C# / .NET 9 (或您使用的版本) | 核心业务逻辑 (Controller, Model) |
| **框架** | ASP.NET Core MVC | Web 应用架构 (路由, View) |
| **数据** | Entity Framework Core (EF Core) | 对象关系映射 (ORM)，用于数据库交互 |
| **数据库** | SQLite (或 MSSQL LocalDB) | 数据持久化存储 |
| **前端** | Razor Pages (`.cshtml`) | 动态 HTML 渲染 |
| **样式** | Bootstrap 5 | 响应式布局和 UI 样式 |

## ✨ 主要功能 (Features)

* **交易记录列表 (Index)：** 显示所有历史交易记录。
* **添加记录 (Create)：** 录入新的收入或支出记录。
* **删除记录 (Delete)：** 确认并移除不再需要的交易记录。
* **数据模型：** 包含 `Date`, `Description`, `Amount`, `Category` 等核心字段。
* **简洁 UI：** 采用简洁的 Apple 风格设计，专注于数据展示。

## 🚀 运行项目 (Getting Started)

要运行此项目，您需要在本地安装 [.NET SDK](https://dotnet.microsoft.com/download)。

1.  **克隆仓库：**
    ```bash
    git clone [https://github.com/helenshz/Personal-Finance-Tracker.git](https://github.com/helenshz/Personal-Finance-Tracker.git)
    cd Personal-Finance-Tracker
    ```

2.  **构建和迁移数据库：**
    * 项目使用 EF Core Code-First 模式。首次运行时，请确保数据库已创建。
    ```bash
    # 确保您已安装 dotnet ef 工具
    dotnet tool install --global dotnet-ef 
    # 创建并更新数据库结构（SQLite 文件 finance.db 将被生成）
    dotnet ef database update 
    ```

3.  **运行应用程序：**
    ```bash
    # 使用 watch 模式以便在开发时自动刷新
    dotnet watch 
    ```

4.  **访问应用：**
    * 在浏览器中打开：`http://localhost:5002` (或终端中显示的端口)

## 📌 持续更新计划 (Future Plans)

本项目将持续改进，计划添加以下功能：

* 用户认证和多用户支持。
* 月度/年度数据统计和图表可视化。
* 预算追踪功能。
* 数据导入/导出 (CSV/Excel)。

## 🤝 贡献 (Contribution)

欢迎任何改进意见或代码贡献！如果您发现 Bug 或有功能建议，请随时在 [Issues](https://github.com/helenshz/Personal-Finance-Tracker/issues) 中提出。

---
*Developed by helenshz*
