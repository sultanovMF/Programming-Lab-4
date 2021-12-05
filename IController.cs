using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Lab_4 {
   interface IController {
        IStackModel Model { get; set; }
        public void From1to2_Click(object sender, EventArgs e);
        public void From1to3_Click(object sender, EventArgs e);
        public void From2to1_Click(object sender, EventArgs e);
        public void From2to3_Click(object sender, EventArgs e);
        public void From3to1_Click(object sender, EventArgs e);
        public void From3to2_Click(object sender, EventArgs e);
        public void CancelLast_Click(object sender, EventArgs e);
        public void Draft(object sender, EventArgs e);
        
    }
}
