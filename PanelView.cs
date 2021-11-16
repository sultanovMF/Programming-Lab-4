using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Programming_Lab_3 {
    delegate void NodeClicked(Node node);
    internal class PanelView : Panel, IView {
        public event NodeClicked NodeClicked;
        IModel model;
        public IModel Model {
            get {
                return model;
            }
            set {
                model = value;
            }
        }
      
        public void UpdateView() {
            Invalidate();
        }
        protected override void OnMouseClick(MouseEventArgs e) { 
            Node? last = null;
            foreach (Node n in Model.AllNodes) {
                if (((n.X * 20 + 10 - e.X) * (n.X * 20 + 10 - e.X) + (n.Y * 20 + 10 - e.Y) * (n.Y * 20 + 10 - e.Y)) <= 100) {
                    last = n;
                }
            }
            if (last != null) {
                NodeClicked(last);
            }
        
        }
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            if (Model == null) return;
            Graphics g = e.Graphics;
            foreach (Node n in Model.AllNodes) {
                g.DrawEllipse(Pens.Red, n.X * 20, n.Y * 20, 20, 20);
            }
        }


    }
}
