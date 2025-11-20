using AutoMapper;
using ProductService.Common.Dtos.Products;
using ProductService.Domain.Entities.Products;

namespace ProductService.Application.Mappers;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<CreateProductDto, Product>();
        CreateMap<Product, ProductDto>();
    }
}