using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Components
{
    public class Composite : Component
    {
        protected List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            this._children.Add(component);
        }

        public override string Operation()
        {
            string res = "Branch(";

            int i = 0;

            foreach(var component in this._children)
            {
                res += component.Operation();

                if (i != this._children.Count - 1)
                {
                    res += " + ";
                }

                i++;
            }
            return res;

        }

        public override void Remove(Component component)
        {
            this._children.Remove(component);
        }
    }
}
