using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesApp_FDP
{
    public class Arcade : IGame
    {
        public void Platform()
        {
            Console.WriteLine("Bu oyun Atari platformunda çalışmaktadır.");
        }
    }
}
