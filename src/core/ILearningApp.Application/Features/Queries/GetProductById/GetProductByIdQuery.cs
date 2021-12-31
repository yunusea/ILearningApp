using ILearningApp.Application.Dto;
using ILearningApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILearningApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<ProductGetByIdViewDto>>
    {
        public Guid Id { get; set; }
    }
}
