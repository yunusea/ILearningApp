using AutoMapper;
using ILearningApp.Application.Dto;
using ILearningApp.Application.Interfaces.Repository;
using ILearningApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ILearningApp.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductViewDto>>>
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public GetAllProductsQueryHandler(IProductRepository ProductRepository, IMapper Mapper)
        {
            productRepository = ProductRepository;
            mapper = Mapper;
        }

        public async Task<ServiceResponse<List<ProductViewDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetAllAsync();
            var ViewModel = mapper.Map<List<ProductViewDto>>(product);
            return new ServiceResponse<List<ProductViewDto>>(ViewModel);
        }
    }
}
