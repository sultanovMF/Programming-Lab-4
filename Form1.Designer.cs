namespace Programming_Lab_4 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.rodPanelView0 = new Programming_Lab_4.RodPanelView(0);
            this.rodPanelView1 = new Programming_Lab_4.RodPanelView(1);
            this.rodPanelView2 = new Programming_Lab_4.RodPanelView(2);
            this.From1to2 = new System.Windows.Forms.Button();
            this.From1to3 = new System.Windows.Forms.Button();
            this.From2to1 = new System.Windows.Forms.Button();
            this.From3to1 = new System.Windows.Forms.Button();
            this.From2to3 = new System.Windows.Forms.Button();
            this.From3to2 = new System.Windows.Forms.Button();
            this.Drop = new System.Windows.Forms.Button();
            this.CancelLast = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rodPanelView0
            // 
            this.rodPanelView0.Location = new System.Drawing.Point(12, 12);
            this.rodPanelView0.Model = null;
            this.rodPanelView0.Name = "rodPanelView0";
            this.rodPanelView0.Size = new System.Drawing.Size(250, 250);
            this.rodPanelView0.TabIndex = 2;
            // 
            // rodPanelView1
            // 
            this.rodPanelView1.Location = new System.Drawing.Point(268, 12);
            this.rodPanelView1.Model = null;
            this.rodPanelView1.Name = "rodPanelView1";
            this.rodPanelView1.Size = new System.Drawing.Size(250, 250);
            this.rodPanelView1.TabIndex = 3;
            // 
            // rodPanelView2
            // 
            this.rodPanelView2.Location = new System.Drawing.Point(523, 12);
            this.rodPanelView2.Model = null;
            this.rodPanelView2.Name = "rodPanelView2";
            this.rodPanelView2.Size = new System.Drawing.Size(250, 250);
            this.rodPanelView2.TabIndex = 4;
            // 
            // From1to2
            // 
            this.From1to2.Location = new System.Drawing.Point(14, 280);
            this.From1to2.Name = "From1to2";
            this.From1to2.Size = new System.Drawing.Size(248, 29);
            this.From1to2.TabIndex = 5;
            this.From1to2.Text = "Переместить на 2";
            this.From1to2.UseVisualStyleBackColor = true;
            // 
            // From1to3
            // 
            this.From1to3.Location = new System.Drawing.Point(14, 322);
            this.From1to3.Name = "From1to3";
            this.From1to3.Size = new System.Drawing.Size(248, 29);
            this.From1to3.TabIndex = 6;
            this.From1to3.Text = "Переместить на 3";
            this.From1to3.UseVisualStyleBackColor = true;
            // 
            // From2to1
            // 
            this.From2to1.Location = new System.Drawing.Point(268, 280);
            this.From2to1.Name = "From2to1";
            this.From2to1.Size = new System.Drawing.Size(248, 29);
            this.From2to1.TabIndex = 7;
            this.From2to1.Text = "Переместить на 1";
            this.From2to1.UseVisualStyleBackColor = true;
            // 
            // From3to1
            // 
            this.From3to1.Location = new System.Drawing.Point(525, 280);
            this.From3to1.Name = "From3to1";
            this.From3to1.Size = new System.Drawing.Size(248, 29);
            this.From3to1.TabIndex = 8;
            this.From3to1.Text = "Переместить на 1";
            this.From3to1.UseVisualStyleBackColor = true;
            // 
            // From2to3
            // 
            this.From2to3.Location = new System.Drawing.Point(268, 322);
            this.From2to3.Name = "From2to3";
            this.From2to3.Size = new System.Drawing.Size(248, 29);
            this.From2to3.TabIndex = 9;
            this.From2to3.Text = "Переместить на 3";
            this.From2to3.UseVisualStyleBackColor = true;
            // 
            // From3to2
            // 
            this.From3to2.Location = new System.Drawing.Point(525, 322);
            this.From3to2.Name = "From3to2";
            this.From3to2.Size = new System.Drawing.Size(248, 29);
            this.From3to2.TabIndex = 10;
            this.From3to2.Text = "Переместить на 2";
            this.From3to2.UseVisualStyleBackColor = true;
            // 
            // Drop
            // 
            this.Drop.Location = new System.Drawing.Point(21, 415);
            this.Drop.Name = "Drop";
            this.Drop.Size = new System.Drawing.Size(241, 29);
            this.Drop.TabIndex = 11;
            this.Drop.Text = "Сбросить";
            this.Drop.UseVisualStyleBackColor = true;
            // 
            // CancelLast
            // 
            this.CancelLast.Location = new System.Drawing.Point(21, 380);
            this.CancelLast.Name = "CancelLast";
            this.CancelLast.Size = new System.Drawing.Size(241, 29);
            this.CancelLast.TabIndex = 12;
            this.CancelLast.Text = "Отменить ход";
            this.CancelLast.UseVisualStyleBackColor = true;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(278, 380);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(50, 20);
            this.Message.TabIndex = 13;
            this.Message.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 456);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.CancelLast);
            this.Controls.Add(this.Drop);
            this.Controls.Add(this.From3to2);
            this.Controls.Add(this.From2to3);
            this.Controls.Add(this.From3to1);
            this.Controls.Add(this.From2to1);
            this.Controls.Add(this.From1to3);
            this.Controls.Add(this.From1to2);
            this.Controls.Add(this.rodPanelView2);
            this.Controls.Add(this.rodPanelView1);
            this.Controls.Add(this.rodPanelView0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RodPanelView rodPanelView0;
        private RodPanelView rodPanelView1;
        private RodPanelView rodPanelView2;
        private System.Windows.Forms.Button From1to2;
        private System.Windows.Forms.Button From1to3;
        private System.Windows.Forms.Button From2to1;
        private System.Windows.Forms.Button From3to1;
        private System.Windows.Forms.Button From2to3;
        private System.Windows.Forms.Button From3to2;
        private System.Windows.Forms.Button Drop;
        private System.Windows.Forms.Button CancelLast;
        private System.Windows.Forms.Label Message;
    }
}

