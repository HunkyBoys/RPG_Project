using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Project
{
    class Camera
    {
        public static void Update(Player myPlayer, Camera2D myCam)
        {
            MainGame.setCameraPosition = myPlayer.GetPosition();
        }
    }
}
