namespace WindowsFormsApp2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 103);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(276, 69);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Excecute calculation!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(12, 20);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(289, 20);
            this.lblSum.TabIndex = 3;
            this.lblSum.Text = "Calculate the sum of numbers between:";
            this.lblSum.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(16, 71);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 26);
            this.txtStart.TabIndex = 4;
            this.txtStart.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(188, 71);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 26);
            this.txtEnd.TabIndex = 5;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(16, 198);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(272, 26);
            this.txtSum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "and";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "The sum is:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}