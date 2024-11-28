using System;

class Program
{
    static void Main()
    {
        // Početni niz
        int[] array = { 12, 23, -22, -765, 43, 545, -4, -55, 43, 12, 351, -999, -87 };

        // Brojači za broj pozitivnih i negativnih brojeva
        int positiveCount = 0;
        int negativeCount = 0;

        // Prvi prolazak kroz niz kako bi se izbrojali pozitivni i negativni brojevi
        foreach (int num in array)
        {
            if (num > 0)
                positiveCount++;
            else if (num < 0)
                negativeCount++;
        }

        // Kreiranje nizova za pozitivne i negativne brojeve
        int[] positiveNumbers = new int[positiveCount];
        int[] negativeNumbers = new int[negativeCount];

        // Brojači za smeštanje brojeva u odgovarajuće nizove
        int positiveIndex = 0;
        int negativeIndex = 0;

        // Drugi prolazak kroz niz kako bi se upisali brojevi u odgovarajuće nizove
        foreach (int num in array)
        {
            if (num > 0)
            {
                positiveNumbers[positiveIndex] = num;
                positiveIndex++;
            }
            else if (num < 0)
            {
                negativeNumbers[negativeIndex] = num;
                negativeIndex++;
            }
        }

        // Ispisivanje pozitivnih brojeva
        Console.Write("Pozitivni brojevi: ");
        foreach (int num in positiveNumbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();

        // Ispisivanje negativnih brojeva
        Console.Write("Negativni brojevi: ");
        foreach (int num in negativeNumbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
    }
}
