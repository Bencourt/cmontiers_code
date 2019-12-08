using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

//12/8/19
//Benjamin Lincourt
//created for cmontiers through Fiverr

namespace cmontiers_game_outline
{
    /// <summary>
    /// This is the main class of the game, and it will be where everything actually runs. 
    /// </summary>
    public class Game1 : Game
    {

        /*
         * 
         * Create any fields and properties for the actual running of the game and put them here.
         * These would be things like:
         *  - player and texture fields
         *  - enemy and texture fields
         *  - walls and floors (objects and textures)
         *  - goals (objects and textures)
         *  - all ui and style elements
         * 
         */



        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            //generally speaking, don't mess with this part unless you know exactly what you're doing.
            //it is very easy to break your entire game by changing any of this code
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

            /* instantiate any of the data structures and objects you may need such as:
             * - data structures for characters
             * - data structures for walls and their positions
             * - data structures for floors and their positions
             * - data structures for crates and their positions
             * - data structures for transporters and their positions
             * - Random object initialization
             * - set the correct gamestate
             */

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

            /* load all of the textures, fonts, spritesheets, effects, etc. that you will need for the game
             * 
             * using the information you just loaded, instantiate the objects for everything that will use the textures.
             * - player
             * - enemies
             * - walls
             * - floors
             * - boxes
             * - transporters
             * - ui elements
             */
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

            /*
             * 
             * This is where the main logic of the game goes. 
             * Not only will there be a switch statement to handle the changing of gamestates, but within each of the cases
             * of the switch statment there will be the code for the appropriate gamestate
             * 
             */

            /*
             * switch(gamestatefield)
             * {
             *      case startMenu:
             *          this is where you would put all the code for the control of your start menu
             *      break;
             *      
             *      case overworld:
             *          this is where you would put all the code for the control of your overworld
             *      break;
             *      
             *      case gamePlayFirst:
             *          this is where you would put all the code for the control of your first segment gameplay
             *      break;
             *      
             *      case gamePlaySecond:
             *          this is where you would put all the code for the control of your second segment gameplay
             *      break;
             *      
             *      case pauseMenu:
             *          this is where you would put all the code for the control of your pause menu
             *      break;
             *      
             *      case gameover:
             *          this is where you would put all the code for the control of your game over screen and menu
             *      break;
             * }
             */

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            //this line clears the screen
            GraphicsDevice.Clear(Color.CornflowerBlue);

            /*
             * 
             * this is where you will need another switch statement, similar to the one in the update method
             * this switch statement will draw the correct information and sprites to the screen based on the game state
             * 
             * switch(gamestatefield)
             * {
             *      case startMenu:
             *          this is where you would put all the code for the drawing of your start menu
             *      break;
             *      
             *      case overworld:
             *          this is where you would put all the code for the drawing of your overworld
             *      break;
             *      
             *      case gamePlayFirst:
             *          this is where you would put all the code for the drawing of your first segment gameplay
             *      break;
             *      
             *      case gamePlaySecond:
             *          this is where you would put all the code for the drawing of your second segment gameplay
             *      break;
             *      
             *      case pauseMenu:
             *          this is where you would put all the code for the drawing of your pause menu
             *      break;
             *      
             *      case gameover:
             *          this is where you would put all the code for the drawing of your game over screen and menu
             *      break;
             * }
             */

            base.Draw(gameTime);
        }
    }
}
