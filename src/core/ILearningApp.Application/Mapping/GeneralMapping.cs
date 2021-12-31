using AutoMapper;
using ILearningApp.Application.Dto;
using ILearningApp.Application.Features.Commands.CreateProduct;
using ILearningApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILearningApp.Application.Mapping
{
    public class GeneralMapping : Profile
    {

        public GeneralMapping()
        {
            CreateMap<Product, ProductViewDto>().ReverseMap();

            CreateMap<Product, CreateProductCommand>().ReverseMap();

            CreateMap<Product, ProductGetByIdViewDto>().ReverseMap();
            
        }
    }
}
