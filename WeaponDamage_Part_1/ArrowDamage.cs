using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponDamage_Part_1
{
     internal class ArrowDamage
    {
        private const decimal BASE_MULTIPLER = 0.35M;
        private const decimal MAGIC_MULTIPLER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;
        public int Damage { get; private set; }

        private int roll;
        public int Roll { get { return roll; } set { roll = value; CalculateDamage(); } }

        private bool magic;
        public bool Magic { get { return magic; } set { magic = value; CalculateDamage(); } }

        private bool flaming;
        public bool Flaming { get { return flaming; } set { flaming = value; CalculateDamage(); } }


        private void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLER;

            if (Magic) { baseDamage *= MAGIC_MULTIPLER; }
            if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
        }
        public ArrowDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }
    }
}
