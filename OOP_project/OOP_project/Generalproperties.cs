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
*/

namespace Gameplayscreen 
{
    public class Character
    {
        //fields
        protected string Name;
        protected string Type;
        protected int Atk;
        protected int Def;
        protected int MaxHP;

        protected bool Used_BoostDef = false;
        protected int OgDef;
        protected int CurrentHP;

        //properties
        public string _name { get { return this.Name; } set { this.Name = value; } }
        public string _type { get { return this.Type; } set { this.Type = value; } }
        public int _atk { get { return this.Atk; } set { this.Atk = value; } }
        public int _def { get { return this.Def; } set { this.Def = value; } }
        public int _maxhp { get { return this.MaxHP; } set { this.MaxHP = value; } }
        public int _currenthp { get { return this.CurrentHP; } set { this.CurrentHP = value; } }


        //constructors
        public Character(string name_, string type_, int atk_, int def_, int maxhp_)
        {
            this.Name = name_;
            this.Type = type_;
            this.Atk = atk_;
            this.Def = def_;
            this.MaxHP = maxhp_;
            this.CurrentHP = this.MaxHP;        //gán máu ban đầu = máu tối đa
            this.OgDef = this.Def;              //gán def để reset = def ban đầu
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

        public virtual void SpecialAttack(Character enemy)
        {
            int dmg = this.Atk + (this.Atk * 10) / 100 - enemy.Def;     //tăng sát thương thêm 10%
            if (dmg < 0) dmg = 0;
            enemy.TakeDMG(dmg);
        }
    }



    public class FireClass : Character
    {
        //fields
        private int BurnDmg;

        //constructors
        public FireClass(string name_, string type_, int atk_, int def_, int maxhp_, int burndmg_) : base(name_, type_, atk_, def_, maxhp_)
        {
            this.BurnDmg = burndmg_;
        }

        //method
        public override void SpecialAttack(Character enemy)
        {
            base.SpecialAttack(enemy);
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    enemy._currenthp -= this.BurnDmg;
                    if (enemy._currenthp < 0)
                    {
                        enemy._currenthp = 0;
                        break;
                    }
                }
            }
        }
    }

}