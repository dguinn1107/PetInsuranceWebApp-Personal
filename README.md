# PetInsuranceWebApp

## Overview
A pet insurance web application built during my software engineering internship.

## Contributions

### Database Refactoring (feature/db-context)
- Replaced `DBContextClass` with `PetInsuranceContext`  
- Updated `DbSet` properties for `Breed`, `HealthCondition`, `HealthRecord`, `Pet`, and `QuickQuote`  
- Refined model classes into `partial` definitions  
- Added `Microsoft.EntityFrameworkCore.Design` to `.csproj` for design-time support  
- Registered new context in `Program.cs`

### Quick Quote API (feature/quickquote-api)
- Enhanced `getQuote` in `QuickQuote.vue` to validate age & breed, and format API requests  
- Added package references in `PetInsuranceProject.Server.csproj` for DB management & code gen  
- Configured CORS policy & Swagger in `Program.cs`, with Key Vault code commented out  
- Created `QuickQuoteEndpoint.cs` for request handling, validation, and premium calculation

### Azure DB Setup
- Provisioned tables in Azure SQL using raw T-SQL scripts

## Tech Stack
- **Backend:** C# (.NET Core), Entity Framework Core  
- **Frontend:** Vue.js  
- **DB:** Azure SQL (T-SQL)  
- **Tools:** Swagger, User Secrets (local only)
