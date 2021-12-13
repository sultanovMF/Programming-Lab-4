using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Lab_4 {
    partial class Form1 : Form, IController {
        static Random r = new Random();
        IStackModel model;
        public Form1() {
            this.rodPanelView0 = new RodPanelView(0);
            this.rodPanelView1 = new RodPanelView(1);
            this.rodPanelView2 = new RodPanelView(2);
            InitializeComponent();

            

            model = new StackModel(220, 187);
            Message.Model = model;
            rodPanelView0.Model = model;
            rodPanelView1.Model = model;
            rodPanelView2.Model = model;
            
            AddView(Message);
            AddView(rodPanelView0);
            AddView(rodPanelView1);
            AddView(rodPanelView2);
        }


        public IStackModel Model {
            get {
                return model;
            }
            set {
                model = value;
            }
        }

        public void AddView(IView v) {
            model.Changed += new Action(v.UpdateView);
        }


        public void From1to2_Click(object sender, EventArgs e) {
            model.Shift(0, 1);
        }

        public void From1to3_Click(object sender, EventArgs e) {
            model.Shift(0, 2);
        }

        public void From2to1_Click(object sender, EventArgs e) {
            model.Shift(1, 0);
        }
        public void From2to3_Click(object sender, EventArgs e) {
            model.Shift(1, 2);
        }
        public void From3to1_Click(object sender, EventArgs e) {
            model.Shift(2, 0);
        }
        public void From3to2_Click(object sender, EventArgs e) {
            model.Shift(2, 1);
        }

        public void CancelLast_Click(object sender, EventArgs e) {
            model.Undo();
        }
        public void Draft(object sender, EventArgs e) {
            model.UndoAll();
        }

        private void rodPanelView1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
