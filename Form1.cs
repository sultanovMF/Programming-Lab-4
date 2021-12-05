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
            rodPanelView0 = new RodPanelView(1);
            rodPanelView1 = new RodPanelView(2);
            InitializeComponent();
            model = new StackModel(250, 250);
            rodPanelView0.Model = model;
            AddView(rodPanelView0);
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

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
