using System;
using System.Collections.Generic;
using System.Text;

namespace RocketWar
{
    class StrategicMissile : Rockets
    {
        protected override string RocketType { get; set; } = "Strategic missile";

        public StrategicMissile(MissilesSizes size, bool isNuclear) : base(size, isNuclear)
        {
        }
        public override string GetStatus()
        {
            return base.GetStatus();
        }

        public override string AmountChecker()
        {
            return base.AmountChecker();
        }

        public override void RadiusCalculator(int miles)
        {
            if (miles < 0)
                throw new ArgumentException("Количество миль не может быть меньше 0");
            RocketRadius *= (miles * 3);
        }
    }
}
