using System;

class digits
{
    static void Main()
    {
        int Number;
        Console.Write("Insert a number: ");
        Number = Convert.ToInt32(Console.ReadLine()); 
        if (Number / 10 == 0)   //All the numbers are divided by 10, 100 or 1000 to know the digits they have
        {
            Console.WriteLine("The number have 1 digits");
        }
        else
        {
            if (Number / 100 == 0)
            {
                Console.WriteLine("The number have 2 digits");
            }
            else
            {
                if (Number / 1000 == 0)
                {
                    Console.WriteLine("The number have 3 digits");
                }
                else
                {
                    Console.WriteLine("The number have 4 or more digits");
                }
            }
        }
    }
}

