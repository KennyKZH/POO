using System;
using System.Collections.Generic;
 
namespace actores
{
    class actores
    {
        private string nom;
        public actores(string n)
        {
            nom = n;
        }
        public void imprime()
        {
            Console.WriteLine(nom);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<actores> Actor = new List<actores>();
            Actor.Add(new actores("Osamu Mukai"));
            Actor.Add(new actores("Shota Matsuda"));
            Actor.Add(new actores("Toma Ikuta"));
            Actor.Add(new actores("Haruma Miura"));
 
            foreach(actores a in Actor)
            {
                a.imprime();
            }
            
        }
    }
}