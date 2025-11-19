namespace ProductService.Common.Dtos.Categories;

public record CategoryDto(Guid Id,
                         string Name,
                         string Code,
                         string? Description);

public record CreateCategoryDto(string Name,
                                string Code,
                                string? Description);


public record UpdateCategoryDto(Guid Id, 
                                string Name,
                                string Code,
                                string? Description);