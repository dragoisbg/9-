using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._01._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string listOFBeers = "Amstel,Zgorka,Tuborg,Beks.";
            string[] beers = listOFBeers.Split(' ', ',', '.');
            Console.WriteLine("Avaible beers are:");
            foreach (string beer in beers)
                Console.WriteLine(beer);

            string az = "Az Dragomir obicham da pia voda";
            string[] name = az.Split(' ', ',', '.');
            Console.WriteLine("Avaible az are");
            Console.WriteLine("zavurshih zashtoto:");
           

            foreach (string ime in name)
                Console.WriteLine(ime);

            string replaced = listOFBeers.Replace(",", " ");
            //vodka and martini and cherry

            Console.WriteLine(replaced);

            string novo = replaced.Remove(9, 4);
            Console.WriteLine(novo);

            string lowerAlpha = novo.ToLower();
            Console.WriteLine(lowerAlpha);

            string upperAlpha = az.ToUpper();
            Console.WriteLine(upperAlpha);

            string novo1 = az.Replace("voda,", " Martini");


            string novo2 = az.Remove(27, 4);
            Console.WriteLine(novo);
         
                

             



        }
    }
}
