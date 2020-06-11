using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.AbstractClass
{
    public class kelapa : makanan
    {
        public override void buah()
        {
            Console.WriteLine("buah-buahan yang populer salanjutnya adalah buah kelapa.");
            Console.WriteLine("tanaman yang mendapat julukan 1001 manfaat ini mempunyai buah yang sangat bermanfaat,");
            Console.WriteLine("dan dapat diolah menjadi berbagai macam seperti santan,keripik,selai dan lain-lain.");
        }
    }
}