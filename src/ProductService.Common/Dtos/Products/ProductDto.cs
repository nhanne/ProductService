using Microsoft.AspNetCore.Http;

namespace ProductService.Common.Dtos.Products;

public record ProductDto(Guid Id,
                         Guid CategoryId,
                         string Name,
                         string Code,
                         string? Note,
                         decimal CostPrice,
                         List<string> Images);

public record CreateProductDto(Guid CategoryId,
                               string Name,
                               string Code,
                               string? Note,
                               decimal CostPrice);

public record UpdateProductDto(Guid CategoryId,
                               string Name,
                               string Code,
                               string? Note,
                               decimal CostPrice);
