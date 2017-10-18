using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWORK_Var2_VendingMachine
{
    [Serializable]
    public class Product
    {
        private string ProductName { get; set; } // Ім'я товару
        public Money ProductPrice { get; set; } // Ціна товару
        public Product(string ProductName, Money ProductPrice) // Конструктор з параметрами
        {
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
        }
        public static Product[] AddProductsToArray(params Product[] products) // Створення масиву продуктів
        {
            Product[] tmpProduct = new Product[products.Length];
            for (int i = 0; i < products.Length; i++)
                tmpProduct[i] = products[i];
            return tmpProduct;
        }
    }
}