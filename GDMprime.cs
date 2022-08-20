using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstTask2
{
    public class GDMprime
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int i, j;
            Console.WriteLine("Prime Numbers are : ");
            for(i = 2; i <= 50; i++ ){
                for(j = 2; j <= 50; j++){
                    if(i != j && i % j ==0){
                        isPrime = false;
                    }
                    if(isPrime){
                        Console.Write("\t" + i);
                    }
                }   isPrime = true;
            }   Console.ReadKey();


        }
    }
}