using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПрактическаяРабота3.classes
{
    public class PersonInfo
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Armor {  get; set; }
        public int Level { get; set; }
        public int Glasses { get; set; }
        public int Money { get; set; }
        public float Damage { get; set; }

        public PersonInfo(string Name, int Health, int Armor, int Level, int Glasses, int Money, float Damage)
        {
            this.Name = Name;
            this.Health = Health;
            this.Armor = Armor;
            this.Level = Level;
            this.Glasses = Glasses;
            this.Money = Money;
            this.Damage = Damage;

        }

    }
}
