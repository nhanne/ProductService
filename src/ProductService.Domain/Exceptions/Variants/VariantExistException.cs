using ProductService.Domain.Abtractions;
using System.Net;

namespace ProductService.Domain.Exceptions.Variants;

public class VariantExistException : BaseException
{
    public VariantExistException(string sku)
        : this(nameof(sku), sku)
    {
    }
    public VariantExistException(string name, bool isName = true)
         : this(nameof(name), name)
    {
    }
    private VariantExistException(string propertyName, string value)
       : base($"Variant with {propertyName} '{value}' already taken", HttpStatusCode.Conflict)
    {
    }
}