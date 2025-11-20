using MediatR;
using ProductService.Common.Dtos.Products;
using ProductService.Domain.Entities.Products;

namespace ProductService.Application.Features.Products.Notifications;

public record ProductCreatedNotification(CreateProductDto model, Product entity) : INotification;