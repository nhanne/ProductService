using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductService.Application.Features.Categories.Commands.Create;
using ProductService.Application.Features.Categories.Commands.Delete;
using ProductService.Application.Features.Categories.Queries.GetById;
using ProductService.Application.Features.Categories.Queries.GetList;
using ProductService.Common.Dtos.Categories;

namespace ProductService.Api.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/product/[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ISender _sender;
    public CategoryController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] ListCategoriesQuery model)
    {
        var query = new ListCategoriesQuery(model.Pagination);
        var result = await _sender.Send(query);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCategoryDto model)
    {
        var command = new CreateCategoryCommand(model);
        var result = await _sender.Send(command);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Put([FromBody] UpdateCategoryDto model)
    {
        var command = new UpdateCategoryCommand(model);
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var command = new DeleteCategoryCommand(id);
        await _sender.Send(command);
        return NoContent();
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var query = new GetCategoryQuery(id);
        var result = await _sender.Send(query);
        return Ok(result);
    }
}
