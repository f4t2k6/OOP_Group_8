using System;

/*
Các chiêu thức chung:
- CauseDMG: Atk - enemy Def
- TakeDMG: nhận sát thương, trừ vào CurrentHP
- BoostDef: dành ra 1 lượt để tăng Def thêm 40% cho lần sát thương kế tiếp

=================================================================================================
Hệ Lửa:
- Special Attack gắn hiệu ứng Burn với 5 ticks, mỗi tick gây dmg theo BurnDMG (bỏ qua enemy Def)

=================================================================================================
 NOTE:
- Add thêm các operator overloading
- Add thêm thanh mana
=================================================================================================
Skill:
- Mỗi pokemon sẽ có 3 chiêu: đánh thường, đánh đặc biệt, phòng thủ (đánh đặc biệt và phòng thủ tốn mana)
=================================================================================================
Quy tắc đặt tên 
 - Fields: Abcd
 - Properties: _abcd
 - Constructors: abcd_
*/

namespace GeneralProperties
{
    public class Character
    {
        //fields
        protected string Name;
        protected string Type;
        protected int Atk;
        protected int Def;
        protected int MaxHP;
        protected int MaxMana;
        protected Image Avatar;

        protected bool Used_BoostDef = false;
        protected int OgDef;
        protected int CurrentHP;
        protected int CurrentMana;

        //properties
        public string _name { get { return this.Name; } set { this.Name = value; } }
        public string _type { get { return this.Type; } set { this.Type = value; } }
        public int _atk { get { return this.Atk; } set { this.Atk = value; } }
        public int _def { get { return this.Def; } set { this.Def = value; } }
        public int _maxhp { get { return this.MaxHP; } set { this.MaxHP = value; } }
        public int _currenthp { get { return this.CurrentHP; } set { this.CurrentHP = value; } }
        public int _maxmana { get { return this.MaxMana; } set { this.MaxMana = value; } }
        public int _currentmana { get { return this.CurrentMana; } set { this.CurrentMana = value; } }
        public Image avatar { get { return this.Avatar; } set { this.Avatar = value; } }


        //constructors
        public Character()
        {
        }
        public Character(string name_, string type_, int atk_, int def_, int maxhp_, int maxmana_, Image avatar)
        {
            this.Name = name_;
            this.Type = type_;
            this.Atk = atk_;
            this.Def = def_;
            this.MaxHP = maxhp_;
            this.MaxMana = maxmana_;
            this.avatar = avatar;
            this.CurrentHP = this.MaxHP;        //gán máu ban đầu = máu tối đa
            this.OgDef = this.Def;              //gán def để reset = def ban đầu
            this.CurrentMana = 15;              //phải gán mana là chỉ số cố định từ đầu max chỉ là tham số không thể vượt qua 
        }

        //methods
        public void CauseDMG(Character enemy)
        {
            int dmg = this.Atk - enemy.Def;
            if (dmg < 0) dmg = 0;
            enemy.TakeDMG(dmg);
        }
        public void TakeDMG(int dmg)
        {
            this.CurrentHP -= dmg;
            if (this.CurrentHP < 0) this.CurrentHP = 0;

            if (Used_BoostDef)
            {
                this.Def = this.OgDef;
                Used_BoostDef = false;
            }
        }

        public void BoostDef()
        {
            if (!Used_BoostDef)
            {
                Used_BoostDef = true;
                this.Def += (this.Def * 40) / 100;
            }
        }

        public virtual void NormalAttack(Character enemy)
        {
            int dmg = this.Atk - enemy.Def;
            if (dmg < 0) dmg = 0;
            enemy.TakeDMG(dmg);
            _currentmana += 15;
        }
        public virtual void SpecialAttack(Character enemy)
        {
            int dmg = this.Atk + (this.Atk * 10) / 100 - enemy.Def;     //tăng sát thương thêm 10%
            if (dmg < 0) dmg = 0;
            enemy.TakeDMG(dmg);
            _currentmana -= 30;
        }
    }
    public class FireClass : Character
    {
        //fields
        private int BurnDmg;

        //constructors
        public FireClass(string name_, string type_, int atk_, int def_, int maxhp_, int maxmana_, Image avatar, int burndmg_) : base(name_, type_, atk_, def_, maxhp_, maxmana_, avatar)
        {
            this.BurnDmg = burndmg_;
        }

        //method
        public override void SpecialAttack(Character enemy)
        {
            base.SpecialAttack(enemy);

            Random rand = new Random();
            int tile = rand.Next(100);
            if (tile < 33)
            {
                enemy._currenthp -= this.BurnDmg;
                if (enemy._currenthp < 0)
                {
                    enemy._currenthp = 0;
                }
            }
        }

        public override void NormalAttack(Character enemy)
        {
            base.NormalAttack(enemy);
        }
    }


    public class WaterClass : Character
    {
        private int HealingHP;

        public int _healinghp;
        public WaterClass(string name_, string type_, int atk_, int def_, int maxhp_, int maxmana_, Image avatar, int healinghp_) : base(name_, type_, atk_, def_, maxhp_, maxmana_, avatar)
        {
            this.HealingHP = healinghp_;
        }

        public override void SpecialAttack(Character enemy)
        {
            base.SpecialAttack(enemy);
            Random rand = new Random();
            int tile = rand.Next(100);
            if (tile < 33)
            {
                _currenthp += _healinghp;
            }
        }
    }
}