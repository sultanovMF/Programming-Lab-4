using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Lab_3 {
    internal class MyDataGridView : DataGridView, IView {
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
            AutoGenerateColumns = true; // в таблице будут все public-свойства узлов
            DataSource = Model.AllNodes.ToArray();
        }
    }
}
