# GaiaMare API

API REST para gestión de productos e inventario de calzado.

## Tecnologías

- .NET 10
- Entity Framework Core
- SQL Server

## Configuración

1. Actualiza la cadena de conexión en `appsettings.json`
2. Ejecuta el script SQL de `BBDD/TablasCreacion.sql`
3. Ejecuta el proyecto

## Endpoints

### Productos

**Obtener todos los productos**
```
GET https://localhost:7230/api/products
```

**Productos con stock**
```
GET https://localhost:7230/api/products/stock
```

**Filtrar productos**
```
GET https://localhost:7230/api/products/filter?collection=Verano&material=Piel
```

### Inventario

**Obtener inventario completo**
```
GET https://localhost:7230/api/inventory
```

**Inventario por producto**
```
GET https://localhost:7230/api/inventory/product/1
```

**Filtrar por estado**
```
GET https://localhost:7230/api/inventory/filter?status=In Stock
```

## Estructura del Proyecto

```
GaiaMare.API/          → Controladores y configuración
GaiaMare.Domain/       → Modelos y DTOs
GaiaMare.Infrastructure/ → DbContext y configuración de EF
GaiaMare.Application/  → Lógica de negocio
BBDD/                  → Scripts SQL
```
