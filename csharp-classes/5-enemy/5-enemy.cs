using System;

namespace Enemies
{
    ///<summary>
    /// Apublic class called Zombie.
    ///</summary>
    public class Zombie
    {
        private int health;
        private string name;

        ///<summary>
        /// A public constructor for Zombie.
        /// </summary>

        public Zombie()
        {
            
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
            name = "(No name)";
        }

        ///<summary>
        /// These are getters and setters for the name value of Zombies.
        ///</summary>

        public string Name
        {
            get { return name == null ? "(No name)" : name; }
            set { name = value; }
        }

        ///<summary>
        /// This is a getter for health.
        /// It returns the value of health.
        ///</summary>

        public int GetHealth()
        {
            return health;
        }

        ///<summary>
        /// This is a ToString override that allows users to view Zombie attributes.
        ///</summary>

        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}