using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace Producto_1.ProductClass
{
	public class ProductHandler
    {
	{
        public ObservableCollection<Product> productList { set; get; }

        public ProductHandler()
        {
            this.productList = new ObservableCollection<Product>();
            UpdateProductList();
        }

        public void UpdateProductList() { this.productList = XMLHandler.LoadProducts(); }

    }
    public void AddProduct(Product product) { productList.Add(product); }
}