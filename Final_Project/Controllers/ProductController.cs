﻿using Microsoft.AspNetCore.Cors;
﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;
using Reposotries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ViewModels;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProductController : ControllerBase
    {
        IGenericRepostory<Product> ProductRepo;

        IGenericRepostory<Store> StoreRepo;
        IUnitOfWork UnitOfWork;

        ResultViewModel result = new ResultViewModel();

        public ProductController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            ProductRepo = UnitOfWork.GetProductRepo();
            StoreRepo = UnitOfWork.GetStoreRepo();
        }

        [HttpGet("")]

       
        public  ResultViewModel Get()
        {

            result.Message = "All Products";
            result.Data = ProductRepo.Get().Select(p => p.ToViewModel());
            return result;
        }

        [HttpGet("{id}")]
        public ResultViewModel GetProductByID(int id)
        {
            result.Message = " Product By ID";
           
            result.Data = ProductRepo.GetByID(id).ToViewModel();

            return result;

        }
        [HttpPost("addProduct")]
        public ResultViewModel addProduct(InsertProductViewModel pro)
        {
            result.Message = "Add Product";

            var product = new Product()
            {
                ID = pro.ID,
                Name = pro.Name,
                Image = pro.Image,
                Rate = pro.Rate,
                Description = pro.Description,
                Price = pro.Price,
                CurrentCategoryID = pro.CurrentCategoryID,
                CurrentSupplierID = pro.CurrentSupplierID,
                CurrentUserID = pro.CurrentUserID
            };

            ProductRepo.Add(product);
            UnitOfWork.Save();
            result.Data = pro;

            return result;

        }
        [HttpPut("editProduct")]
        public ResultViewModel editProduct(int id , InsertProductViewModel pro)
        {
            if (id == null)
            {
                result.Message = "Not Found Product";
            }
            var product = ProductRepo.GetByID(id);
            product.ID = pro.ID;
            product.Name = pro.Name;
            product.Image = pro.Image;
            product.Rate = pro.Rate;
            product.Description = pro.Description;
            product.Price = pro.Price;
            product.CurrentCategoryID = pro.CurrentCategoryID;
            product.CurrentSupplierID = pro.CurrentSupplierID;
            product.CurrentUserID = pro.CurrentUserID;

            if (product == null)
            {
                result.Message = "NotFound Product";
            }
            ProductRepo.Update(product);
            UnitOfWork.Save();
            return result;
        }
        public ResultViewModel deleteProduct(int id)
        {
            result.Message = "Deleted Product";
            var product = ProductRepo.GetByID(id);
            result.Data = product;
            ProductRepo.Remove(product);
            UnitOfWork.Save();
            return result;
        }













        [HttpPost("addStore")]
        public ResultViewModel addStore(StoreViewModel sto)
        {
            result.Message = "Add Store";
            var store = new Store()
            {
              
               Name = sto.Name,
               Address = sto.Address,
               Phone = sto.Phone
            };

            StoreRepo.Add(store);
            UnitOfWork.Save();
            result.Data = store;

            return result;

        }
        [HttpPut("editStore")]
        public ResultViewModel editStore(int id, StoreViewModel sto)
        {
            if (id == null)
            {
                result.Message = "Not Found Store";
            }
            var store = StoreRepo.GetByID(id);
            result.Data = ProductRepo.GetByID(id).ToViewModel();
            
            store.Name = sto.Name;
            store.Address = sto.Address;
            store.Phone = sto.Phone;

            if (store == null)
            {
                result.Message = "NotFound Store";
            }
            result.Data = store;
            StoreRepo.Update(store);
            UnitOfWork.Save();
            return result;
        }

        [HttpDelete("deleteStore")]
        public ResultViewModel deleteStore(int id)
        {
            var store = StoreRepo.GetByID(id);
            result.Data = store;
            StoreRepo.Remove(store);
            UnitOfWork.Save();
            result.Message = "Store Deleted";
            return result;
        }
        [HttpGet("delete/{id}")]
        public ResultViewModel Delete(int id)
        {
            result.Message = " Delete Done";
            result.Data = ProductRepo.GetByID(id);
            ProductRepo.Remove(ProductRepo.GetByID(id));
            UnitOfWork.Save();

            return result;

        }
    }
}
