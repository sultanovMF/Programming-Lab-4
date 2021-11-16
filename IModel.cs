using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab_3 {
    interface IModel {
        event Action Changed;
        LinkedList<Node> AllNodes { get; }
        void AddNode(int value);
        void RemoveLastNode();
        public void RemoveNode(Node node);
        int Count { get; }
    }
}
