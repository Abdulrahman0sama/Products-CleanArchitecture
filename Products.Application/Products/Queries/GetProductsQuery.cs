using MediatR;
using Products.Application.Abstractions;
using Products.Application.Products.Dtos;

namespace Products.Application.Products.Queries;

public record GetProductsQuery : IRequest<List<ProductDto>>;

public class GetProductsHandler : IRequestHandler<GetProductsQuery, List<ProductDto>>
{
    private readonly IProductRepository _repository;

    public GetProductsHandler(IProductRepository repository) => _repository = repository;

    public async Task<List<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await _repository.GetAllAsync(cancellationToken);
        return products.Select(p => new ProductDto(p.Id, p.Name, p.Price)).ToList();
    }
}
