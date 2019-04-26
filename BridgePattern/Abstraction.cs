using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public abstract class Abstraction
    {
        public Implementor _implementor {protected get; set; }
        public virtual void Operation() {
            _implementor.Operation();
        }
    }
    public class AbstractionRefined: Abstraction
    {
        public override void Operation()
        {
            base.Operation();
        }
    }
}
