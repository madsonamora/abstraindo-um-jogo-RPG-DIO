namespace Exercicio_DIO_usando_POO
{
    public  abstract class Hero
    {
        public string name { get; set; }
        public int level { get; set; } = 0;
        public string heroType { get; set; }


        public Hero(string Name, int Level, string HeroType)
        {
            this.name = Name;
            this.level = Level;
            this.heroType = HeroType;

        }

        public override string ToString() { return name; }
        public virtual string Atack() { return name +" atacou com a espada"; }
    }
}
