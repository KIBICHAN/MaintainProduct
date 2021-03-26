using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintainProducts
{
    //Khai bao lop Product
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }

    }//end class
    //Khai bao lop thuc hien cac thao tac: them, xoa, tim
    public class ProductData
    {
        private List<Product> ProductsList = new List<Product>();
        //Khai bao properties
        public List<Product> GetProductsList
        {
            get
            {
                return ProductsList;
            }
        }

        //Khai bao phuong thuc them Product
        public void AddNew(Product p)
        {
            Product pro = Find(p.ProductID);
            if(pro == null)
            {
                ProductsList.Add(p);
            }
            else
            {
                throw new Exception("Product is already exists.");
            }
        }

        //Khai bao phuong thuc xoa Product
        public void Remove(int ProductID)
        {
            Product p = Find(ProductID);
            if(p != null)
            {
                ProductsList.Remove(p);
            }
            else
            {
                throw new Exception("Product is not already exists.");
            }
        }
        //Khai bao phuong thuc tim products
        public Product Find(int ProductID)
        {
            Product p = ProductsList.SingleOrDefault
                (pro => pro.ProductID == ProductID);
            return p;
        }//end class
    }//end namespace
}
