using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoGame.Extended;

namespace RPG_Project
{
    class GamePlaying
    {
        private static Map theMap;
        private static Player myPlayer;
        private static Camera2D myCamera;

        public static void StartSession(Map pTheMap, Camera2D pTheCamera)
        {
            theMap = pTheMap;
            myPlayer = new Player(theMap.getSpawnPos, 10, Color.Red);
            myCamera = pTheCamera;
        }      

        public static void Update(GameTime gameTime)
        {
            myPlayer.Update(gameTime);
            Camera.Update(myPlayer, myCamera);
        }

        public static void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            theMap.Draw(spriteBatch);
            myPlayer.Draw(gameTime, spriteBatch);     
        }
    }
}
