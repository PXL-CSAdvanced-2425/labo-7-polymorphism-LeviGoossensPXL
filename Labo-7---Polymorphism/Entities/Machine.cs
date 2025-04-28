using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_7___Polymorphism.Entities
{
    public abstract class Machine
    {
        #region Properties
        public string Name { get; set; }
        public int LifeSpan { get; set; }
        public float Price { get; set; }
        public bool OutOfUse => LifeSpan <= 0;

        protected abstract int LifeSpanCostPerMinute { get; }
        #endregion

        #region Constructors
        protected Machine(string name)
        {
            Name = name;
        }
        #endregion

        #region Methods
        public abstract void Use(int numberOfMinutes);

        public string LifeSpanInfo()
        {
            if (OutOfUse)
            { 
                return "OUT OF USE";
            }
            return $"<Lifespan: {LifeSpan} h>";
        }

        public override string ToString()
        {
            return LifeSpanInfo();
        }
        #endregion
    }
}
