using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            matrix.SetSize();
            for(int i=0; i<matrix.GetSize(); i++)
            {
                matrix[i] = i;
            }
            for(int i=0;i<matrix.GetSize();i++)
            {
                Console.WriteLine(matrix[i]);
            }
            Console.ReadLine();
        }
    }
}
