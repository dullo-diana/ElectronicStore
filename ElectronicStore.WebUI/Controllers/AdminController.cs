using System.Linq;
using System.Web.Mvc;
using ElectronicStore.Domain.Abstract;
using ElectronicStore.Domain.Entities;

namespace ElectronicStore.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IProductRepository _repository;

        public AdminController (IProductRepository repo)
        {
            _repository = repo;
        }

        public ViewResult Index()
        {
            return View(_repository.Products);
        }

        public ViewResult Edit(int productId)
        {
            Product product = _repository.Products
                .FirstOrDefault(p => p.ProductID == productId); 
            return View(product); 
        } 
	}
}