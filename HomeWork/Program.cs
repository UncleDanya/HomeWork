using System;
namespace HomeWork
{
    class Work
    {
        static void Main()
        {
            Random random = new Random();
            int[] arrayRandom = new int[5];
            Console.WriteLine("Array random number ");

            for (int i = 0; i < arrayRandom.Length; i++)
            {
                arrayRandom[i] = random.Next(0, 100);
                Console.Write(arrayRandom[i] + " ");
            }
            Console.WriteLine("\nEven numbers from the array ");

            for (int i = 0; i < arrayRandom.Length; i++)
            {
                if (arrayRandom[i] % 2 == 0)
                {
                    Console.Write(arrayRandom[i] + " ");
                }
            }
            Console.WriteLine("\nSort array");
            int temp;
            for (int i = 0;i < arrayRandom.Length - 1; i++)
                for (int j = i + 1;j < arrayRandom.Length; j++)
                    if (arrayRandom[i] < arrayRandom[j])
                    {
                        temp = arrayRandom[i];
                        arrayRandom[i] = arrayRandom[j];
                        arrayRandom[j] = temp;
                    }
            foreach (int value in arrayRandom)
            {
                Console.Write(value + " ");
            }

        }
    }
}