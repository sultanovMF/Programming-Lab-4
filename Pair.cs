using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab_4 {
    internal class Pair {
        int first, second;
        public int First {
            get { return first; }
            set { first = value; }
        }

        public int Second {
            get { return second; }
            set { second = value; }
        }
        public Pair(int first, int second) {
            this.first = first;
            this.second = second;
        }
    }
}
