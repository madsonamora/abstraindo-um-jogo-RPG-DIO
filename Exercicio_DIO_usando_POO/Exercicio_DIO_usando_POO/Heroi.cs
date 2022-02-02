namespace Exercicio_DIO_usando_POO
{
    public class Arus
    {
        public string name { get; set; }
        public int level { get; set; } = 0;
        public string heroType { get; set; }


        public Arus(string Name, int Level, string HeroType)
        {
            this.name = Name;
            this.level = Level;
            this.heroType = HeroType;

        }

        public override string ToString() { return name; }
        public string atack() { return name +" atacou"; }
    }
}
