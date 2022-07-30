using Havas.Domain.Entities.Products;
using Havas.Service.DTOs.ProductDTOs;
using Havas.Service.Interfaces;
using Havas.Service.Services;

CategoryForCreation category = new CategoryForCreation()
{
    Name = "Mevalar",
    Description = "Tabiiy toza mevalar"

};

ICategoryService service = new CategoryService();
await service.CreateAsync(category);
//Console.WriteLine(createdCategory.Name + " " + createdCategory.Description + " " + createdCategory.Id + " " +
//    createdCategory.CreatedAt + " " + createdCategory.UpdatedAt + " " + createdCategory.State);
    