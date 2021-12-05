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
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            if (Model == null) return;
            if (Model.GetStack(id).IsEmpty()) return;

            
            for (int i = 0; i < Model.GetStack(id).Count; i++) {
                Element el = Model.GetStack(id)[i];
                g.DrawRectangle(Pens.Black, el.X, el.Y, el.Width, el.Height);
            }
        }

    }
}
