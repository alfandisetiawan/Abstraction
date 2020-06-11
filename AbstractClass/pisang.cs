using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.AbstractClass
{
    public class pisang : makanan
    {
        public override void buah()
        {
            Console.WriteLine("abstract class");
            Console.WriteLine("buah-buahan yang paling populer adalah buah pisang.");
            Console.WriteLine("pisang dapat diolah menjadi berbagai macam seperti,bolu pisang,pisang goreng,dan masih banyak lagi.");
        }
    }
}