using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab_4 {
    internal class Element {
        int width;
        int height;
        int x, y;

        public Element(int width, int height, int x, int y){
            
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }
        public int Width {
            get {
                return width;
            }

            set {
                width = value;
            }
        }
        public int Height {
            get {
                return height;
            }

            set {
                height = value;
            }
        }
        public int X {
            get {
                return x;
            }

            set {
                x = value;
            }

        }
        public int Y {
            get {
                return y;
            }

            set {
                y = value;
            }

        }


    }
}
