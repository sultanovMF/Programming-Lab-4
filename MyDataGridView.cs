using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Lab_3 {
    internal class MyDataGridView : DataGridView, IView {
        public IModel Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void UpdateView() {
            throw new NotImplementedException();
        }
    }
}
