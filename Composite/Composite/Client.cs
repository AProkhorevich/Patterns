using Composite.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Client
    {
        public void ClientCode(Component component)
        {
            Console.WriteLine($"Result: {component.Operation()}\n");
        }

        public void ClientCode(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }
            else
            {
                Console.WriteLine("Given component is not composite");
            }

            Console.WriteLine($"Result: {component1.Operation()}\n");
        }
    }
}
