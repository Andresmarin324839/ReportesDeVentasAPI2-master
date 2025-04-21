# SalesReportAPI

API para generación de reportes de ventas con .NET Core y SQL Server

## Requisitos

- .NET 6 SDK
- SQL Server (local o Azure)

## Configuración

1. Ejecutar migraciones:

```bash
dotnet ef database update
```

2. Configurar cadena de conexión en `appsettings.json`

## Endpoints

- `GET /api/sales/summary` - Resumen de ventas por producto
- `GET /api/sales/daily?startDate=YYYY-MM-DD&endDate=YYYY-MM-DD` - Ventas diarias
- `GET /api/sales/top-products?n=5` - Top productos más vendidos

## Estructura de Base de Datos

- **Products**: Almacena información de productos
- **Sales**: Registra las ventas realizadas
