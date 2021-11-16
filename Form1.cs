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
        List<IView> views = new List<IView>();
        static Random r = new Random();
        IModel model;
        public Form1() {
            InitializeComponent();
            IView labView;
            labView = new LabelView(label1);
            model = new MyModel();
            labView.Model = model;
            AddView(labView);
            UpdateView();
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
            UpdateView();
        }
        void UpdateView() {
            foreach (IView v in views) v.UpdateView();
        }
        public void AddView(IView v) {
            views.Add(v);
        }

        public void Remove() {
            if (model.Count > 0)
                model.RemoveLastNode();

            UpdateView();
        }

        private void AddBtn_Click(object sender, EventArgs e) {
            Add();
        }

        private void RemoveBtn_Click(object sender, EventArgs e) {
            Remove();
        }
    }
}
