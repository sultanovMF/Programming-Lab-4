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
            rodPanelView0 = new RodPanelView(0);
            rodPanelView1 = new RodPanelView(1);
            rodPanelView2 = new RodPanelView(2);
            //Message = new LabelView();
            InitializeComponent();
            model = new StackModel(250, 250);
            rodPanelView0.Model = model;
            rodPanelView1.Model = model;
            rodPanelView2.Model = model;
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

        public void Add() {
            //model.AddNode(r.Next(100));
        }
        public void AddView(IView v) {
            model.Changed += new Action(v.UpdateView);
        }


        public void Remove() {
            //if (model.Count > 0)
            //    model.RemoveLastNode();
        }

        private void From1to2_Click(object sender, EventArgs e) {
            model.Shift(0, 1);
        }

        private void From1to3_Click(object sender, EventArgs e) {
            model.Shift(0, 2);
        }

        private void From2to1_Click(object sender, EventArgs e) {
            model.Shift(1, 0);
        }
        private void From2to3_Click(object sender, EventArgs e) {
            model.Shift(1, 2);
        }
        private void From3to1_Click(object sender, EventArgs e) {
            model.Shift(2, 0);
        }
        private void From3to2_Click(object sender, EventArgs e) {
            model.Shift(2, 1);
        }

        private void CancelLast_Click(object sender, EventArgs e) {
            model.Undo();
        }
        private void Draft(object sender, EventArgs e) {
            model.UndoAll();
        }
    }
}
