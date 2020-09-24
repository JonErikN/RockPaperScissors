namespace WindowsFormsApp2
{
    partial class frmMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.hh = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(68, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 106);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rock Paper Scissors";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hh
            // 
            this.hh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hh.Location = new System.Drawing.Point(430, 75);
            this.hh.Name = "hh";
            this.hh.Size = new System.Drawing.Size(318, 106);
            this.hh.TabIndex = 1;
            this.hh.Text = "Calculate sum";
            this.hh.UseVisualStyleBackColor = true;
            this.hh.Click += new System.EventHandler(this.hh_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 275);
            this.Controls.Add(this.hh);
            this.Controls.Add(this.button1);
            this.Name = "frmMenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button hh;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

