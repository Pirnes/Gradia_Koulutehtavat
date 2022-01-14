using System;

namespace Pituusmuunnin
{
    class Program
    {
        static void Main(string[] args)
        {

            Double meter=100 , mail= 1609.347087886445 , yard =0.91 , inch = 0.0254;
            Double input, meter2;
            
            
            Console.WriteLine("Hei, anna pituutesi senttimetreinä, niin muunnan sen metreiksi, maileiksi, jaardeiksi ja tuumiksi:  ");
            Console.WriteLine();
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("Pituutesi metreinä on:  " + "{0:0.00}", input / meter);
            meter2 = input / meter;
            Console.WriteLine("Pituutesi maileina on:  " + "{0:0.00}", meter2 / mail);
            Console.WriteLine("pituutesi jaardeina on: " + "{0:0.00}", meter2 / yard);
            Console.WriteLine("pituutesi tuumina on:   " + "{0:0.00}", meter2 / inch);
            Console.ReadKey();



                


        }
    }
}
