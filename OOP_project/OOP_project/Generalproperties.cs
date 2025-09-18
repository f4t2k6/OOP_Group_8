using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManChoi
{
    //Thuộc tính chung của các nhân vật
    public class Character
    {
        //fields
        protected string name;
        protected int attack;
        protected int defense;
        protected int maxHP;
        protected int currentHP;

        //properties
        public string Name { get { return name; } set { name = value; } }
        public int Attack { get { return attack; } set { attack = value; } }
        public int Defense { get { return defense; } set { defense = value; } }
        public int MaxHP { get { return maxHP; } set { maxHP = value; } }
        public int CurrentHP { get { return currentHP; } set { currentHP = value; } }

        //constructor
        public Character(string _name, int _attack, int _defense, int _maxhp)
        {
            name = _name;
            attack = _attack;
            defense = _defense;
            maxHP = _maxhp;
        }

        //method
        public virtual void CauseDMG(Character enemy)
        {
            int dmg = Attack - enemy.Defense;
            if (dmg < 0)    dmg = 0;
            enemy.TakeDMG(dmg);
        }

        public void TakeDMG(int dmg)
        {
            CurrentHP -= dmg;
            if(CurrentHP < 0) CurrentHP = 0;
        }

        public void Def()
        {
            this.Defense += (this.Defense * 10) / 100;      //tăng chỉ số phòng thủ thêm 10%
        }
    }
    //Phân ra các Hệ
    public class Fire : Character
    {
        protected int Burn = 5;
        //constructor
        public Fire(string name, int attack, int defense, int maxhp) : base(name, attack, defense, maxhp)
        {
        }
   
        public void FireAttack(Character enemy)
        {
            int dmg = this.Attack + 10 - enemy.Defense;
        }

    }

    /*public class Generalproperties
    {
        protected string Name;
        protected int MaxHP;
        protected int CurrentHP;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int maxHP
        {
            get { return MaxHP; }
            set { MaxHP = value; }
        }

        public int currentHP
        {
            get { return CurrentHP; }
            set { CurrentHP = value; }
        }

        public Generalproperties(string _Name, int _MaxHP)
        {
            Name = _Name;
            MaxHP = _MaxHP;
            CurrentHP = MaxHP;
        }

        public void TakeDamage(int damage)
        {
            currentHP-=damage;
            if (CurrentHP < 0)
            {
                CurrentHP = 0;
            }
        }
    }
    */

}
