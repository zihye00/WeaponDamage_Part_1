using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponDamage_Part_1
{
    internal class WeaponDamage
    {
        Random ran = new Random();
        public Random Ran { get { return ran; } }

        public int Damage { get; private set; }

        private int roll;
        public int Roll { get { return roll; } set { roll = value; CalculateDamage(); } }

        private bool magic;
        public bool Magic { get { return magic; } set { magic = value; CalculateDamage(); } }

        private bool flaming;
        public bool Flaming { get { return flaming; } set { flaming = value; CalculateDamage(); } }


        public virtual void CalculateDamage()
        {

        }
        public WeaponDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }
    }
}
}
