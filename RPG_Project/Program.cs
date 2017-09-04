using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Project
{
    class Program
    {
        //main instantiation point for game
        static void Main(string[] args)
        {
            //disposer
            using (MainGame ourGame = new MainGame())
            {
                //run game
                ourGame.Run();
            }
        }
        //debug console print
        static void Print(string inString)
        {
            Console.Write(inString);
        }
    }
}
