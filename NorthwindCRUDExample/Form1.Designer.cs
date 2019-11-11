namespace NorthwindCRUDExample
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
			this.Usernamelabel = new System.Windows.Forms.Label();
			this.Passwordlable = new System.Windows.Forms.Label();
			this.UsernametextBox = new System.Windows.Forms.TextBox();
			this.PasswordtextBox = new System.Windows.Forms.TextBox();
			this.OKbutton = new System.Windows.Forms.Button();
			this.Cancelbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Usernamelabel
			// 
			this.Usernamelabel.AutoSize = true;
			this.Usernamelabel.Location = new System.Drawing.Point(73, 38);
			this.Usernamelabel.Name = "Usernamelabel";
			this.Usernamelabel.Size = new System.Drawing.Size(55, 13);
			this.Usernamelabel.TabIndex = 0;
			this.Usernamelabel.Text = "Username";
			// 
			// Passwordlable
			// 
			this.Passwordlable.AutoSize = true;
			this.Passwordlable.Location = new System.Drawing.Point(75, 89);
			this.Passwordlable.Name = "Passwordlable";
			this.Passwordlable.Size = new System.Drawing.Size(53, 13);
			this.Passwordlable.TabIndex = 1;
			this.Passwordlable.Text = "Password";
			// 
			// UsernametextBox
			// 
			this.UsernametextBox.Location = new System.Drawing.Point(76, 54);
			this.UsernametextBox.Name = "UsernametextBox";
			this.UsernametextBox.Size = new System.Drawing.Size(172, 20);
			this.UsernametextBox.TabIndex = 2;
			this.UsernametextBox.TextChanged += new System.EventHandler(this.UsernametextBox_TextChanged);
			// 
			// PasswordtextBox
			// 
			this.PasswordtextBox.Location = new System.Drawing.Point(78, 105);
			this.PasswordtextBox.Name = "PasswordtextBox";
			this.PasswordtextBox.Size = new System.Drawing.Size(172, 20);
			this.PasswordtextBox.TabIndex = 4;
			this.PasswordtextBox.TextChanged += new System.EventHandler(this.PasswordtextBox_TextChanged);
			// 
			// OKbutton
			// 
			this.OKbutton.Location = new System.Drawing.Point(78, 146);
			this.OKbutton.Name = "OKbutton";
			this.OKbutton.Size = new System.Drawing.Size(71, 25);
			this.OKbutton.TabIndex = 5;
			this.OKbutton.Text = "OK";
			this.OKbutton.UseVisualStyleBackColor = true;
			this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
			// 
			// Cancelbutton
			// 
			this.Cancelbutton.Location = new System.Drawing.Point(178, 146);
			this.Cancelbutton.Name = "Cancelbutton";
			this.Cancelbutton.Size = new System.Drawing.Size(72, 25);
			this.Cancelbutton.TabIndex = 6;
			this.Cancelbutton.Text = "Cancel";
			this.Cancelbutton.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Cancelbutton);
			this.Controls.Add(this.OKbutton);
			this.Controls.Add(this.PasswordtextBox);
			this.Controls.Add(this.UsernametextBox);
			this.Controls.Add(this.Passwordlable);
			this.Controls.Add(this.Usernamelabel);
			this.Name = "Form1";
			this.Text = "LoginForm1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usernamelabel;
        private System.Windows.Forms.Label Passwordlable;
        private System.Windows.Forms.TextBox UsernametextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button Cancelbutton;
    }
}

