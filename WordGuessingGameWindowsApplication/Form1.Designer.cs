namespace WordGuessingGameWindowsApplication
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGuess = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxInputGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.listBoxWrongGuess = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.lblGuess);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 125);
            this.panel1.TabIndex = 0;
            // 
            // lblGuess
            // 
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGuess.Location = new System.Drawing.Point(170, 44);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(302, 42);
            this.lblGuess.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(699, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 46);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(76, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wrong Guess";
            // 
            // txtBoxInputGuess
            // 
            this.txtBoxInputGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInputGuess.Location = new System.Drawing.Point(96, 195);
            this.txtBoxInputGuess.Name = "txtBoxInputGuess";
            this.txtBoxInputGuess.Size = new System.Drawing.Size(510, 30);
            this.txtBoxInputGuess.TabIndex = 2;
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuess.Location = new System.Drawing.Point(234, 261);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(157, 38);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // listBoxWrongGuess
            // 
            this.listBoxWrongGuess.FormattingEnabled = true;
            this.listBoxWrongGuess.ItemHeight = 16;
            this.listBoxWrongGuess.Location = new System.Drawing.Point(699, 113);
            this.listBoxWrongGuess.Name = "listBoxWrongGuess";
            this.listBoxWrongGuess.Size = new System.Drawing.Size(285, 228);
            this.listBoxWrongGuess.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 354);
            this.Controls.Add(this.listBoxWrongGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtBoxInputGuess);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Guess the Word";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxInputGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.ListBox listBoxWrongGuess;
    }
}

