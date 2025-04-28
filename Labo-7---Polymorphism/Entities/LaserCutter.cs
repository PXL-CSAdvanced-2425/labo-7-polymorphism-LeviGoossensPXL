using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_7___Polymorphism.Entities
{
    public class LaserCutter : Router
    {
        public double Accuracy { get; set; }

        protected override int LifeSpanCostPerMinute => 1500;
        public LaserCutter(string name, double width, double length, double costPerMinute, double accuracy) :
            base(name, width, length, costPerMinute)
        {
            Accuracy = accuracy;
            LifeSpan = 5000;
        }
        public override void Use(int numberOfMinutes)
        {
            LifeSpan -= numberOfMinutes * LifeSpanCostPerMinute + 100;
        }

        public override string ToString()
        {
            return $"LASER: '{Name}', ({WorkSpaceWidth}x{WorkSpaceLength}), [accuracy: {Accuracy}], {LifeSpanInfo()}";
        }
    }
}
