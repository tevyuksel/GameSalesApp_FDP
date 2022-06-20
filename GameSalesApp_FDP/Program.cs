using System;

namespace GameSalesApp_FDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Creater creater = new();

            IGame arcadeGame = creater.FactoryMethod(Games.Arcade);
            IGame pcGame = creater.FactoryMethod(Games.PC);
            IGame psGame = creater.FactoryMethod(Games.PS);

            arcadeGame.Platform();
            pcGame.Platform();
            psGame.Platform();

            Console.ReadLine();
        }
    }
}
