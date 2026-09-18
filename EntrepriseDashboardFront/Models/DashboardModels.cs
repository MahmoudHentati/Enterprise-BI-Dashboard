namespace EntrepriseDashboardFront.Models;

public class SalesOverviewDto
{
    public decimal TotalRevenue { get; set; }
    public decimal TotalPaid { get; set; }
    public decimal UnpaidAmount { get; set; }
    public double PaymentRate { get; set; }
    public int TotalOrders { get; set; }
    public int TotalQuantity { get; set; }
}

public class MonthlyRevenueDto
{
    public int Year { get; set; }
    public int Month { get; set; }
    public string MonthName { get; set; } = string.Empty;
    public decimal Revenue { get; set; }
    public decimal Paid { get; set; }
    public int Quantity { get; set; }
}

public class CategorySalesDto
{
    public string CategoryName { get; set; } = string.Empty;
    public decimal Revenue { get; set; }
}

public class ProductSalesDto
{
    public string ProductName { get; set; } = string.Empty;
    public decimal Revenue { get; set; }
    public int Quantity { get; set; }
}

public class CustomerSegmentDto
{
    public string CategoryCode { get; set; } = string.Empty;
    public decimal Revenue { get; set; }
    public int Orders { get; set; }
}

public class CitySalesDto
{
    public string City { get; set; } = string.Empty;
    public decimal Revenue { get; set; }
    public int Orders { get; set; }
}

public class PaymentStatusDto
{
    public string Status { get; set; } = string.Empty;
    public int Count { get; set; }
    public decimal Amount { get; set; }
}

public class StockProductDto
{
    public string ProductName { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public int TotalQuantity { get; set; }
    public decimal AvgCost { get; set; }
}

public class StockMovementTypeDto
{
    public string MovementType { get; set; } = string.Empty;
    public int TotalQuantity { get; set; }
}

public class MonthlyStockDto
{
    public int Year { get; set; }
    public int Month { get; set; }
    public string MonthName { get; set; } = string.Empty;
    public string MovementType { get; set; } = string.Empty;
    public int Quantity { get; set; }
}

public class CustomerSalesDto
{
    public string CustomerName { get; set; } = string.Empty;
    public decimal Revenue { get; set; }
    public int Orders { get; set; }
}

public class PaymentMethodDto
{
    public string MethodName { get; set; } = string.Empty;
    public int Count { get; set; }
    public decimal Amount { get; set; }
}
