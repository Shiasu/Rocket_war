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

        public bool IsNuclear { get; private set; }
        public MissilesSizes Size { get; private set; }

        public Rockets(MissilesSizes size, bool IsNuclear = false)
        {
            this.Size = size;
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
            if (amount < 0)
                throw new ArgumentException("Количество построенных ракет не может быть меньше 0");
            Console.WriteLine($"{amount} ракет построено!");
            RocketsAmount += amount;
        }

        public virtual void RocketLauncher(int amount)
        {
            if (amount < 0)
                throw new ArgumentException("Количество запущенных ракет не может быть меньше 0");
            Console.WriteLine($"{amount} ракет запущено!");
            RocketsAmount -= amount;
        }

        public virtual void DamageCalculator(int damage)
        {
            if (damage < 1)
                throw new ArgumentException("Количество урона не может быть меньше 1");

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
