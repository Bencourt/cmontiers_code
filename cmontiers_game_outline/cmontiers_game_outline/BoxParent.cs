using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is the parent class for all of the boxes that will be needed in the game
/// </summary>

namespace cmontiers_game_outline
{
    abstract class BoxParent
    {
        /*
         * 
         * As the box parent class, this class will contain all the information shared for each kind of box. This information
         * includes:
         * - movable via pushing
         * - movable via weapon
         * - can float in water
         * - set in a goal space
         * 
         * The box parent will then have an overridable movement method for each of the box children.
         * 
         */
    }
}
