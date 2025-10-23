// Models/Transaction.cs
namespace FinanceTrackerApp.Models;

using System;
using System.ComponentModel.DataAnnotations;

public class Transaction
{
    // 交易ID，将成为主键 (Primary Key)
    public int Id { get; set; }

    // 交易类型：收入 (Income) 或 支出 (Expense)
    [Required]
    public required string Type { get; set; } 

    // 交易描述
    [Required]
    public required string Description { get; set; }

    // 交易金额
    public decimal Amount { get; set; }

    // 交易日期
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy.MM.dd}", ApplyFormatInEditMode = true)]
    public DateTime Date { get; set; } = DateTime.Now;

    // 交易分类，作为外键（Foreign Key）的补充
    public string? Category { get; set; } 
}