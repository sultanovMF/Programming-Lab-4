using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab_4 {
    internal class StackModel : IStackModel {
        public event Action Changed;
        Stack[] stacks = new Stack[3];
        string message;
        public StackModel(int width, int height) {
            Draft(width, height);
            message = "Готово к использованию!";
        }
        public Stack GetStack(int id) {
            return stacks[id];
        }

        public void Draft(int width, int height) {
            stacks[1].Clear();
            stacks[2].Clear();
            for (int i = 0; i < Stack.MAX; i++) {
                int el_width = (int)((Stack.MAX - i) * width * 0.8);
                int el_height = (int)(height / Stack.MAX);
                int x = width / 2 - el_width / 2;
                int y = height - el_height * (i + 1);
                stacks[0].Push(new Element(el_width, el_height, x, y));
            }
            message = "Башни приведены к первоначальному состоянию!";
            if (Changed != null) Changed();
        }
        public void Shift(int from, int to) {
            if (stacks[from].IsEmpty()) {
                message = "Перекладывать нечего!";
                if (Changed != null) Changed();
                return;
            }
            stacks[to].Push(stacks[from].Pop());
            message = $"Элемент был переложен с {from} на {to}";

            if (Changed != null) Changed();
        }
    }
}
