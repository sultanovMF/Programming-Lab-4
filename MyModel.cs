using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab_3 {
    class MyModel : IModel {
        LinkedList<Node> nodes = new LinkedList<Node>();
        static Random r = new Random();
        public int Count => nodes.Count;

        public IEnumerable<Node> AllNodes => nodes;

        public void AddNode(int value) {
            nodes.AddFirst(new Node(value, r.Next(10), r.Next(10)));
        }

        public void RemoveLastNode() {
            nodes.RemoveLast();         
        }
    }
}
