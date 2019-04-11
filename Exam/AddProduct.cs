using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public class AddProduct
    {
        KeysConverter keysConverter = new KeysConverter();
        Product product = new Product();
        ConsoleKeyInfo input;
        public delegate void AccountStateHandler(object sender, KeyEventArgs e);
        public event AccountStateHandler clickCTRL;
        
        public void AddProductToFactory(Product product)
        {
            Console.WriteLine("Введите название продукта: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("Введите количество продуктов: ");
            product.Count = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену продукта: ");
            product.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Нажмите сочетание клавиш CTRL+");
            input = Console.ReadKey();
            if((input.Modifiers & ConsoleModifiers.Control) != 0)
            {
                Console.WriteLine("Продукт добавлен!");
            }
            else
            {
                Console.WriteLine("Продукт не добавлен");
            }
        }
        //public void CTRL()
        //{
        //    Console.WriteLine("Введите CTRL");
        //    KeyPressEventArgs key;
        //    clickCTRL?.Invoke(this, new KeyEventArgs(key));
        //}


    }
}
