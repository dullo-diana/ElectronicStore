using System.Collections.Generic;
using System.Web.Mvc;
using ElectronicStore.Domain.Abstract;
using System.Linq;

namespace ElectronicStore.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IProductRepository _repository;

        public NavController(IProductRepository repo)
        {
            _repository = repo;
        }
        
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = _repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return PartialView("FlexMenu", categories);
        }
	}
}