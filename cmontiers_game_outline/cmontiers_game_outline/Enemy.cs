using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The enemy class controls each enemy on the screen and their drawing. 
/// </summary>

namespace cmontiers_game_outline
{
    class Enemy : Character
    {

        /*
         * 
         * since this class inherits from the character class, it will need all the methods contained in the character class
         * - update
         * - movement
         * - draw
         * - death
         *
         * the update method is what will be actually called in the update method in Game1, and the enemy's update method
         * will change it's code based on the overall gamestate.
         * 
         * The enemy should only require one movement method, since it will only ever move in the second segment of gameplay.
         * The enemy move method however will need helper methods not only to handle collisions, but to also properly path to
         * the player during the second segment of gameplay. look into pathfinding algorithms for this such as djikstra's or
         * a* pathfinding.
         * 
         * The enemystate will change based on the direction the enemy is facing and whether or not the enemy is currently
         * moving. The enemystate will then be used in the enemy's draw method to determine which enemy sprite should be drawn.
         * The draw method will be called in the appropriate spot in the game1 draw method to draw the enemy. 
         * 
         * 
         */
    }
}