# Glovebox

A personal system for tracking a vehicle's full history: details, services, maintenance, costs, and upcoming reminders. Built for one or two users (e.g. a household), so it favours simplicity over multi-tenant complexity. Potential to expand into an SAAS in the future.

## Project Structure

```
glovebox/
├── api/      ASP.NET Core Web API (backend)
├── web/      Web client
└── mobile/   Mobile client
```

### `api/`
ASP.NET Core Web API using controllers and Entity Framework Core. It holds the data models, business logic, and persistence, and exposes a REST API to the web and mobile clients. 

- **Stack:** C#, ASP.NET Core, EF Core, SQLite (planned)
- **Run:**
  ```bash
  cd api
  dotnet run
  ```

### `web/`
Browser-based client for managing vehicles and records from a desktop or laptop. *(Not started yet.)*

### `mobile/`
Mobile client for quick, on-the-go entry such as logging fuel, updating the odometer, or snapping a receipt. *(Not started yet.)*

## Data Model

### Vehicle
The central entity. Supports cars, motorcycles, vans, trucks and other vehicles.

| Group | Fields |
|-------|--------|
| Identity | Nickname, Type, Make, Model, Year, Trim, VIN, Registration number, Colour |
| Specifications | Fuel type, Transmission, Engine, Oil type, Tyre size |
| Ownership | Purchase date and price, Sold date and price |

### Enums
- `VehicleType`: Car, Motorcycle, Van, Truck, Other
- `FuelType`: Petrol, Diesel, Hybrid, PlugInHybrid, Electric
- `Transmission`: Manual, Automatic (more planned)
- `OdometerUnit`: Miles, Kilometers
- `VehicleStatus`: Active, Stored, Sold, Scrapped

## Planned Features

### Core
- [ ] Vehicle CRUD (add, view, edit, delete)
- [ ] Database persistence with EF Core and SQLite
- [ ] Service and maintenance history per vehicle (date, odometer, type, cost, shop, notes)
- [ ] Odometer tracking and history

### Tracking
- [ ] Fuel log with MPG / efficiency stats
- [ ] Cost summaries (total spend, cost per mile, spend by category)
- [ ] Service intervals and "next due" calculations

### Reminders
- [ ] Registration, insurance and inspection expiry reminders
- [ ] Upcoming service alerts based on date or mileage

### Quality of life
- [ ] Receipt and document attachments
- [ ] Vehicle photos
- [ ] VIN lookup to auto-fill make, model and year
- [ ] Data export (CSV / JSON)
- [ ] Simple authentication for the one or two users

### Clients
- [ ] Web UI
- [ ] Mobile app

## Getting Started

**Prerequisites:** [.NET SDK](https://dotnet.microsoft.com/download) (version matching `api/Glovebox.Api.csproj`)

```bash
git clone <repo-url>
cd glovebox/api
dotnet run
```

The API listens on the URL printed in the console. The OpenAPI spec is served at `/openapi/v1.json` in development.

## Status

Early development. The API project is scaffolded, with the `Vehicle` model and a basic controller in progress.