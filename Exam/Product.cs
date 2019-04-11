using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exam
{
    [Serializable]
    public class Product
    {

        public string Name { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
}