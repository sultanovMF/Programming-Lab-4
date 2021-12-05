using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab_4 {
    internal interface IStackModel {
        event Action Changed;
        public Stack GetStack(int id);
        public void Draft(int width, int height);
        void Shift(int from, int to);
        //LinkedList<Node> AllNodes { get; }
        //void AddNode(int value);
        //void RemoveLastNode();
        //public void RemoveNode(Node node);
        //int Count { get; }
    }
}
