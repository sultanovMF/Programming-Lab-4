using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Programming_Lab_4 {
    internal class LabelView : IView {
        IStackModel model;
        Label l;
        public LabelView(Label l) {
            this.l = l;
        }

        public IStackModel Model {
            get {
                return model;
            }
            set {
                model = value;
            }
        }

      
        public void UpdateView() {
            //l.Text = model.Count.ToString();
        }
    }
}
