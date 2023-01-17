using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTask22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();
        }

        public void Run()
        {
            Osoba osoba = new Osoba();
            Osoba osoba1 = new Osoba("Tom", 4);
            Osoba osoba2 = new Osoba("Tom");

            string text = Osoba.Message();
            
        }
        
    }

     class Osoba
    {       
        public static int liczba = 0;
        private string Name;
        private int Id;
        public Osoba()
        {
            Name = "";
            Id = 0;
            liczba++;
        }

        public Osoba(string name, int id)
        {
            Name = name;
            Id = id;
            liczba++;
        }

        public Osoba(string name)
        {
            Name = name;
            Id += 1;
            liczba++;            
        }

        

        public static string Message()
        {
            string text = "";

            return text;
        }
       
        
    }
}
