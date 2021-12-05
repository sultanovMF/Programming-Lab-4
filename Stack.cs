using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab_4 {
    internal class Stack  {
        public static readonly int MAX = 10;
        Element[] stack = new Element[MAX];
        int top;

        public Stack() {
            top = -1;
        }

        public int Top {
            get {
                return top;
            }

        }

        internal bool Push(Element el) {
            if (top >= MAX) {
                return false;
            } else {
                stack[++top] = el;
                return true;
            }
        }

        internal Element Pop() {
            if (top < 0) {
                throw new Exception("Stack underflow!");
            } 
            Element el = stack[top--];
            return el;
        }

        internal bool IsEmpty() {
            return (top < 0);
        }

        internal void Clear() {
            for (int i = 0; i <= top; i++ ) {
                Pop();
            }
        }
        public Element this[int key] {
            get => stack[key];
            set {
                stack[key] = value;
            }
        }
        public int Count => top + 1; 
        //public IEnumerator GetEnumerator() {
        //    return stack.GetEnumerator();
        //}
    }
}
