namespace gomoku
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
            this.restart = new System.Windows.Forms.Button();
            this.BlackPlayer_Name = new System.Windows.Forms.TextBox();
            this.WhitePlayer_Name = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // restart
            // 
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.Location = new System.Drawing.Point(12, 12);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(114, 45);
            this.restart.TabIndex = 0;
            this.restart.Text = "restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // BlackPlayer_Name
            // 
            this.BlackPlayer_Name.Location = new System.Drawing.Point(262, 21);
            this.BlackPlayer_Name.Name = "BlackPlayer_Name";
            this.BlackPlayer_Name.Size = new System.Drawing.Size(84, 20);
            this.BlackPlayer_Name.TabIndex = 1;
            // 
            // WhitePlayer_Name
            // 
            this.WhitePlayer_Name.Location = new System.Drawing.Point(495, 21);
            this.WhitePlayer_Name.Name = "WhitePlayer_Name";
            this.WhitePlayer_Name.Size = new System.Drawing.Size(84, 20);
            this.WhitePlayer_Name.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(176, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Black Player\r\n:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(398, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "White Player\r\n:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gomoku.Properties.Resources.board;
            this.ClientSize = new System.Drawing.Size(750, 793);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.WhitePlayer_Name);
            this.Controls.Add(this.BlackPlayer_Name);
            this.Controls.Add(this.restart);
            this.Name = "Form1";
            this.Text = "gomoku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.TextBox BlackPlayer_Name;
        private System.Windows.Forms.TextBox WhitePlayer_Name;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

