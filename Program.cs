using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{
    public class Program
    {
        //Generic meanse the general form
        //it meanse not specific for particuler data type
        //<> this is angle becket with type name
        //TypeName<T> T is here type parameter
        //generic allowas to a create single class or method that can be use with different data type
        //advantage :we can reuse our code
        static void Main(string[] args)
        {
            GenericClass<String> stringObj = new GenericClass<string>("Subhash");
            GenericClass<int> intObj = new GenericClass<int>(20);
            GenericClass<double> doubleObj = new GenericClass<double>(20.10);

            stringObj.GenaralcMethod("shiva");
            intObj.GenaralcMethod(100);
            doubleObj.GenaralcMethod(50.5);
            Console.ReadLine();
        }
    }
}
