using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_DIO_usando_POO
{
    internal class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }
        public override string Atack() { return name + " atacou com magia negra"; }
    }
}
