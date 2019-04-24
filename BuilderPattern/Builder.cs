using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public sealed class Builder
    {
        public string Profession { get; private set; }
        public string Name { get; private set; }
        public string HairType { get; private set; }
        public string HairColor { get; private set; }
        public Builder(string profession, string name)
        {
            if (profession == null || name == null)
            {
                throw new Exception("profession 和 name 不能为空");
            }
            this.Profession = profession;
            this.Name = name;
        }

        public Builder WithHairType(string hairType)
        {
            this.HairType = hairType;
            return this;
        }

        public Builder WithHairColor(string hairColor)
        {
            this.HairColor = hairColor;
            return this;
        }
        public People Build()
        {
            return new People(this);
        }
    }
}
