namespace Prog2
{
    partial class RegistrationForm
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
            this.creditHrTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.findRegTimeBtn = new System.Windows.Forms.Button();
            this.creditHrLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.RegLbl = new System.Windows.Forms.Label();
            this.dateTimeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creditHrTxt
            // 
            this.creditHrTxt.Location = new System.Drawing.Point(172, 13);
            this.creditHrTxt.Name = "creditHrTxt";
            this.creditHrTxt.Size = new System.Drawing.Size(100, 20);
            this.creditHrTxt.TabIndex = 0;
            this.creditHrTxt.TextChanged += new System.EventHandler(this.text_Change);
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(172, 40);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(100, 20);
            this.lastNameTxt.TabIndex = 1;
            this.lastNameTxt.TextChanged += new System.EventHandler(this.text_Change);
            // 
            // findRegTimeBtn
            // 
            this.findRegTimeBtn.Location = new System.Drawing.Point(92, 87);
            this.findRegTimeBtn.Name = "findRegTimeBtn";
            this.findRegTimeBtn.Size = new System.Drawing.Size(99, 23);
            this.findRegTimeBtn.TabIndex = 2;
            this.findRegTimeBtn.Text = "Find Reg. Time";
            this.findRegTimeBtn.UseVisualStyleBackColor = true;
            this.findRegTimeBtn.Click += new System.EventHandler(this.findRegTimeBtn_Click);
            // 
            // creditHrLbl
            // 
            this.creditHrLbl.AutoSize = true;
            this.creditHrLbl.Location = new System.Drawing.Point(29, 16);
            this.creditHrLbl.Name = "creditHrLbl";
            this.creditHrLbl.Size = new System.Drawing.Size(137, 13);
            this.creditHrLbl.TabIndex = 3;
            this.creditHrLbl.Text = "Credits prior to Spring 2016:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(107, 43);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(59, 13);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Last name:";
            // 
            // RegLbl
            // 
            this.RegLbl.AutoSize = true;
            this.RegLbl.Location = new System.Drawing.Point(65, 136);
            this.RegLbl.Name = "RegLbl";
            this.RegLbl.Size = new System.Drawing.Size(154, 13);
            this.RegLbl.TabIndex = 5;
            this.RegLbl.Text = "The earliest you may register is:";
            // 
            // dateTimeLbl
            // 
            this.dateTimeLbl.AutoSize = true;
            this.dateTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLbl.Location = new System.Drawing.Point(68, 153);
            this.dateTimeLbl.Name = "dateTimeLbl";
            this.dateTimeLbl.Size = new System.Drawing.Size(0, 13);
            this.dateTimeLbl.TabIndex = 6;
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.findRegTimeBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 208);
            this.Controls.Add(this.dateTimeLbl);
            this.Controls.Add(this.RegLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.creditHrLbl);
            this.Controls.Add(this.findRegTimeBtn);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.creditHrTxt);
            this.Name = "RegistrationForm";
            this.Text = "Registration Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox creditHrTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Button findRegTimeBtn;
        private System.Windows.Forms.Label creditHrLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label RegLbl;
        private System.Windows.Forms.Label dateTimeLbl;
    }
}

