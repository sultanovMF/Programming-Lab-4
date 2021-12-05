using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab_4 {
    class MyModel : IModel {
        public event Action Changed;
        LinkedList<Node> nodes = new LinkedList<Node>();

        static Random r = new Random();
        public int Count => nodes.Count;

        public LinkedList<Node> AllNodes => nodes;
        public void AddNode(int value) {
            nodes.AddFirst(new Node(value, r.Next(10), r.Next(10)));
            if (Changed != null) Changed();
        }
        public void RemoveNode(Node node) {
            nodes.Remove(node);
            if (Changed != null) Changed();
        }
        public void RemoveLastNode() {
            nodes.RemoveLast();
            if (Changed != null) Changed();
        }
    }
}
