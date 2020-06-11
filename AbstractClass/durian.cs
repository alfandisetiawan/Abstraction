using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.AbstractClass
{
    public class durian : makanan
    {
        public override void buah()
        {
            Console.WriteLine("'raja buah',seperti itulah julukan bagi buah durian");
            Console.WriteLine("selain memiliki rasa yang khas,buah durian juga dapat diolah menjadi berbagai macam,");
            Console.WriteLine("seperti tempoyak,selai dan lain-lain.");
        }
    }
}