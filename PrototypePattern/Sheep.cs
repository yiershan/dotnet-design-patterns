using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class Sheep 
    {
        public string Name { get; set; }
        public Sheep(string name) { this.Name = name; }

        public Sheep Clone()
        {
            return new Sheep(Name);
        }
    }
}
