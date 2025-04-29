using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_7___Polymorphism.Entities
{
    public class General : Machine
    {
        public General(string name) : base(name)
        {}

        protected override int LifeSpanCostPerMinute => 1;

        public override void Use(int numberOfMinutes)
        {
            LifeSpan -= numberOfMinutes * LifeSpanCostPerMinute;
        }

        public override string ToString()
        {
            return $"{Name}, {LifeSpanInfo()}";
        }
    }
}
