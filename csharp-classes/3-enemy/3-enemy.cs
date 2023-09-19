using System;

namespace Enemies
{
    ///<summary>
    /// A public class called Zombie.
    ///</summary>
    public class Zombie
    {
        ///<summary>
        /// A public int that gives a zombie health.
        ///</summary>

        public int health;

        ///<summary>
        /// A public constructor that specifies a health value.
        /// </summary>

        public Zombie()
        {
            health = 0;
        }

        ///<summary>
        /// A public constructor that specifies a positive health value.
        ///</summary>

        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        ///<summary>
        /// This is a getter for health.
        /// It returns the value of health.
        ///</summary>

        public int GetHealth()
        {
            return health;
        }
    }
}