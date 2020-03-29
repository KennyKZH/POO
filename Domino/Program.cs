using System;

namespace Domino
{
    class Domino
    {
    //Asignar espacios
    private int esp1;
    private int esp2;

    //Constructor de 0 y 6
    public Domino(int esp1,int esp2)
    {
        if((esp1>6)|(esp1<0))this.esp1=0;
        else this.esp1=esp1;
        
        if((esp2>6)|(esp2<0))this.esp2=0;
        else this.esp2=esp2;
    }

    //Get para espacios
    public int getesp1()=>esp1;
    public int getesp2()=>esp2;

    //Imprimir
    public override string ToString()=>String.Format(" {0}\n|-|\n {1}\n",this.esp1,this.esp2);

    //Operador del domino x y
    public static int operator +(Domino x,Domino y)
    {
        return y.getesp1()+y.getesp2()+x.getesp1()+x.getesp2();
    }
}

class Program
{
    static void Main()
    {
        //No. para imprimir
        Domino a=new Domino(5,6);
        Console.WriteLine(a);

        //No. Para imprimir
        Domino b=new Domino(0,1);
        Console.WriteLine(b);

        //Suma de las fichas
        int suma= a + b;

        //Total de la suma
        Console.Write("La suma es de: "+ suma);
    }
}
}