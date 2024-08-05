namespace KhaNG
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtstar = new System.Windows.Forms.TextBox();
            this.txtstop = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 132);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00\r\n";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtstar
            // 
            this.txtstar.BackColor = System.Drawing.Color.Chartreuse;
            this.txtstar.Font = new System.Drawing.Font("DS-Digital", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtstar.Location = new System.Drawing.Point(31, 198);
            this.txtstar.Name = "txtstar";
            this.txtstar.Size = new System.Drawing.Size(164, 61);
            this.txtstar.TabIndex = 1;
            this.txtstar.Text = " Start";
            // 
            // txtstop
            // 
            this.txtstop.BackColor = System.Drawing.Color.Red;
            this.txtstop.Cursor = System.Windows.Forms.Cursors.No;
            this.txtstop.Font = new System.Drawing.Font("DS-Digital", 45F);
            this.txtstop.Location = new System.Drawing.Point(213, 198);
            this.txtstop.Name = "txtstop";
            this.txtstop.Size = new System.Drawing.Size(164, 67);
            this.txtstop.TabIndex = 1;
            this.txtstop.Text = "  Stop";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox3.Font = new System.Drawing.Font("DS-Digital", 40F);
            this.textBox3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBox3.Location = new System.Drawing.Point(394, 198);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 61);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = " Reset";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(67F, 132F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(620, 295);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtstop);
            this.Controls.Add(this.txtstar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("DS-Digital", 99.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(34, 30, 34, 30);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtstar;
        private System.Windows.Forms.TextBox txtstop;
        private System.Windows.Forms.TextBox textBox3;
    }
}

