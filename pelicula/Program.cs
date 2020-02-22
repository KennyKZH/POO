using System;

namespace peliculas
{
    class peliculas
    {
        private string titulo;
        private int año;
        private string pais;
        private string director;

        public string gettitulo()
        {
           return titulo;
        }
          public int getaño()
        {
            return año;
        }
          public string getpais()
        {
            return pais;
        }
          public string getdirector()
        {
            return director;
        }
        public void settitulo(string titulo)
        {
            this.titulo=titulo;
        }
          public void setaño(int año)
        {
            this.año=año;
        }
          public void setpais(string pais)
        {
            this.pais=pais;
        }
          public void setdirector(string director)
        {
          this.director=director;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           peliculas objeto1 = new peliculas();
           objeto1.settitulo("Proyect Rampage");
           objeto1.setaño(2018);
           objeto1.setpais("Estados Unidos");
           objeto1.setdirector("Brad Peyton");
           Console.WriteLine("titulo: {0}",objeto1.gettitulo());
           Console.WriteLine("año: {0}",objeto1.getaño());
           Console.WriteLine("pais: {0}",objeto1.getpais());
           Console.WriteLine("director: {0}",objeto1.getdirector());
           Console.WriteLine("");

           peliculas objeto2 = new peliculas();
           objeto2.settitulo("Green Book");
           objeto2.setaño(2016);
           objeto2.setpais("Central Intelligence");
           objeto2.setdirector("Rawson Marshall Thurber");
           Console.WriteLine("titulo: {0}",objeto2.gettitulo());
           Console.WriteLine("año: {0}",objeto2.getaño());
           Console.WriteLine("pais: {0}",objeto2.getpais());
           Console.WriteLine("director: {0}",objeto2.getdirector());
        }
    }
}
