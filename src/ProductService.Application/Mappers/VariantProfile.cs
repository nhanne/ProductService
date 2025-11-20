using AutoMapper;
using ProductService.Common.Dtos.Variants;
using ProductService.Domain.Entities.Variants;
using System.Text.Json;

namespace ProductService.Application.Mappers;
public class VariantProfile : Profile
{
    public VariantProfile()
    {
        CreateMap<Variant, VariantDto>();
    }
}