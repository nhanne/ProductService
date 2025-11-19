using AutoMapper;
using ProductService.Common.Dtos.Categories;
using ProductService.Domain.Entities.Categories;

namespace ProductService.Application.Mappers;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<CreateCategoryDto, Category>();
        CreateMap<Category, CategoryDto>();
    }
}