using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_7___Polymorphism.Entities
{
    public class Router : Machine
    {
        #region Properties
        public double WorkSpaceWidth { get; set; }
        public double WorkSpaceLength { get; set; }
        public double CostPerMinute { get; set; }
        protected override int LifeSpanCostPerMinute => 50;
        #endregion

        #region Constructors
        public Router(string name, double width, double length, double costPerMinute) : base(name)
        {
            WorkSpaceWidth = width;
            WorkSpaceLength = length;
            CostPerMinute = costPerMinute;

            LifeSpan = 25000;
        }
        #endregion

        #region Methods
        public override void Use(int numberOfMinutes)
        {
            LifeSpan -= numberOfMinutes * LifeSpanCostPerMinute;
        }

        public override string ToString()
        {
            return $"ROUTER: '{Name}', ({WorkSpaceWidth}x{WorkSpaceLength}), <{LifeSpanInfo()}>";
        }
        #endregion
    }
}
