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
                               decimal CostPrice,
                               List<IFormFile> Images);

public record UpdateProductDto(Guid Id,
                               Guid CategoryId,
                               string Name,
                               string Code,
                               string? Note,
                               decimal CostPrice,
                               List<IFormFile> Images);
