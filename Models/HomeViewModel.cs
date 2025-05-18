using AgriEnergyConnect.Models;

namespace AgriEnergyConnect.ViewModels
{
    public class HomeDashboardViewModel
    {
        public int TotalFarmers { get; set; }
        public int TotalProducts { get; set; }
        public List<Product> RecentProducts { get; set; } = new List<Product>();
        public List<CategoryCountViewModel> ProductCategories { get; set; } = new List<CategoryCountViewModel>();
    }

    public class CategoryCountViewModel
    {
        public ProductCategory Category { get; set; }
        public int Count { get; set; }
    }
}