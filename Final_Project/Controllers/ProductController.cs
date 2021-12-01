using Microsoft.AspNetCore.Mvc;
using Models;
using Reposotries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProductController:ControllerBase
    {
        IGenericRepostory<Product> ProductRepo;
        IUnitOfWork UnitOfWork;
       public ProductController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            ProductRepo = UnitOfWork.GetProductRepo();

        }

        [HttpGet("")]
         public async Task<IEnumerable<Product>> Get()
        {
            return await ProductRepo.GetAsync();
        }

        [HttpGet("{id}")]
        public async Task<Product> GetProductByID(int id)
        {
            return await ProductRepo.GetByIDAsync(id);
        }
    }
}
