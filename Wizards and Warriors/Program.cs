using Wizards_and_Warriors;

namespace Wizards_and_Warriors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    abstract class Character
    {
        private string CharacterType;
        protected Character(string characterType)
        {
            CharacterType = characterType;
        }

        public abstract int DamagePoints(Character target);

        public bool isVulnerable = false;
        public virtual bool Vulnerable()
        {
            return isVulnerable;
        }

        public override string ToString()
        {
            return $"Character is a {CharacterType}";
        }
    }

    class Warrior : Character
    {
        public Warrior() : base(nameof(Warrior))
        {
        }

        public override int DamagePoints(Character target)
        {
            return target.Vulnerable() ? 10 : 6;
        }
    }

    class Wizard : Character
    {
        public Wizard() : base(nameof(Wizard))
        {
            isVulnerable = true;
        }

        public override int DamagePoints(Character target)
        {
            return Vulnerable() ? 3 : 12;
        }

        public void PrepareSpell()
        {
            base.isVulnerable = false;
        }
    }

}