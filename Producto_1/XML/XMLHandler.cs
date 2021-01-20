using System;
using ComboXML.ProductsClass;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using Producto_1.ProductClass;

namespace Producto_1.XML
{
    class XMLHandler
    {
        private static XDocument xml;
        private static Product product;

        private static void LoadXML() { xml = XDocument.Load("../../XML/XMLFile1.xml"); }

        public class ProductHandler
        {
            public ObservableCollection<Product> productList { set; get; }

            public ProductHandler()
            {
                this.productList = new ObservableCollection<Product>();
                UpdateProductList();
            }

            public void UpdateProductList() { this.productList = XMLHandler.LoadProducts(); }

            public void AddProduct(Product product) { productList.Add(product); }
        }
    }
}
