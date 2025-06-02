using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Product
    {
        public string name;
        public int price;
        private static Product product;

        // 팩토리 메서드 패턴 (static 붙여주기)
        public static Product getInstance(string name, int price)
        {
            if (product == null)
            {
                product = new Product(name, price);
            }
            return new Product(name, price);
        }

        private Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
