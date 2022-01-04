
namespace scgridcalc {
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
            this.txtCalc = new System.Windows.Forms.TextBox();
            this.optInGrid = new System.Windows.Forms.RadioButton();
            this.optInPixel = new System.Windows.Forms.RadioButton();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.optOutPixel = new System.Windows.Forms.RadioButton();
            this.optOutGrid = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCalc
            // 
            this.txtCalc.Location = new System.Drawing.Point(12, 12);
            this.txtCalc.Name = "txtCalc";
            this.txtCalc.Size = new System.Drawing.Size(173, 23);
            this.txtCalc.TabIndex = 0;
            this.txtCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // optInGrid
            // 
            this.optInGrid.AutoSize = true;
            this.optInGrid.Location = new System.Drawing.Point(5, 3);
            this.optInGrid.Name = "optInGrid";
            this.optInGrid.Size = new System.Drawing.Size(46, 19);
            this.optInGrid.TabIndex = 1;
            this.optInGrid.Text = "grid";
            this.optInGrid.UseVisualStyleBackColor = true;
            this.optInGrid.Click += new System.EventHandler(this.optGrid_Click);
            // 
            // optInPixel
            // 
            this.optInPixel.AutoSize = true;
            this.optInPixel.Checked = true;
            this.optInPixel.Location = new System.Drawing.Point(57, 3);
            this.optInPixel.Name = "optInPixel";
            this.optInPixel.Size = new System.Drawing.Size(50, 19);
            this.optInPixel.TabIndex = 2;
            this.optInPixel.TabStop = true;
            this.optInPixel.Text = "pixel";
            this.optInPixel.UseVisualStyleBackColor = true;
            this.optInPixel.Click += new System.EventHandler(this.optPixel_Click);
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(10, 114);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(77, 23);
            this.txtX1.TabIndex = 3;
            this.txtX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtX1.TextChanged += new System.EventHandler(this.txtX1_TextChanged);
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(106, 114);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(77, 23);
            this.txtY1.TabIndex = 4;
            this.txtY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtY1.TextChanged += new System.EventHandler(this.txtY1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(10, 143);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(77, 23);
            this.txtX2.TabIndex = 7;
            this.txtX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtX2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(106, 143);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(77, 23);
            this.txtY2.TabIndex = 8;
            this.txtY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtY2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(34, 48);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(35, 15);
            this.lblInput.TabIndex = 9;
            this.lblInput.Text = "input";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(26, 74);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(43, 15);
            this.lblOutput.TabIndex = 12;
            this.lblOutput.Text = "output";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.optInPixel);
            this.panel1.Controls.Add(this.optInGrid);
            this.panel1.Location = new System.Drawing.Point(75, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 24);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.optOutPixel);
            this.panel2.Controls.Add(this.optOutGrid);
            this.panel2.Location = new System.Drawing.Point(75, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 24);
            this.panel2.TabIndex = 14;
            // 
            // optOutPixel
            // 
            this.optOutPixel.AutoSize = true;
            this.optOutPixel.Checked = true;
            this.optOutPixel.Location = new System.Drawing.Point(57, 3);
            this.optOutPixel.Name = "optOutPixel";
            this.optOutPixel.Size = new System.Drawing.Size(50, 19);
            this.optOutPixel.TabIndex = 2;
            this.optOutPixel.TabStop = true;
            this.optOutPixel.Text = "pixel";
            this.optOutPixel.UseVisualStyleBackColor = true;
            this.optOutPixel.Click += new System.EventHandler(this.optOutPixel_Click);
            // 
            // optOutGrid
            // 
            this.optOutGrid.AutoSize = true;
            this.optOutGrid.Location = new System.Drawing.Point(5, 3);
            this.optOutGrid.Name = "optOutGrid";
            this.optOutGrid.Size = new System.Drawing.Size(46, 19);
            this.optOutGrid.TabIndex = 1;
            this.optOutGrid.Text = "grid";
            this.optOutGrid.UseVisualStyleBackColor = true;
            this.optOutGrid.Click += new System.EventHandler(this.optOutGrid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 175);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.txtCalc);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "scgridcalc 211207";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCalc;
        private System.Windows.Forms.RadioButton optInGrid;
        private System.Windows.Forms.RadioButton optInPixel;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton optOutPixel;
        private System.Windows.Forms.RadioButton optOutGrid;
    }
}

