using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Runtime.InteropServices;

namespace Game1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D atom2;
        private Texture2D atom1;
        private Vector2 position;
        private Vector2 position2;
        private bool right;
        private bool up;
        private bool right2;
        private bool up2;
        private Vector2 obj1_1;
        private Vector2 obj1_2;
        private Vector2 obj1_3;
        private Vector2 obj1_4;
        private Vector2 obj2_1;
        private Vector2 obj2_2;
        private Vector2 obj2_3;
        private Vector2 obj2_4;
        private int width_image;
        private int height_image;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            position = new Vector2(250, 250);
            position2 = new Vector2(50, 50);
            width_image = 64 / 2;
            height_image = 68 / 2;
            obj1_1 = new Vector2(position.X + width_image,position.Y);
            obj1_2 = new Vector2(position.X + (width_image*2), position.Y + height_image);
            obj1_3 = new Vector2(position.X + width_image, position.Y + (height_image * 2));
            obj1_4 = new Vector2(position.X, position.Y + height_image);
            //
            obj2_1 = new Vector2(position2.X + width_image, position2.Y);
            obj2_2 = new Vector2(position2.X + (width_image * 2), position2.Y + height_image);
            obj2_3 = new Vector2(position2.X + width_image, position2.Y + (height_image * 2));
            obj2_4 = new Vector2(position2.X, position2.Y + height_image);



            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            atom1 = Content.Load<Texture2D>("2");
            atom2 = Content.Load<Texture2D>("1");

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            // En X
            if (position.X >= 730)
            {
                right = false;
            }
            else if (position.X <= 0)
            {
                right = true;
            }
            if (right == true)
            {
                position.X += 10;
            }
            else if (right == false)
            {
                position.X -= 10;
            }
            // En Y
            if (position.Y <= 0)
            {
               up = false;
            }
            else if (position.Y >= 418)
            {
                up = true;
            }
            if (up)
            {
                position.Y -= 10;
            }
            else if (up == false)
            {
                position.Y += 10;
            }

            // En X
            if (position2.X >= 730)
            {
                right2 = false;
            }
            else if (position2.X <= 0)
            {
                right2 = true;
            }
            if (right2 == true)
            {
                position2.X += 10;
            }
            else if (right2 == false)
            {
                position2.X -= 10;
            }
            // En Y
            if (position2.Y <= 0)
            {
                up2 = false;
            }
            else if (position2.Y >= 418)
            {
                up2 = true;
            }
            if (up2)
            {
                position2.Y -= 10;
            }
            else if (up2 == false)
            {
                position2.Y += 10;
            }

            //--------------------------------- Puntos de contacto

            obj1_1 = new Vector2(position.X + width_image, position.Y);
            obj1_2 = new Vector2(position.X + (width_image * 2), position.Y + height_image);
            obj1_3 = new Vector2(position.X + width_image, position.Y + (height_image * 2));
            obj1_4 = new Vector2(position.X, position.Y + height_image);

            obj2_1 = new Vector2(position2.X + width_image, position2.Y);
            obj2_2 = new Vector2(position2.X + (width_image * 2), position2.Y + height_image);
            obj2_3 = new Vector2(position2.X + width_image, position2.Y + (height_image * 2));
            obj2_4 = new Vector2(position2.X, position2.Y + height_image);

            if (obj1_1.X < obj2_2.X && obj1_1.X > obj2_4.X && obj1_1.Y < obj2_3.Y && obj1_1.Y > obj2_1.Y)
            {
                up = false;
                up2 = true;
                //System.Console.WriteLine("Punto 1: " + obj1_1 + " Punto 2: " + obj1_2 + " Punto 3: " + obj1_3 + " Punto 4: " + obj1_4);

                System.Console.WriteLine("Punto 1_1 X: " + obj1_1.X + " Punto 1_1 Y" + obj1_1.Y);
                System.Console.WriteLine("Punto 2_1 Y: " + obj2_1.Y + " Punto 2_2X: " + obj2_2.X + " Punto 2_3 Y: " + obj2_3.Y + " Punto 2_4 X: " + obj2_4.X);
            }
            else if (obj1_2.Y > obj2_1.Y && obj1_2.X < obj2_2.X && obj1_2.Y < obj2_3.Y && obj1_2.X > obj2_4.X)
            {
                right = false;
                right2 = true;
                //System.Console.WriteLine("Punto 1: " + obj1_1 + " Punto 2: " + obj1_2 + " Punto 3: " + obj1_3 + " Punto 4: " + obj1_4);

                //System.Console.WriteLine("Punto 1_1 X: " + obj1_1.X + " Punto 1_1 Y" + obj1_1.Y);
                //System.Console.WriteLine("Punto 2_1 Y: " + obj2_1.Y + " Punto 2_2X: " + obj2_2.X + " Punto 2_3 Y: " + obj2_3.Y + " Punto 2_4 X: " + obj2_4.X);
            }
            else if (obj1_3.Y > obj2_1.Y && obj1_3.X < obj2_2.X && obj1_3.Y < obj2_3.Y && obj1_3.X > obj2_4.X)
            {
                up = true;
                up2 = false;
                //System.Console.WriteLine("Punto 1: " + obj1_1 + " Punto 2: " + obj1_2 + " Punto 3: " + obj1_3 + " Punto 4: " + obj1_4);

                //System.Console.WriteLine("Punto 1_1 X: " + obj1_1.X + " Punto 1_1 Y" + obj1_1.Y);
                //System.Console.WriteLine("Punto 2_1 Y: " + obj2_1.Y + " Punto 2_2X: " + obj2_2.X + " Punto 2_3 Y: " + obj2_3.Y + " Punto 2_4 X: " + obj2_4.X);
            }
            else if (obj1_4.Y > obj2_1.Y && obj1_4.X < obj2_2.X && obj1_4.Y < obj2_3.Y && obj1_4.X > obj2_4.X)
            {
                right = true;
                right2 = false;
                //System.Console.WriteLine("Punto 1: " + obj1_1 + " Punto 2: " + obj1_2 + " Punto 3: " + obj1_3 + " Punto 4: " + obj1_4);

                //System.Console.WriteLine("Punto 1_1 X: " + obj1_1.X + " Punto 1_1 Y" + obj1_1.Y);
                //System.Console.WriteLine("Punto 2_1 Y: " + obj2_1.Y + " Punto 2_2X: " + obj2_2.X + " Punto 2_3 Y: " + obj2_3.Y + " Punto 2_4 X: " + obj2_4.X);
            }







            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.Draw(atom1, position, Color.White);

            spriteBatch.Draw(atom2, position2, Color.White);

            spriteBatch.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
