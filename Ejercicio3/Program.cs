using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];

        for (int i = 0; i < 5; i++)
            numeros[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 4; j++)
                if (numeros[j] > numeros[j + 1])
                {
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }

        for (int i = 0; i < 5; i++)
            Console.WriteLine(numeros[i]);
    }
}
