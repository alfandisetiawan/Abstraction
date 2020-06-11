using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.AbstractClass
{
    public class manggis: makanan
    {
        public override void buah()
        {
            Console.WriteLine("bila ada raja,disitu ada ratu,julukan bagi buah manggis");
            Console.WriteLine("buah manggis memiliki rasa manis yang alami,yang mampu menyegarkan tenggorokan.");
        }
    }
}