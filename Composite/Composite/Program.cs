using Composite.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Leaf leaf = new Leaf();

            Console.WriteLine("Client: вывод простого компонента");
            client.ClientCode(leaf);

            Components.Composite tree = new Components.Composite();
            Components.Composite branch1 = new Components.Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Components.Composite branch2 = new Components.Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: вывод сложного компонента");
            client.ClientCode(tree);

            Console.WriteLine("Client: добавление компоненты");
            client.ClientCode(tree, leaf);

            Console.ReadLine();
        }
    }
}
