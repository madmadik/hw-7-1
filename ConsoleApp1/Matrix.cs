using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Matrix
    {
        int size;
        double[] matrix;

        public void SetSize()
        {
            bool check = int.TryParse(Console.ReadLine(), out size);

            if(check)
            {
                matrix = new double[size];
            }
            else
            {
                matrix = null;
                Console.WriteLine("not correctly parsing!");
            }
        }

        public int GetSize()
        {
            return size;
        }

        public double this[int index]
        {
            get
            {
                return matrix[index];
            }
            set
            {
                int degree = 2;
                matrix[index] = Math.Pow(value, degree);
            }
        }

    }
}
