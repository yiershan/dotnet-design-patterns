using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class People
    {
        private readonly string _profession;
        private readonly string _name;
        private string _hairType;
        private string _hairColor;

        public People(Builder builder)
        {
            this._profession = builder.Profession;
            this._name = builder.Name;
            this._hairColor = builder.HairColor??"黑";
            this._hairType = builder.HairType??"短发";
        }
        public string Show() {
            return string.Format("这个人的名字是{1}，职业是{0}，有一头{2}色的{3}",_profession,_name,_hairColor,_hairType);
        }
    }
}
