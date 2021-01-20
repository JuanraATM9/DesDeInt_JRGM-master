using System;


namespace Producto_1.ProductClass
{
    public class Product : ICloneable
    {
        public String productRef { set; get; }
        public String category { set; get; }
        public String brand { set; get; }
        public String description { set; get; }
        public String bottleType { set; get; }

        public Product()
        {
        }

		public object Clone()
		{
			throw new NotImplementedException();
		}
	}
}
