using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace funktiot
{
    class Program
    {
        private static void Tervehdys(string etunimi, string sukunimi, ref int age)
        {
            Console.WriteLine("Kerro ikäsi:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine(etunimi + " " + sukunimi + ", " + age + " wee, Tervetuloa ohjelmaan!");
        }


        static void Main(string[] args)

        {
            int age = 1;

            Console.WriteLine("Anna etunimesi:");
            string name = Console.ReadLine();
            Console.WriteLine("Anna vielä sukunimesi:");
            string surname = Console.ReadLine();
            
            Tervehdys(name, surname,ref age);
        }

    }

}