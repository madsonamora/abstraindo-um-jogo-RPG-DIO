namespace Exercicio_DIO_usando_POO
{
    internal class Mago : Hero
    {
        public Mago(string Name, int Level, string HeroType) : base(Name, Level, HeroType) { }


        public override string Atack() { return name + " atacou com magia"; }
        public string Atack(int bonus)
        {

            if (bonus > 6)
            {
                return name + " atacou com magia forte";
            }
            else
                return name + " atacou com magia normal";
        }
    }
}
