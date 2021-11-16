using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Lab_3 {
    partial class Form1 : Form, IController {
        static Random r = new Random();
        IModel model;
        public Form1() {
            panelView1 = new PanelView();
            
            myDataGridView1 = new MyDataGridView();

            InitializeComponent();

            IView labView = new LabelView(label1);
            model = new MyModel();

            myDataGridView1.Model = model;
            AddView(myDataGridView1);

            labView.Model = model;
            AddView(labView);

            panelView1.Model = model;
            panelView1.NodeClicked += PanelView1_NodeClicked;
            AddView(panelView1);

            
        }

        private void PanelView1_NodeClicked(Node node) {
            model.RemoveNode(node);
        }

        public IModel Model {
            get {
                return model;
            }
            set {
                model = value;
            }
        }

        public void Add() {
            model.AddNode(r.Next(100));
        }
        public void AddView(IView v) {
            model.Changed += new Action(v.UpdateView);
        }


        public void Remove() {
            if (model.Count > 0)
                model.RemoveLastNode();
        }

        private void AddBtn_Click(object sender, EventArgs e) {
            Add();
        }

        private void RemoveBtn_Click(object sender, EventArgs e) {
            Remove();
        }

        private void panelView1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
