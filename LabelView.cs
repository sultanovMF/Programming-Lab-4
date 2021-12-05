using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
namespace Programming_Lab_4 {
    class LabelView : Label, IView{
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
            Text = model.Message();
        }
    }
}
