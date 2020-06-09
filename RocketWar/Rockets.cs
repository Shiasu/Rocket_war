using System;
using System.Collections.Generic;
using System.Text;

namespace RocketWar
{
    public abstract class Rockets
    {
        protected abstract string RocketType { get; set; }
        public int RocketsAmount { get; private set; } = 0;

        public int RocketDamage { get; private set; } = 1;

        public int RocketRadius { get; protected set; } = 1;

        public bool IsNuclear { get; private set; } = false;

        public Rockets(bool IsNuclear = false)
        {
            this.IsNuclear = IsNuclear;
        }

        public virtual string GetStatus()
        {
            string nuclear = this.IsNuclear ? "Да" : "Нет";
            return $"Всего ракет: {this.RocketsAmount}\n" +
                   $"Тип ракет: {this.RocketType}\n" +
                   $"Ядерный заряд: {nuclear}\n" +
                   $"Урон: {this.RocketDamage}\n" +
                   $"Дальность: {this.RocketRadius}";
        }

        public virtual string AmountChecker()
        {
            return $"{this.RocketsAmount} {this.RocketType} готовы к запуску!";
        }

        public virtual void RocketBuilder(int amount)
        {
            Console.WriteLine($"{amount} ракет построено!");
            RocketsAmount += amount;
        }

        public virtual void RocketLauncher(int amount)
        {
            Console.WriteLine($"{amount} ракет запущено!");
            RocketsAmount -= amount;
        }

        public virtual void DamageCalculator(int damage)
        {
            if (IsNuclear)
            {
                RocketDamage *= (damage * 5);
            }
            else
            {
                RocketDamage *= damage;
            }
            
        }
        public abstract void RadiusCalculator(int miles);
    }
}
