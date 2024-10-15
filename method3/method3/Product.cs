using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method3
{
    internal class Product
    {
        public string Id;
        public string Model;
        public string BrandName;
        public decimal Price;
        public decimal Cost;
        public decimal Income;
        public int Count;

        public Product(string model, string brandName, decimal price, decimal cost, int count)
        {

            Model = model;
            BrandName = brandName;
            Price = price;
            Cost = cost;
            Income =count* (Price - Cost);
            Count = count;
            Id = BrandName.Substring(0, 2) + Model.Substring(0, 2);

        }


        public void GetInfo()
        {
            Console.WriteLine($"Id:{Id} Model:{Model} BrandName:{BrandName} Price:{Price} Cost:{Cost} income:{Income} Count:{Count}");
        }

        public void Sale(int count)
        {
            if (count >= 15)
            {
              Console.WriteLine("The sale is successfully done!");
                return;
            }
            else if (count < 15 || count<0)
            { 
                Console.WriteLine("The sale is cancelled");
            }
            
        }
    }

}
