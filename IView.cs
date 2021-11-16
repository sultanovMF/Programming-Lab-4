using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab_3 {
    interface IView {
        IModel Model { get; set; }
        void UpdateView();
    }
}
