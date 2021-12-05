using System;

namespace ConsoleApps
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int magicNumber = rnd.Next(1, 10);
            int lifes = 5;
            int lastLifes = 5;

            for(var i = 1; i <= lifes ; i++)
            {
                try
                {
                    Console.WriteLine("Rentrez un nombre entre 1 et 10 :");
                    string userNumberStr = Console.ReadLine();
                    int userNumber = int.Parse(userNumberStr);

                    

                    if (userNumber != magicNumber)
                    {
                        if (userNumber > magicNumber)
                        {
                            Console.WriteLine("Le nombre magique est plus petit...");
                            
                        }
                        else
                        {
                            Console.WriteLine("Le nombre magique est plus grand...");
                        }
                        lastLifes -= 1;
                        Console.WriteLine("Il vous reste " + lastLifes + " vies.");
                    }
                    else
                    {
                        Console.WriteLine("Bravo");
                        i = 6;
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur");
                    break;
                }
                
            }
          
        }
    }
}
