using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            
            AddProduct addProduct = new AddProduct();
            addProduct.AddProductToFactory(product);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
            using (FileStream f = new FileStream("Product.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(f, product);
            }
            using (FileStream f = new FileStream("Product.xml", FileMode.OpenOrCreate))
            {
                Product newProduct = (Product)xmlSerializer.Deserialize(f);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Название продукта: {product.Name} \nКоличество продуктов: {product.Count} \nЦена продуктов: {product.Price}");
            }
            //addProduct.clickCTRL += AddByCTRL;
            //addProduct.CTRL();
            Console.ReadKey();
        }
        private static void AddByCTRL(object sender, KeyEventArgs key)
        {
            if (key.Control)
            {
                Console.WriteLine("Добавлен продукт");
            }
        }
    }
}
