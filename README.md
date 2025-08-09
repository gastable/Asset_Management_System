# 🗂️ Asset Management System (ASP.NET MVC)

Built with **ASP.NET MVC**, **MS SQL Server**, and **Bootstrap**.  
- Conducted business requirement analysis, UI/UX considerations, database design, full-stack system implementation, and API integration.  
- The system provides stock data visualization, back-testing, and asset management capabilities for individual investors.

---

## 📦 Tech Stack
- **C# / .NET Framework** (ASP.NET MVC 5)
- **MS SQL Server** (database)
- **Bootstrap** (UI framework)
- **NuGet** (packages.config)
- Optional database via **Entity Framework** (code-first or DB-first — see Models/Migrations if present)

---

```
AMWP/ # Web application (solution & project)
├─ App_Start/ # MVC config (routes, bundles, filters)
├─ Content/ # CSS, site styles
├─ Controllers/ # MVC controllers
├─ Models/ # Domain/view models (and possibly EF context)
├─ New/ # (Custom folder used by project)
├─ Photos/ # Static images
├─ Properties/
├─ Scripts/ # JS assets (jQuery/Bootstrap/etc.)
├─ ViewModels/ # Strongly-typed view models
├─ Views/ # Razor views (.cshtml)
├─ bin/ # Build output
├─ obj/ # Intermediate build output
├─ packages/ # NuGet packages (packages.config)
├─ AMWP.sln # Solution
├─ AMWP.csproj # Project file
├─ Global.asax(.cs) # App entry & MVC wiring
├─ Web.config # App configuration
└─ favicon.ico
```

---

✨ Features
Asset CRUD (create, edit, retire)

Categories / locations

Assign & return to users/rooms

Maintenance & warranty tracking

Search & filtering

Stock data visualization

Back-testing tools

Asset management for individual investors

Basic reports (export/print)
