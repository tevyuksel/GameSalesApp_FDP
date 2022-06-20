using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesApp_FDP
{
    public class Creater
    {
        public IGame FactoryMethod(Games gameType)
        {
            IGame game = null;
            switch (gameType)
            {
                case Games.Arcade:
                    game = new Arcade();
                    break;
                case Games.PC:
                    game = new PC();
                    break;
                case Games.PS:
                    game = new PS();
                    break;
            }
            return game;
        }
    }
}
