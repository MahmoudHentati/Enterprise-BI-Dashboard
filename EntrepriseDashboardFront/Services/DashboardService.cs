using System.Net.Http.Json;
using EntrepriseDashboardFront.Models;

namespace EntrepriseDashboardFront.Services;

public class DashboardService
{
    private readonly HttpClient _http;

    public DashboardService(HttpClient http) => _http = http;

    public async Task<SalesOverviewDto?> GetSalesOverviewAsync()
    {
        try { return await _http.GetFromJsonAsync<SalesOverviewDto>("api/cube/sales-overview"); }
        catch { return new SalesOverviewDto(); }
    }

    public async Task<List<MonthlyRevenueDto>> GetSalesByMonthAsync()
    {
        try { return await _http.GetFromJsonAsync<List<MonthlyRevenueDto>>("api/cube/sales-by-month") ?? []; }
        catch { return []; }
    }

    public async Task<List<CategorySalesDto>> GetSalesByCategoryAsync()
    {
        try { return await _http.GetFromJsonAsync<List<CategorySalesDto>>("api/cube/sales-by-category") ?? []; }
        catch { return []; }
    }

    public async Task<List<ProductSalesDto>> GetTopProductsAsync()
    {
        try { return await _http.GetFromJsonAsync<List<ProductSalesDto>>("api/cube/top-products") ?? []; }
        catch { return []; }
    }

    public async Task<List<CustomerSegmentDto>> GetCustomerSegmentsAsync()
    {
        try { return await _http.GetFromJsonAsync<List<CustomerSegmentDto>>("api/cube/customer-segments") ?? []; }
        catch { return []; }
    }

    public async Task<List<CitySalesDto>> GetSalesByCityAsync()
    {
        try { return await _http.GetFromJsonAsync<List<CitySalesDto>>("api/cube/sales-by-city") ?? []; }
        catch { return []; }
    }

    public async Task<List<PaymentStatusDto>> GetPaymentStatusAsync()
    {
        try { return await _http.GetFromJsonAsync<List<PaymentStatusDto>>("api/cube/payment-status") ?? []; }
        catch { return []; }
    }

    public async Task<List<PaymentMethodDto>> GetPaymentMethodsAsync()
    {
        try { return await _http.GetFromJsonAsync<List<PaymentMethodDto>>("api/cube/payment-methods") ?? []; }
        catch { return []; }
    }

    public async Task<List<StockProductDto>> GetStockOverviewAsync()
    {
        try { return await _http.GetFromJsonAsync<List<StockProductDto>>("api/cube/stock-overview") ?? []; }
        catch { return []; }
    }

    public async Task<List<StockMovementTypeDto>> GetStockByMovementTypeAsync()
    {
        try { return await _http.GetFromJsonAsync<List<StockMovementTypeDto>>("api/cube/stock-by-movement-type") ?? []; }
        catch { return []; }
    }

    public async Task<List<MonthlyStockDto>> GetStockByMonthAsync()
    {
        try { return await _http.GetFromJsonAsync<List<MonthlyStockDto>>("api/cube/stock-by-month") ?? []; }
        catch { return []; }
    }

    public async Task<List<ProductSalesDto>> GetTopProductsDynamicAsync(int n)
    {
        try { return await _http.GetFromJsonAsync<List<ProductSalesDto>>($"api/cube/top-products-dynamic?n={n}") ?? []; }
        catch { return []; }
    }

    public async Task<List<CustomerSalesDto>> GetTopCustomersDynamicAsync(int n)
    {
        try { return await _http.GetFromJsonAsync<List<CustomerSalesDto>>($"api/cube/top-customers-dynamic?n={n}") ?? []; }
        catch { return []; }
    }
}
