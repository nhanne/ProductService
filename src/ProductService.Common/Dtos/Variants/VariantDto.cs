namespace ProductService.Common.Dtos.Variants;

public record VariantDto(Guid Id,
                         Guid ProductId,
                         string SKU,
                         decimal UnitPrice,
                         int Quantity,
                         string MainImage,
                         string Attributes);

public record CreateVariantDto(Guid ProductId,
                               string SKU,
                               decimal UnitPrice,
                               int Quantity,
                               string MainImage,
                               Dictionary<string, string> Attributes);

public record UpdateVariantDto(Guid ProductId,
                               string SKU,
                               decimal UnitPrice,
                               int Quantity,
                               string MainImage,
                               Dictionary<string, string> Attributes);