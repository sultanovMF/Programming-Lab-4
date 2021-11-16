using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab_3 {
    interface IModel {
        void AddNode(int value);
        void RemoveLastNode();
        int Count { get; }
    }
}
