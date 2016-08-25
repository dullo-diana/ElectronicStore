﻿using System.Linq;
using System.Web.Mvc;
using ElectronicStore.Domain.Abstract;
using ElectronicStore.WebUI.Models;
using ElectronicStore.WebUI.Views;

namespace ElectronicStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;
        public int PageSize = 4;

        public ProductController(IProductRepository productRepository)
        {
            _repository = productRepository;
        }

        public ViewResult List(string category, int page = 1)
        {
         ProductsListViewModel model = new ProductsListViewModel
         {
             Products = _repository.Products        
             .Where(p => category == null || p.Category == category)
             .OrderBy(p => p.ProductID)                
             .Skip((page - 1) * PageSize)                
             .Take(PageSize),                
             PagingInfo = new PagingInfo
             {
                 CurrentPage = page,                    
                 ItemsPerPage = PageSize,
                 TotalItems = category == null ? 
                 _repository.Products.Count() : 
                 _repository.Products.Where(e => e.Category == category).Count()
             },
             CurrentCategory = category
         };            
        return View(model);
        } 
    }
}