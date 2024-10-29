namespace WeaponDamage_Part_1
{
    internal class SwordDamage : WeaponDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;


        private void CalculateDamage() : WeapnDamage
        {
            decimal magicMultiplier = 1M;
            if (Magic) { magicMultiplier = 1.75M; }

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
        }
        public SwordDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }
    }
}
