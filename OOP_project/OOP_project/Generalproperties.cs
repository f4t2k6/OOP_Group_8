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
        protected string type;
        protected int attack;
        protected int defense;
        protected int maxHP;
        protected int currentHP;

        //properties
        public string Name { get { return name; } set { name = value; } }
        public string Type { get { return type; } set { type = value; } }
        public int Attack { get { return attack; } set { attack = value; } }
        public int Defense { get { return defense; } set { defense = value; } }
        public int MaxHP { get { return maxHP; } set { maxHP = value; } }
        public int CurrentHP { get { return currentHP; } set { currentHP = value; } }

        //constructor
        public Character(string _name, string _type, int _attack, int _defense, int _maxhp)
        {
            name = _name;
            type = _type;
            attack = _attack;
            defense = _defense;
            maxHP = _maxhp;
            currentHP = maxHP;
        }

        //method
        public virtual void CauseDMG(Character enemy)
        {
            int dmg = this.Attack - enemy.Defense;
            if (dmg < 0) dmg = 0;
            enemy.TakeDMG(dmg);
        }

        public void TakeDMG(int dmg)
        {
            this.CurrentHP -= dmg;
            if (CurrentHP < 0) CurrentHP = 0;
        }

        public void Def()
        {
            this.Defense += (this.Defense * 20) / 100;      //tăng chỉ số phòng thủ thêm 20%
        }
    }

    public class Effect
    {
        //properties
        public string EffectName { get; set; }
        public int Duration { get; set; }
        public int EffectDMG { get; set; }
        public int Tick { get; set; }
        public DateTime StartTime { get; set; }

        //constructor
        public Effect(string effectName, int duration, int effectdmg, int tick)
        {
            EffectName = effectName;
            Duration = duration;
            EffectDMG = effectdmg;
            Tick = tick;
        }

        //method
        public void FireEffect(Effect effect, Character enemy)
        {
            effect.StartTime = DateTime.Now;
            DateTime lastTime = StartTime;
            while ((DateTime.Now - StartTime).TotalSeconds < Duration + 1)       //kiểm tra thời gian khả dụng hiệu ứng
            {
                if ((DateTime.Now - lastTime).TotalSeconds >= Tick)      //nếu lớn hơn tick, kích hoạt hiệu ứng
                {
                    enemy.CurrentHP -= EffectDMG;
                    Console.WriteLine("Current HP: " + enemy.CurrentHP);
                    lastTime = DateTime.Now;
                }
            }
        }
    }

    //---------------------------------------------------------------------------------------------
    //Phân ra các Hệ

    public class Pro
    {
        static void Main(string[] args)
        {
            Character a = new Character("Pikachu", "Electro", 20, 10, 1000);
            Effect burn = new Effect("Burn", 8, 5, 3);
            Console.WriteLine(a.Name + " , " + a.CurrentHP);
            burn.FireEffect(burn, a);
        }
    }

    //---------------------------------------------------------------------------------------------
    //Tấn công hệ lửa 
    public class Fire : Character
    {
        public Fire(string _name, string _type, int _attack, int _defense, int _maxhp) : base(_name, _type, _attack, _defense, _maxhp)
        {
        }

        public void FireAttack(Character enemy)
        {
            Random rand= new Random();
            int tile=rand.Next(1, 3);
            if (tile == 1)
            {
                int dmg = this.Attack + 20 - enemy.Defense;
                Effect burn = new Effect("Burn", 10, 5, 1);
                burn.FireEffect(burn, enemy);
                enemy.TakeDMG(dmg);
            }

            else
            {
                int dmg = this.Attack + 20 - enemy.Defense;
                enemy.TakeDMG(dmg);
            }

        }
    }

    //----------------------------------------------------------------------------------------------
    //Tấn công hệ điện 

    public class Electric : Character
    {
        protected int ReducedDefense = 40;
        public Electric(string _name, string _type, int _attack, int _defense, int _maxhp) : base(_name,_type,_attack,_defense,_maxhp)
        {
        }

        public void ElectricAttack(Character enemy)
        {
            Random rand = new Random();
            int tile = rand.Next(4, 6);
            if (tile == 4)
            {
                int dmg = this.Attack + 20 - enemy.Defense + ReducedDefense;
                enemy.TakeDMG(dmg);
            }

            else
            {
                int dmg = this.Attack + 20 - enemy.Defense;
                enemy.TakeDMG(dmg);
            }
        }
    }

}
