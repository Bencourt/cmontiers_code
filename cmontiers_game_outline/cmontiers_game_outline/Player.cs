using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is the player class, and it will hold all the player logic for things like movement, attacking, death, etc
/// </summary>

namespace cmontiers_game_outline
{
    class Player : Character
    {
        /*
         * 
         * since this class inherits from the character class, it will need all the methods contained in the character class
         * - update
         * - movement
         * - draw
         * - death
         * 
         * the update method is what will be actually called in the update method in Game1, and the player's update method
         * will change it's code based on the overall gamestate
         * 
         * two or more movement methods will be needed, since the player movement and control scheme will change based on 
         * the gamestate. One method should be single-press movement for the first segment gameplay, and the other method should
         * be constant movement for the second segment gameplay. Both of these movement methods will use helper methods to handle
         * collision with walls, boxes, and enemies. 
         * 
         * The playerstate will change based on the direction the player is facing and whether or not the player is currently
         * moving. The playerstate will then be used in the player's draw method to determine which player sprite should be drawn.
         * The draw method will be called in the appropriate spot in the game1 draw method to draw the player. 
         * 
         * The player will also need a shoot method called when necessary in the player update that can move certain boxes and 
         * stun the enemies. 
         * 
         */
    }
}
