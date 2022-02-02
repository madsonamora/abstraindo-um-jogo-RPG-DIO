using Exercicio_DIO_usando_POO;




Hero arus = new Knight("arus", 1, "wizard");
Mago mago = new Mago("mago", 2, "knight");
BlackWizard blackWizard = new BlackWizard("mago negro", 2, "black wizard");
Ninja ninja = new Ninja("ninja", 2, "ninja");

Console.WriteLine(arus.ToString());
Console.WriteLine(arus.Atack());
Console.WriteLine(mago.ToString());
Console.WriteLine(mago.Atack());
Console.WriteLine(mago.Atack(15));
Console.WriteLine(mago.Atack(2));
Console.WriteLine(blackWizard.Atack());
Console.WriteLine(ninja.Atack());

Console.ReadKey();