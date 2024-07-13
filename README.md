# Code Zone Company - Small Stock Project

## Overview

This project is a small stock management system developed using ASP.NET MVC with Clean Architecture. It focuses on CRUD operations for managing items and stores, along with functionalities for selling and purchasing items. The application follows a modular structure leveraging CQRS, Mediator, Strategy, and Simple Factory design patterns to ensure scalability, maintainability, and flexibility in development.

## Project Structure

The project is organized following the principles of Clean Architecture:
```
├── CodeZone.StockProject
│ ├── CodeZone.Application
│ ├── CodeZone.Domain
│ ├── CodeZone.Infrastructure
│ ├── CodeZone.MVC
│ └── CodeZone.Persistence
```



- **Application:** Contains application logic, including handlers for CQRS commands and queries.
- **Domain:** Defines core entities like `Item`, `Store`, and their interactions, along with business logic.
- **Infrastructure:** Provides Services implementations, including Image Service.
- **MVC:** Houses the ASP.NET MVC controllers, views, and front-end components.
- **Persistence:** Manages migrations and database configurations, Provides data access implementations, including repositories and database context.

## Run Steps

Follow these steps to clone, set up, and run the project locally:

1. **Clone the repository:**
   ```sh
   git clone https://github.com/CodeZoneCompany/SmallStockProject.git
   ```
   
2. **Add migration:**
```sh
Add-migration 'Initial' ../CodeZone.Persistence
```
3. **Update database:**
```sh
Update-Database ../CodeZone.Persistence
```
