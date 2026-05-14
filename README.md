# BulkyWeb

An ASP.NET Core 8 e-commerce web application for browsing and managing books, built with the Repository Pattern and Entity Framework Core.

**Live site:** http://ecom.runasp.net/

---

## Features

### Customer-facing
- Browse all products on the homepage with cover images, author, and pricing
- View full product detail page with tiered bulk pricing, category, and rich description
- Responsive Bootstrap layout

### Admin panel
- **Category management** — create, edit, delete book categories
- **Product management** — create and update products with image upload, rich-text description (TinyMCE), and tiered pricing
- DataTables-powered product listing with sorting and pagination

---

## Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core 8 MVC |
| ORM | Entity Framework Core 8 (Code First) |
| Database | Microsoft SQL Server (remote) |
| UI | Bootstrap 5 (Sandstone theme), Bootstrap Icons |
| Rich Text | TinyMCE 7 |
| Tables | DataTables 2.1.8 |
| Pattern | Repository Pattern + Unit of Work |

---

## Project Structure

```
Bulky.sln
├── BulkyWeb/                   # Main web app
│   ├── Areas/
│   │   ├── Admin/              # Admin controllers & views (Category, Product)
│   │   └── Customer/           # Customer controllers & views (Home, Details)
│   ├── Views/Shared/           # Layout, Error
│   └── wwwroot/                # Static assets (css, js, images)
├── Bulky.DataAccess/           # EF Core DbContext, Migrations, Repository
│   └── Repository/             # Generic Repository + Unit of Work
├── Bulky.Models/               # Domain models (Product, Category) + ViewModels
└── Bulky.Utility/              # Shared utilities
```

---

## Models

**Product**
- Title, Author, ISBN, Description
- ListPrice, Price (1–50), Price50 (51–100), Price100 (100+)
- Category (FK), ImageUrl

**Category**
- Name (max 30 chars), DisplayOrder (1–100)

---

## Getting Started

### Prerequisites
- .NET 8 SDK
- SQL Server (or use the remote connection string as-is)

### Run locally

```bash
git clone https://github.com/Al-Waleed-IT/BulkyWeb.git
cd BulkyWeb
dotnet restore
dotnet ef database update --project Bulky.DataAccess --startup-project BulkyWeb
dotnet run --project BulkyWeb
```

The connection string in `BulkyWeb/appsettings.json` points to the remote MSSQL database on `db9706.public.databaseasp.net` and works out of the box.

### Deploy (WebDeploy)

```bash
dotnet publish BulkyWeb/BulkyWeb.csproj -c Release -o ./publish /p:UseAppHost=false
msdeploy.exe -verb:sync -source:contentPath="./publish" \
  -dest:contentPath="site10832",ComputerName="https://site10832.siteasp.net:8172/msdeploy.axd?site=site10832",... \
  -enableRule:AppOffline
```

---

## License

MIT
