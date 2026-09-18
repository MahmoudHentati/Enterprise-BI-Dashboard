namespace EntrepriseDashboard.Models;

// ── Ventes Globales ─────────────────────────────────────────────────────────

public class SalesOverviewDto
{
    public decimal TotalRevenue { get; set; }
    public decimal TotalPaid { get; set; }
    public decimal UnpaidAmount { get; set; }
    public double PaymentRate { get; set; }
    public int TotalOrders { get; set; }
    public int TotalQuantity { get; set; }
}

// ── Ventes par Mois ──────────────────────────────────────────────────────────

public class MonthlyRevenueDto
{
    public int Year { get; set; }
    public int Month { get; set; }
    public string MonthName { get; set; } = string.Empty;
    public decimal Revenue { get; set; }
    public decimal Paid { get; set; }
    public int Quantity { get; set; }
}

// ── Ventes par Catégorie ──────────────────────────────────────────────────────

public class CategorySalesDto
{
    public string CategoryName { get; set; } = string.Empty;
    public decimal Revenue { get; set; }
}

// ── Top Produits ──────────────────────────────────────────────────────────────

public class ProductSalesDto
{
    public string ProductName { get; set; } = string.Empty;
    public decimal Revenue { get; set; }
    public int Quantity { get; set; }
}

// ── Segments Clients (VIP / Regular) ─────────────────────────────────────────

public class CustomerSegmentDto
{
    public string CategoryCode { get; set; } = string.Empty;
    public decimal Revenue { get; set; }
    public int Orders { get; set; }
}

// ── Ventes par Ville ──────────────────────────────────────────────────────────

public class CitySalesDto
{
    public string City { get; set; } = string.Empty;
    public decimal Revenue { get; set; }
    public int Orders { get; set; }
}

// ── Statut Paiement ───────────────────────────────────────────────────────────

public class PaymentStatusDto
{
    public string Status { get; set; } = string.Empty;
    public int Count { get; set; }
    public decimal Amount { get; set; }
}

// ── Stock Produits ────────────────────────────────────────────────────────────

public class StockProductDto
{
    public string ProductName { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public int TotalQuantity { get; set; }
    public decimal AvgCost { get; set; }
}

// ── Type de Mouvement Stock ───────────────────────────────────────────────────

public class StockMovementTypeDto
{
    public string MovementType { get; set; } = string.Empty;
    public int TotalQuantity { get; set; }
}

// ── Stock par Mois ────────────────────────────────────────────────────────────

public class MonthlyStockDto
{
    public int Year { get; set; }
    public int Month { get; set; }
    public string MonthName { get; set; } = string.Empty;
    public string MovementType { get; set; } = string.Empty;
    public int Quantity { get; set; }
}

// ── Top Clients ──────────────────────────────────────────────────────────────

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
