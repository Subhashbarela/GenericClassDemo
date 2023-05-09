using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{
    public class GenericClass<T>
    {
        //this is variable of type T
        public T data;

        //This is my generic constructor
        public GenericClass(T data)
        {
            this.data = data;
            Console.WriteLine("Data : "+this.data);
        }
        public void GenaralcMethod(T data)
        {
            Console.WriteLine("Data : "+data);
        }

    }

}
