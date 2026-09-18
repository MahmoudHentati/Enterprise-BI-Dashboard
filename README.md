# 📊 Enterprise BI & OLAP Cube Analytics Dashboard

[![.NET](https://img.shields.io/badge/.NET-8.0%20%2F%209.0-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Blazor](https://img.shields.io/badge/Blazor-Web%20App-512BD4?logo=blazor&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![SSAS](https://img.shields.io/badge/Microsoft%20SSAS-OLAP%20Cube-CC292B?logo=microsoftsqlserver&logoColor=white)](https://learn.microsoft.com/sql/analysis-services/)
[![Language](https://img.shields.io/badge/C%23-12-239120?logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![Query](https://img.shields.io/badge/Query%20Language-MDX-blue)]()

An end-to-end **Business Intelligence & Executive Analytics Solution** that bridges **SQL Server Analysis Services (SSAS) OLAP Multidimensional Cubes** with an interactive **Blazor Web Dashboard** via a high-performance **ASP.NET Core REST API**.

---

## 🏛️ Architecture Overview

`mermaid
graph LR
    subgraph Storage & OLAP Layer
        DW[(Data Warehouse)] --> Cube[SSAS Multidimensional Cube\n'EnterpriseCube']
    end

    subgraph Backend API Layer
        Cube -->|MDX Queries| Service[CubeAnalysisService\nADOMD.NET]
        Service --> Controller[REST API Controllers\n/api/cube/*]
    end

    subgraph Presentation Layer
        Controller -->|JSON over HTTP| BlazorApp[Blazor Interactive Web App\nComponents & Chart Analytics]
        BlazorApp --> User((Business Analyst / Executive))
    end
`

---

## 🚀 Key Features

### 1. Executive Sales Dashboard (Dashboard.razor)
* **Real-Time KPIs:** Total Revenue, Total Amount Paid, Outstanding Balance, Payment Rate.
* **Temporal Trend Analysis:** Revenue vs. Paid Amount tracked month-over-month.

### 2. Customer Insights & Segmentation (Customers.razor)
* Revenue breakdown and order volumes per customer.
* Credit analysis and payment compliance ratios.

### 3. Product Performance (Products.razor)
* Top revenue-generating products and categories.
* Volume of units sold vs. margin profitability.

### 4. Cross-Dimensional Matrix (CustomersProducts.razor)
* Multidimensional cross-analysis connecting customer profiles directly to purchased product lines.

### 5. Inventory & Supply Chain Analytics (Stock.razor)
* Stock availability, movement tracking, and warehouse distribution metrics.

---

## 🛠️ Tech Stack

* **Frontend:** Blazor Web App (C#, Razor Components, CSS/Bootstrap).
* **Backend:** ASP.NET Core Web API.
* **OLAP / Data Source:** Microsoft SQL Server Analysis Services (SSAS), MDX (MultiDimensional Expressions).
* **Connection Provider:** MSOLAP / ADOMD.NET provider for multidimensional querying.

---

## ⚙️ Configuration & Setup

### Prerequisites
* [.NET 8.0 or .NET 9.0 SDK](https://dotnet.microsoft.com/download)
* Microsoft SQL Server with **SSAS (SQL Server Analysis Services)** running
* Deployed Entreprise_Cube SSAS database

### 1. Configure the SSAS Connection
Edit EntrepriseDashboard/appsettings.json to point to your SSAS instance:
`json
{
  "ConnectionStrings": {
    "SsasConnection": "Provider=MSOLAP;Data Source=localhost;Catalog=Entreprise_Cube;Integrated Security=SSPI;Initial Catalog=Entreprise_Cube;"
  }
}
`

### 2. Run the Backend API
`ash
dotnet run --project EntrepriseDashboard
# API will listen on http://localhost:5050 (or configured port)
`

### 3. Run the Blazor Frontend
`ash
dotnet run --project EntrepriseDashboardFront
`

Navigate to https://localhost:7xxx or http://localhost:5xxx to explore the analytical dashboard.

---

## 👨‍💻 Author
**Mahmoud Hentati**  
*Computer Engineering Student | Full-Stack & BI Developer*  
* [LinkedIn](https://www.linkedin.com/) • [GitHub](https://github.com/)
