using System;

namespace my4DArray
{
    class Program
    {
        //Multi-dimensional Arrays
        static void Main(string[] args)
        {
            var my4darray = new int[4][];

            my4darray = new int[4][];
            my4darray[0] = new int[2];
            my4darray[1] = new int[3];
            my4darray[2] = new int[5];
            my4darray[3] = new int[4];
           
            my4darray[0][0] = 2;
            my4darray[0][1] = 3;
            my4darray[1][0] = 5;
            my4darray[1][1] = 5;

            Console.WriteLine(my4darray[1] [0]);
        }
    }
}
