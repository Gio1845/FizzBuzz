using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //primera - inicializacion
            //antes de comenzar el for

            //segunda - condicion
            //antes de comenzar cada interacion del for

            //tercera - ???
            //despues de cada interacion
            

            
            //while (true) {

            //}
            for (int i = 1; i <= 100; i++) {
                if(i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                } else if(i % 3 ==0){
                   Console.WriteLine("Fizz"); 
                }else if (i % 5 ==0){
                    Console.WriteLine("Buzz");
                }else{
                    Console.WriteLine(i);
                }
               
            }
        }
    }
}
