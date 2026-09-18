using Microsoft.AspNetCore.Mvc;
using EntrepriseDashboard.Services;

namespace EntrepriseDashboard.Controllers;

/// <summary>
/// Contrôleur REST exposant les données du cube SSAS EnterpriseCube
/// via requêtes MDX (MultiDimensional Expression).
/// </summary>
[ApiController]
[Route("api/cube")]
public class CubeController : ControllerBase
{
    private readonly CubeAnalysisService _cubeAnalysis;
    private readonly ILogger<CubeController> _logger;

    public CubeController(CubeAnalysisService cubeAnalysis, ILogger<CubeController> logger)
    {
        _cubeAnalysis = cubeAnalysis;
        _logger = logger;
    }

    /// <summary>
    /// Récupère un aperçu des ventes : CA total, montant payé, taux de paiement, etc.
    /// </summary>
    [HttpGet("sales-overview")]
    public async Task<IActionResult> GetSalesOverview()
    {
        try 
        { 
            var data = await _cubeAnalysis.GetSalesOverviewAsync();
            _logger.LogInformation("? GetSalesOverview - Data retrieved from SSAS cube");
            return Ok(data); 
        }
        catch (Exception ex) 
        { 
            _logger.LogError(ex, "? GetSalesOverview - Error querying SSAS cube");
            return StatusCode(500, new { error = ex.Message }); 
        }
    }

    /// <summary>
    /// Récupère les ventes par mois (CA et montant payé).
    /// </summary>
    [HttpGet("sales-by-month")]
    public async Task<IActionResult> GetSalesByMonth()
    {
        try 
        { 
            var data = await _cubeAnalysis.GetSalesByMonthAsync();
            _logger.LogInformation("? GetSalesByMonth - Data retrieved from SSAS cube");
            return Ok(data); 
        }
        catch (Exception ex) 
        { 
            _logger.LogError(ex, "? GetSalesByMonth - Error querying SSAS cube");
            return StatusCode(500, new { error = ex.Message }); 
        }
    }

    /// <summary>
    /// Récupère les ventes par catégorie de produits.
    /// </summary>
    [HttpGet("sales-by-category")]
    public async Task<IActionResult> GetSalesByCategory()
    {
        try 
        { 
            var data = await _cubeAnalysis.GetSalesByCategoryAsync();
            _logger.LogInformation("? GetSalesByCategory - Data retrieved from SSAS cube");
            return Ok(data); 
        }
        catch (Exception ex) 
        { 
            _logger.LogError(ex, "? GetSalesByCategory - Error querying SSAS cube");
            return StatusCode(500, new { error = ex.Message }); 
        }
    }

    /// <summary>
    /// Récupère les 10 meilleurs produits par chiffre d'affaires.
    /// </summary>
    [HttpGet("top-products")]
    public async Task<IActionResult> GetTopProducts([FromQuery] int topN = 10)
    {
        try 
        { 
            var data = await _cubeAnalysis.GetTopProductsAsync(topN);
            _logger.LogInformation("? GetTopProducts - Data retrieved from SSAS cube");
            return Ok(data); 
        }
        catch (Exception ex) 
        { 
            _logger.LogError(ex, "? GetTopProducts - Error querying SSAS cube");
            return StatusCode(500, new { error = ex.Message }); 
        }
    }

    /// <summary>
    /// Récupère les segments clients (VIP, Standard, etc.).
    /// </summary>
    [HttpGet("customer-segments")]
    public async Task<IActionResult> GetCustomerSegments()
    {
        try 
        { 
            var data = await _cubeAnalysis.GetCustomerSegmentsAsync();
            _logger.LogInformation("? GetCustomerSegments - Data retrieved from SSAS cube");
            return Ok(data); 
        }
        catch (Exception ex) 
        { 
            _logger.LogError(ex, "? GetCustomerSegments - Error querying SSAS cube");
            return StatusCode(500, new { error = ex.Message }); 
        }
    }

    /// <summary>
    /// Récupère les top clients dynamiquement.
    /// </summary>
    [HttpGet("top-customers-dynamic")]
    public async Task<IActionResult> GetTopCustomersDynamic([FromQuery] int n = 10)
    {
        try 
        { 
            var data = await _cubeAnalysis.GetTopCustomersDynamicAsync(n);
            _logger.LogInformation("? GetTopCustomersDynamic - Data retrieved from SSAS cube");
            return Ok(data); 
        }
        catch (Exception ex) 
        { 
            _logger.LogError(ex, "? GetTopCustomersDynamic - Error querying SSAS cube");
            return StatusCode(500, new { error = ex.Message }); 
        }
    }

    /// <summary>
    /// Récupère les ventes par ville.
    /// </summary>
    [HttpGet("sales-by-city")]
    public async Task<IActionResult> GetSalesByCity()
    {
        try 
        { 
            var data = await _cubeAnalysis.GetSalesByCityAsync();
            _logger.LogInformation("? GetSalesByCity - Data retrieved from SSAS cube");
            return Ok(data); 
        }
        catch (Exception ex) 
        { 
            _logger.LogError(ex, "? GetSalesByCity - Error querying SSAS cube");
            return StatusCode(500, new { error = ex.Message }); 
        }
    }

    /// <summary>
    /// Récupère le statut des paiements (Payé, En attente, Retard, etc.).
    /// </summary>
    [HttpGet("payment-status")]
    public async Task<IActionResult> GetPaymentStatus()
    {
        try 
        { 
            var data = await _cubeAnalysis.GetPaymentStatusAsync();
            _logger.LogInformation("? GetPaymentStatus - Data retrieved from SSAS cube");
            return Ok(data); 
        }
        catch (Exception ex) 
        { 
            _logger.LogError(ex, "? GetPaymentStatus - Error querying SSAS cube");
            return StatusCode(500, new { error = ex.Message }); 
        }
    }

    /// <summary>
    /// Récupère les méthodes de paiement utilisées.
    /// </summary>
    [HttpGet("payment-methods")]
    public async Task<IActionResult> GetPaymentMethods()
    {
        try 
        { 
            var data = await _cubeAnalysis.GetPaymentMethodsAsync();
            _logger.LogInformation("⏳ GetPaymentMethods - Data retrieved/calculated");
            return Ok(data); 
        }
        catch (Exception ex) 
        { 
            _logger.LogError(ex, "⏳ GetPaymentMethods - Error");
            return StatusCode(500, new { error = ex.Message }); 
        }
    }

    /// <summary>
    /// Récupère l'aperçu des stocks.
    /// </summary>
    [HttpGet("stock-overview")]
    public async Task<IActionResult> GetStockOverview()
    {
        try 
        { 
            var data = await _cubeAnalysis.GetStockOverviewAsync();
            _logger.LogInformation("? GetStockOverview - Data retrieved from SSAS cube");
            return Ok(data); 
        }
        catch (Exception ex) 
        { 
            _logger.LogError(ex, "? GetStockOverview - Error querying SSAS cube");
            return StatusCode(500, new { error = ex.Message }); 
        }
    }

    /// <summary>
    /// Récupère les mouvements de stock par type (Entrée, Sortie, etc.).
    /// </summary>
    [HttpGet("stock-by-movement-type")]
    public async Task<IActionResult> GetStockByMovementType()
    {
        try 
        { 
            var data = await _cubeAnalysis.GetStockByMovementTypeAsync();
            _logger.LogInformation("? GetStockByMovementType - Data retrieved from SSAS cube");
            return Ok(data); 
        }
        catch (Exception ex) 
        { 
            _logger.LogError(ex, "? GetStockByMovementType - Error querying SSAS cube");
            return StatusCode(500, new { error = ex.Message }); 
        }
    }

    /// <summary>
    /// Récupère les mouvements de stock par mois.
    /// </summary>
    [HttpGet("stock-by-month")]
    public async Task<IActionResult> GetStockByMonth()
    {
        try 
        { 
            var data = await _cubeAnalysis.GetStockByMonthAsync();
            _logger.LogInformation("? GetStockByMonth - Data retrieved from SSAS cube");
            return Ok(data); 
        }
        catch (Exception ex) 
        { 
            _logger.LogError(ex, "? GetStockByMonth - Error querying SSAS cube");
            return StatusCode(500, new { error = ex.Message }); 
        }
    }

    /// <summary>
    /// Récupère les meilleurs produits dynamiquement.
    /// </summary>
    [HttpGet("top-products-dynamic")]
    public async Task<IActionResult> GetTopProductsDynamic([FromQuery] int n = 10)
    {
        try 
        { 
            var data = await _cubeAnalysis.GetTopProductsDynamicAsync(n);
            _logger.LogInformation("? GetTopProductsDynamic - Data retrieved from SSAS cube");
            return Ok(data); 
        }
        catch (Exception ex) 
        { 
            _logger.LogError(ex, "? GetTopProductsDynamic - Error querying SSAS cube");
            return StatusCode(500, new { error = ex.Message }); 
        }
    }
}
