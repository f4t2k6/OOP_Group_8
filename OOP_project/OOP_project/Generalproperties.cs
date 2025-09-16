using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    public class Generalproperties
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

    }
}
