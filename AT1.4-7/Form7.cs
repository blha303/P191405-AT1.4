// Steven Smith
// P191405
// Wed 19 Jul 00:00:10 2017
// Form control

using System;
using System.Windows.Forms;

namespace AT1_4_7 {
    public partial class Form7 : Form {
        public Form7() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            int one = int.Parse(tbInputOne.Text);
            int two = int.Parse(tbInputTwo.Text);
            ClearOutput();
            RunCal(one, two);
        }

        private void ClearOutput() {
            tbOneA.Clear();
            tbOneB.Clear();
            tbTwoA.Clear();
            tbTwoB.Clear();
            tbThreeA.Clear();
            tbThreeB.Clear();
            tbFinalA.Clear();
            tbFinalB.Clear();
        }

        private void RunCal(int a, int b) {
            // Row 1
            if (a > b) {
                int temp = b;
                b = a;
                a = temp;
                tbOneA.Text = a.ToString();
                tbOneB.Text = b.ToString();
            }
            // Row 2
            if ((Math.Cos(a)) < 0 || (Math.Cos(b) > 0)) {
                a = 1;
                b = 3;
                tbTwoA.Text = a.ToString();
                tbTwoB.Text = b.ToString();
            }
            int x = (a + b) / 2;
            // Row 3
            if (Math.Cos(x) > 0) {
                a = x;
                tbThreeA.Text = a.ToString();
            } else {
                b = x;
                tbThreeB.Text = b.ToString();
            }
            // Output
            tbFinalA.Text = a.ToString();
            tbFinalB.Text = b.ToString();
        }
    }
}
