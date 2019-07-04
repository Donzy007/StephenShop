using StephenShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenShop.Core.ViewModels
{
    public class ProductManagerView
    {
        public Product product { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}
