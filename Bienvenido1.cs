using System;


public class Comparacion
{
    public static void Main(string[] args)
    {
        int numero1;
        int numero2;


        Console.Write("Escriba el primer entero:");
        numero1 = Convert.ToInt32(Console.ReadLine());


        Console.Write("Escriba el segundo entero:");
        numero2 = Convert.ToInt32(Console.ReadLine());


        if ( numero1 == numero2)
            Console.WriteLine("{0  == ¨{1", numero1, numero1 2 );

        if ( numero1  != numero2 )
                Console.WriteLine("{0 != {1", numero1, numero2 );

        if ( numero1 < numero2)
            Console.WriteLine("{0 < {1", numero1, numero2 );

        if ( numero1 > numero2)
            Console.WriteLine("{0 <= {1", numero1, numero2 );

        if ( numero1 >= numero2)
            Console.WriteLine("{0 >= {1", numero1, numero2 );


    }

}





















}