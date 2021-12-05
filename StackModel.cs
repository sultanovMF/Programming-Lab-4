using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab_4 {
    internal class StackModel : IStackModel {
        public event Action Changed;
        int move_id = 0;
        Stack<Pair> moves = new Stack<Pair>();
        Stack<Element>[] stacks = new Stack<Element>[3];
        string message;
        int panel_width;
        int panel_height;
        public StackModel(int width, int height) {
            panel_width = width;
            panel_height = height;
            stacks[0] = new Stack<Element>();
            stacks[1] = new Stack<Element>();
            stacks[2] = new Stack<Element>();
            Draft();
            message = "Готово к использованию!";
        }
        public Stack<Element> GetStack(int id) {
            return stacks[id];
        }

        public void Draft() {
            stacks[1].Clear();
            stacks[2].Clear();
            for (int i = 0; i < 10; i++) {
                int el_width = (int)(panel_width * ((10 - i) * 0.09));
                int el_height = (int)(panel_height / (10  + 1));
                int x = panel_width / 2 - el_width / 2;
                int y = panel_height - el_height * (i + 1) - 1;
                stacks[0].Push(new Element(el_width, el_height, x, y));
            }
            message = "Башни приведены к первоначальному состоянию!";
            if (Changed != null) Changed();
        }
        public void Shift(int from, int to) {
            moves.Push(new Pair(from, to));

            if (stacks[from].IsEmpty()) {
                message = "Перекладывать нечего!";
                if (Changed != null) Changed();
                return;
            }
            Element el = stacks[from].Pop();
            el.Y = panel_height - el.Height * (stacks[to].Top + 2) - 1;
            stacks[to].Push(el);
            message = $"Элемент был переложен с {from} на {to}";

            if (Changed != null) Changed();
        }

        public void Undo() {
            if (moves.Count > 0) {
                Pair move = moves.Pop();
                Shift(move.Second, move.First);
            }
        }
    }
}
