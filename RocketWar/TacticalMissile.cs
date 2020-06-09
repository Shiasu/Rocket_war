﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RocketWar
{
    class TacticalMissile : Rockets
    {
        protected override string RocketType { get; set; } = "Tactical missile";

        public TacticalMissile(bool isNuclear) : base(isNuclear)
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
            RocketRadius *= miles;
        }
    }
}
