using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab_4 {
    interface IStackModel {
        event Action Changed;
        public Stack<Element> GetStack(int id);
        public void Draft();
        void Shift(int from, int to);
        void Undo();
        void UndoAll();

        public string Message();
    }
}
