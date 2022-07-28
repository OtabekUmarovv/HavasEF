using AutoMapper;
using Havas.Domain.Entities.Products;
using Havas.Domain.Entities.Suppleirs;
using Havas.Service.DTOs.ProductDTOs;
using Havas.Service.DTOs.SuppleirDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Suppleir, SuppleirCreation>().ReverseMap();
            CreateMap<Product, ProductCreation>().ReverseMap();
            CreateMap<Category, CategoryCreation>().ReverseMap();

        }
    }
}
