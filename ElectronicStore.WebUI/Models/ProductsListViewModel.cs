using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ElectronicStore.Domain.Entities;
using ElectronicStore.WebUI.Views;

namespace ElectronicStore.WebUI.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}