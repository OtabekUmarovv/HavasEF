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
            CreateMap<SuppleirForCreationDto, Suppleir>();
            CreateMap<Suppleir, SuppleirForViewModel>();

            CreateMap<ProductForCreationDto, Product>();
            CreateMap<Product, ProductForViewModel>();

            CreateMap<CategoryForCreationDto, Category>();
            CreateMap<Category, CategoryForViewModel>();

        }
    }
}
