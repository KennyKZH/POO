using System;
using System.Collections.Generic;

namespace Pelicula
{
    class pelicula
        {
        //Atributos
        private string Titulo;
        private int Año;
        private string Pais;
        private string Director;
        //Metodos
        public void setTitulo (string Titulo)
        {
            this.Titulo=Titulo;
        }
        public string getTitulo ()
        {
            return this.Titulo;
        }
        //Metodo Año
          public void setAño (int Año)
        {
            this.Año=Año;
        }
        public int getAño ()
        {
            return this.Año;
        }
        //Metodo Pais
         public void setPais (string Pais)
        {
            this.Pais=Pais;
        }
        public string getPais ()
        {
            return this.Pais;
        }
        //Metodo Director
         public void setDirector (string Director)
        {
            this.Director=Director;
        }
        public string getDirector ()
        {
            return this.Director;
        }

        public Peli(string T, int A)
        {
          this.Titulo=Titulo;
          this.Año=Año;
        }

        public void Imprime()
        {
            Console.WriteLine("{0}({1})",this.getTitulo(),this.getAño());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Objetos
            Peli P1=new Peli("Pelicula ganadora al oscar: The Mistery Island",2012);
            P1.Imprime(); 

            Peli P2=new Peli("Pelicula ganadora al oscar: Jumanji",2017);
            P2.Imprime();

            P1.setTitulo("The Mistery Island");
            P1.setAño(2012);
            P1.Titulo="The Mistery Island";
            P1.Año=2012;
            P1.Pais="Estados Unidos";
            P1.Director="Brendan Fraser";
            Console.WriteLine( "Pelicula Ganadora del Oscar: "+ P1.Titulo +"\nAño: " +P1.Año + "\nPais: : " + P1.Pais +"\nDirector:" + P1.Director);
            Console.WriteLine();

            P2.setTitulo("Jumanji");
            P2.setAño(2017);
            P2.Titulo="Jumanji";
            P2.Año=2017;
            P2.Pais="Estados Unidos";
            P2.Director="Dwayne Johnson";
            Console.WriteLine( "Pelicula Ganadora del Oscar: "+ P2.Titulo +"\nAño: " +P2.Año + "\nPais: : " + P2.Pais +"\nDirector:" + P2.Director );

        }
    }
}