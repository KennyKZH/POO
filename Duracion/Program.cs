using System;

namespace Duracion
{
    class Duracion
    {
    //Asignacion
    private int h; //Horas
    private int m; //Minutos
    private int s; //Segundos

    public Duracion(int h,int m,int s)
    {
        //Especificarlos
        this.h=h;
        this.m=m;
        this.s=s;
    }

    public Duracion(int min)
    {
        //Asignar 0 para que empiece el conteo desde 0
        this.h=0;
        this.s=0;
        //Reloj
        if(min>59)
        {
            for(int i=1;i<=24;i++)
            {
                if(min/60>=1)
                {
                    this.h=i;
                    min=min-60;
                }
            else
            {
                this.m=min;
                break;
                } 
            }
        }
    }
    //Imprimir
    public override string ToString()=>string.Format("{0}:{1}:{2}",this.h,this.m,this.s);
}

class Program
{
    static void Main()
    {
        //Imprimir
        Duracion a=new Duracion(7,35,45);
        Duracion b=new Duracion(350);
        Console.WriteLine(b);
    }
}
}
