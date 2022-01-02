
namespace Laba4._2
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lbLOEAB = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.pnlA = new System.Windows.Forms.Panel();
            this.trbrA = new System.Windows.Forms.TrackBar();
            this.pnlB = new System.Windows.Forms.Panel();
            this.trbrB = new System.Windows.Forms.TrackBar();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.pnlC = new System.Windows.Forms.Panel();
            this.trbrC = new System.Windows.Forms.TrackBar();
            this.nudC = new System.Windows.Forms.NumericUpDown();
            this.lbLOEBC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            this.pnlA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbrA)).BeginInit();
            this.pnlB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbrB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            this.pnlC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbrC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).BeginInit();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbA.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbA.Location = new System.Drawing.Point(48, 44);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(103, 100);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "A";
            this.lbA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbB
            // 
            this.lbB.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbB.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbB.Location = new System.Drawing.Point(49, 44);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(103, 100);
            this.lbB.TabIndex = 1;
            this.lbB.Text = "B";
            this.lbB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbC
            // 
            this.lbC.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbC.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbC.Location = new System.Drawing.Point(49, 44);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(103, 100);
            this.lbC.TabIndex = 2;
            this.lbC.Text = "C";
            this.lbC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLOEAB
            // 
            this.lbLOEAB.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbLOEAB.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLOEAB.Location = new System.Drawing.Point(193, 83);
            this.lbLOEAB.Name = "lbLOEAB";
            this.lbLOEAB.Size = new System.Drawing.Size(165, 100);
            this.lbLOEAB.TabIndex = 3;
            this.lbLOEAB.Text = "<=";
            this.lbLOEAB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbA
            // 
            this.tbA.BackColor = System.Drawing.Color.Lavender;
            this.tbA.Location = new System.Drawing.Point(37, 162);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(125, 27);
            this.tbA.TabIndex = 5;
            this.tbA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // tbB
            // 
            this.tbB.BackColor = System.Drawing.Color.Lavender;
            this.tbB.Location = new System.Drawing.Point(36, 162);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(125, 27);
            this.tbB.TabIndex = 6;
            this.tbB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // tbC
            // 
            this.tbC.BackColor = System.Drawing.Color.Lavender;
            this.tbC.Location = new System.Drawing.Point(37, 162);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(125, 27);
            this.tbC.TabIndex = 7;
            this.tbC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // nudA
            // 
            this.nudA.BackColor = System.Drawing.Color.Lavender;
            this.nudA.Location = new System.Drawing.Point(37, 217);
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(125, 27);
            this.nudA.TabIndex = 8;
            this.nudA.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            this.nudA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nud_KeyDown);
            // 
            // pnlA
            // 
            this.pnlA.Controls.Add(this.trbrA);
            this.pnlA.Controls.Add(this.nudA);
            this.pnlA.Controls.Add(this.tbA);
            this.pnlA.Controls.Add(this.lbA);
            this.pnlA.Location = new System.Drawing.Point(69, 39);
            this.pnlA.Name = "pnlA";
            this.pnlA.Size = new System.Drawing.Size(189, 355);
            this.pnlA.TabIndex = 9;
            // 
            // trbrA
            // 
            this.trbrA.BackColor = System.Drawing.Color.Lavender;
            this.trbrA.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trbrA.LargeChange = 1;
            this.trbrA.Location = new System.Drawing.Point(37, 269);
            this.trbrA.Maximum = 100;
            this.trbrA.Name = "trbrA";
            this.trbrA.Size = new System.Drawing.Size(125, 56);
            this.trbrA.TabIndex = 9;
            this.trbrA.ValueChanged += new System.EventHandler(this.trbr_ValueChanged);
            // 
            // pnlB
            // 
            this.pnlB.Controls.Add(this.trbrB);
            this.pnlB.Controls.Add(this.nudB);
            this.pnlB.Controls.Add(this.lbB);
            this.pnlB.Controls.Add(this.tbB);
            this.pnlB.Location = new System.Drawing.Point(302, 39);
            this.pnlB.Name = "pnlB";
            this.pnlB.Size = new System.Drawing.Size(189, 355);
            this.pnlB.TabIndex = 10;
            // 
            // trbrB
            // 
            this.trbrB.BackColor = System.Drawing.Color.Lavender;
            this.trbrB.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trbrB.LargeChange = 1;
            this.trbrB.Location = new System.Drawing.Point(36, 269);
            this.trbrB.Maximum = 100;
            this.trbrB.Name = "trbrB";
            this.trbrB.Size = new System.Drawing.Size(125, 56);
            this.trbrB.TabIndex = 13;
            this.trbrB.ValueChanged += new System.EventHandler(this.trbr_ValueChanged);
            // 
            // nudB
            // 
            this.nudB.BackColor = System.Drawing.Color.Lavender;
            this.nudB.Location = new System.Drawing.Point(36, 217);
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(125, 27);
            this.nudB.TabIndex = 9;
            this.nudB.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            this.nudB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nud_KeyDown);
            // 
            // pnlC
            // 
            this.pnlC.Controls.Add(this.trbrC);
            this.pnlC.Controls.Add(this.nudC);
            this.pnlC.Controls.Add(this.lbC);
            this.pnlC.Controls.Add(this.tbC);
            this.pnlC.Location = new System.Drawing.Point(532, 39);
            this.pnlC.Name = "pnlC";
            this.pnlC.Size = new System.Drawing.Size(189, 355);
            this.pnlC.TabIndex = 11;
            // 
            // trbrC
            // 
            this.trbrC.BackColor = System.Drawing.Color.Lavender;
            this.trbrC.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trbrC.LargeChange = 1;
            this.trbrC.Location = new System.Drawing.Point(37, 269);
            this.trbrC.Maximum = 100;
            this.trbrC.Name = "trbrC";
            this.trbrC.Size = new System.Drawing.Size(125, 56);
            this.trbrC.TabIndex = 10;
            this.trbrC.ValueChanged += new System.EventHandler(this.trbr_ValueChanged);
            // 
            // nudC
            // 
            this.nudC.BackColor = System.Drawing.Color.Lavender;
            this.nudC.Location = new System.Drawing.Point(37, 217);
            this.nudC.Name = "nudC";
            this.nudC.Size = new System.Drawing.Size(125, 27);
            this.nudC.TabIndex = 8;
            this.nudC.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            this.nudC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nud_KeyDown);
            // 
            // lbLOEBC
            // 
            this.lbLOEBC.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbLOEBC.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLOEBC.Location = new System.Drawing.Point(426, 83);
            this.lbLOEBC.Name = "lbLOEBC";
            this.lbLOEBC.Size = new System.Drawing.Size(180, 100);
            this.lbLOEBC.TabIndex = 12;
            this.lbLOEBC.Text = "<=";
            this.lbLOEBC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.lbLOEBC);
            this.Controls.Add(this.lbLOEAB);
            this.Controls.Add(this.pnlA);
            this.Controls.Add(this.pnlC);
            this.Controls.Add(this.pnlB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Laboratory work №4.2";
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            this.pnlA.ResumeLayout(false);
            this.pnlA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbrA)).EndInit();
            this.pnlB.ResumeLayout(false);
            this.pnlB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbrB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            this.pnlC.ResumeLayout(false);
            this.pnlC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbrC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lbLOEAB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.Panel pnlA;
        private System.Windows.Forms.Panel pnlB;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.Panel pnlC;
        private System.Windows.Forms.NumericUpDown nudC;
        private System.Windows.Forms.Label lbLOEBC;
        private System.Windows.Forms.TrackBar trbrA;
        private System.Windows.Forms.TrackBar trbrB;
        private System.Windows.Forms.TrackBar trbrC;
    }
}

