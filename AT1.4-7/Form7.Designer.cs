// Steven Smith
// P191405
// Tue 18 Jul 23:59:04 2017
// Form layout file

using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace AT1_4_7 {
    partial class Form7 {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
        }

        private void InitializeComponent() {
            // Added to try to fix bug with window not closing
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form7));
            if (this.components == null) {
                this.components = new Container();
            }
            // End added
            this.SuspendLayout();
            this.tbInputOneLbl = new Label();
            this.tbInputOneLbl.Location = new Point(58, 43);
            this.tbInputOneLbl.Name = "tbInputOneLbl";
            this.tbInputOneLbl.Text = "Input One";
            this.tbInputOneLbl.AutoSize = true;

            this.tbInputTwoLbl = new Label();
            this.tbInputTwoLbl.Location = new Point(173,43);
            this.tbInputTwoLbl.Name = "tbInputTwoLbl";
            this.tbInputTwoLbl.Text = "Input Two";
            this.tbInputTwoLbl.AutoSize = true;

            this.colALbl = new Label();
            this.colALbl.Location = new Point(71,132);
            this.colALbl.Name = "colALbl";
            this.colALbl.Text = "A:";
            this.colALbl.AutoSize = true;

            this.colBLbl = new Label();
            this.colBLbl.Location = new Point(190,132);
            this.colBLbl.Name = "colBLbl";
            this.colBLbl.Text = "B:";
            this.colBLbl.AutoSize = true;

            var RowLabelText = "IF:";
            this.row1Lbl = new Label();
            this.row1Lbl.Location = new Point(31,154);
            this.row1Lbl.Name = "row1Lbl";
            this.row1Lbl.Text = RowLabelText;
            this.row1Lbl.AutoSize = true;

            this.row2Lbl = new Label();
            this.row2Lbl.Location = new Point(31,179);
            this.row2Lbl.Name = "row2Lbl";
            this.row2Lbl.Text = RowLabelText;
            this.row2Lbl.AutoSize = true;

            this.row3Lbl = new Label();
            this.row3Lbl.Location = new Point(31,203);
            this.row3Lbl.Name = "row3Lbl";
            this.row3Lbl.Text = RowLabelText;
            this.row3Lbl.AutoSize = true;

            this.finalLbl = new Label();
            this.finalLbl.Location = new Point(14,235);
            this.finalLbl.Name = "finalLbl";
            this.finalLbl.Text = "Final:";
            this.finalLbl.AutoSize = true;

            this.btnStart = new Button();
            this.btnStart.Location = new Point(54,273);
            this.btnStart.Size = new Size(163,21);
            this.btnStart.TabIndex = 2;
            this.btnStart.Name = "btnStart";
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            this.btnClose = new Button();
            this.btnClose.Location = new Point(290, 0);
            this.btnClose.Size = new Size(10, 10);
            this.btnClose.TabIndex = 3;
            this.btnClose.Name = "btnClose";
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            Size TBSize = new Size(45,20);

            this.tbInputOne = new TextBox();
            this.tbInputOne.Location = new Point(55,75);
            this.tbInputOne.Size = TBSize;
            this.tbInputOne.Name = "tbInputOne";
            this.tbInputOne.TabIndex = 0;

            this.tbInputTwo = new TextBox();
            this.tbInputTwo.Location = new Point(175,75);
            this.tbInputTwo.Size = TBSize;
            this.tbInputTwo.Name = "tbInputTwo";
            this.tbInputTwo.TabIndex = 1;

            // 55 175
            // 150 177 203 230
            /** I confused the order of these points initially, the first four had an x of 55 because
             * I wrote out all these with a misunderstanding of the layout of the program. I fixed it
             * after the unexpected behaviour that happens when your textboxes are in the wrong order
             */
            this.tbOneA = new TextBox();
            this.tbOneA.Location = new Point(55,150);
            this.tbOneA.Size = TBSize;
            this.tbOneA.Enabled = false;
            this.tbOneA.Name = "tbOneA";

            this.tbOneB = new TextBox();
            this.tbOneB.Location = new Point(175,150);
            this.tbOneB.Size = TBSize;
            this.tbOneB.Enabled = false;
            this.tbOneB.Name = "tbOneB";

            this.tbTwoA = new TextBox();
            this.tbTwoA.Location = new Point(55,177);
            this.tbTwoA.Size = TBSize;
            this.tbTwoA.Enabled = false;
            this.tbTwoA.Name = "tbTwoA";

            this.tbTwoB = new TextBox();
            this.tbTwoB.Location = new Point(175,177);
            this.tbTwoB.Size = TBSize;
            this.tbTwoB.Enabled = false;
            this.tbTwoB.Name = "tbTwoB";

            this.tbThreeA = new TextBox();
            this.tbThreeA.Location = new Point(55,203);
            this.tbThreeA.Size = TBSize;
            this.tbThreeA.Enabled = false;
            this.tbThreeA.Name = "tbThreeA";

            this.tbThreeB = new TextBox();
            this.tbThreeB.Location = new Point(175,203);
            this.tbThreeB.Size = TBSize;
            this.tbThreeB.Enabled = false;
            this.tbThreeB.Name = "tbThreeB";

            this.tbFinalA = new TextBox();
            this.tbFinalA.Location = new Point(55,230);
            this.tbFinalA.Size = TBSize;
            this.tbFinalA.Enabled = false;
            this.tbFinalA.Name = "tbFinalA";

            this.tbFinalB = new TextBox();
            this.tbFinalB.Location = new Point(175,230);
            this.tbFinalB.Size = TBSize;
            this.tbFinalB.Enabled = false;
            this.tbFinalB.Name = "tbFinalB";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 344);
            this.Controls.Add(this.tbInputOneLbl);
            this.Controls.Add(this.tbInputTwoLbl);
            this.Controls.Add(this.colALbl);
            this.Controls.Add(this.colBLbl);
            this.Controls.Add(this.row1Lbl);
            this.Controls.Add(this.row2Lbl);
            this.Controls.Add(this.row3Lbl);
            this.Controls.Add(this.finalLbl);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbInputOne);
            this.Controls.Add(this.tbInputTwo);
            this.Controls.Add(this.tbOneA);
            this.Controls.Add(this.tbOneB);
            this.Controls.Add(this.tbTwoA);
            this.Controls.Add(this.tbTwoB);
            this.Controls.Add(this.tbThreeA);
            this.Controls.Add(this.tbThreeB);
            this.Controls.Add(this.tbFinalA);
            this.Controls.Add(this.tbFinalB);
            this.Name = "Form7";
            this.Text = "White Box";

            // Added to try to fix bug with window not closing
            foreach (System.ComponentModel.IComponent control in this.Controls) {
                this.components.Add(control);
            }
            // End added

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label tbInputOneLbl; // Input One
        private Label tbInputTwoLbl; // Input Two
        private Label colALbl; // A:
        private Label colBLbl; // B:
        private Label row1Lbl; // IF:
        private Label row2Lbl; // IF:
        private Label row3Lbl; // IF:
        private Label finalLbl; // Final:
        private Button btnStart; // Start
        private Button btnClose;
        private TextBox tbInputOne;
        private TextBox tbInputTwo;
        private TextBox tbOneA;
        private TextBox tbOneB;
        private TextBox tbTwoA;
        private TextBox tbTwoB;
        private TextBox tbThreeA;
        private TextBox tbThreeB;
        private TextBox tbFinalA;
        private TextBox tbFinalB;
    }
}
