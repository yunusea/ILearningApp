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

namespace ILearningApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<ProductGetByIdViewDto>>
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public GetProductByIdQueryHandler(IProductRepository ProductRepository, IMapper Mapper)
        {
            productRepository = ProductRepository;
            mapper = Mapper;
        }

        public async Task<ServiceResponse<ProductGetByIdViewDto>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetByIdAsync(request.Id);
            var dto = mapper.Map<ProductGetByIdViewDto>(product);
            return new ServiceResponse<ProductGetByIdViewDto>(dto);
        }
    }
}
