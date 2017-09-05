using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace RPG_Project
{
    class MainGame : Game
    {
        public enum GameState
        {
            startMenu,
            gamePlaying
        }

        private GameState myGameState;

        private GraphicsDeviceManager manager;
        private Map myMap;
        private SpriteBatch spriteBatch;
        public static Camera2D camera;
        
        private List<Texture2D> Maps = new List<Texture2D>();
        private List<Texture2D> Spawns = new List<Texture2D>();

        //camera getter
        public static Camera2D getCamera
        {
            get { return camera; }
        }
        //camera positioner
        public static Vector2 setCameraPosition
        {
            set { camera.Position = value; }
        }
        public static void CamLookAt(Vector2 myVector2)
        {
            camera.LookAt(myVector2);
        }


        public static Texture2D floorTexture;
        public static Texture2D wallTexture;
        public static Texture2D spriteSheet;


        /// <summary>
        ///constructor
        /// </summary>
        public MainGame()
        {
            manager = new GraphicsDeviceManager(this);
            IsMouseVisible = true;
                     
        }
        //initializer
        protected override void Initialize()
        {
            base.Initialize();
            
            manager.PreferredBackBufferHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            manager.PreferredBackBufferWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;

            //manager.ToggleFullScreen();

            myGameState = GameState.gamePlaying;
            camera = new Camera2D(GraphicsDevice);
            spriteBatch = new SpriteBatch(GraphicsDevice);



            

        }
        /// <summary>
        /// Loading Content
        /// </summary>
        protected override void LoadContent()
        {
            
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            floorTexture = Content.Load<Texture2D>(@"Content\textures\texturefloor");
            wallTexture = Content.Load<Texture2D>(@"Content\textures\texturewall");
            spriteSheet = Content.Load<Texture2D>(@"Content\textures\spritesheet");

            Maps.Add(Content.Load<Texture2D>(@"Content\maps\4"));
            Spawns.Add(Content.Load<Texture2D>(@"Content\maps\2"));

            myMap = new Map(16, 16,Maps[0]);

            GamePlaying.StartSession(myMap, camera);
            base.LoadContent();
        }


        /// <summary>
        /// ticks
        /// </summary>
        protected override void Update(GameTime gameTime)
        {
            switch (myGameState)
            {
                case GameState.startMenu:
                    //menu update
                    break;
                case GameState.gamePlaying:
                    GamePlaying.Update(gameTime);
                    
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// Draw
        /// </summary>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.Black);
            spriteBatch.Begin(transformMatrix: camera.GetViewMatrix());

            switch (myGameState)
            {
                case GameState.startMenu:
                    //menu draw
                    break;
                case GameState.gamePlaying:
                    GamePlaying.Draw(gameTime, spriteBatch);
                    
                    break;
                default:
                    break;
            }

            spriteBatch.End();
        }

        
        ///
        ///unload content
        ///
        protected override void UnloadContent()
        {
            
        }


        
    }
}
