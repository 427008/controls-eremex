using CommunityToolkit.Mvvm.ComponentModel;
using DemoCenter.DemoData;
using DemoCenter.DemoData.CsvClasses;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DemoCenter.ViewModels
{
    public partial class DataGridDragDropPageViewModel : PageViewModelBase
    {   
        public DataGridDragDropPageViewModel()
        {
            ProductsInWarehouse = CsvSources.StockProducts.Take(50).ToList();
            ProductsInStock = CsvSources.StockProducts.TakeLast(20).ToList();
        }

        public List<StockProduct> ProductsInStock { get; }

        public List<StockProduct> ProductsInWarehouse { get; }

    }
}
