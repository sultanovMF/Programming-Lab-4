using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Programming_Lab_4 {
    internal class RodPanelView : Panel, IView {
        int id;

        public RodPanelView(int id) => this.id = id;

        IStackModel model;
        public IStackModel Model {
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

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            if (Model == null) return;
            Graphics g = e.Graphics;
            foreach (Element el in Model.GetStack(id)) { 
                g.DrawRectangle(Pens.Black, el.X, el.Y, el.Width, el.Height);
            }
            //base.OnPaint(e);
            //if (Model == null) return;
            //Graphics g = e.Graphics;
            //foreach (Node n in Model.AllNodes) {
            //    g.DrawRectangle(Pens.Black, n.X * 20, n.Y * 20, 20, 20);
            //}
        }

    }
}
