﻿namespace BankATMForm
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
            this.SouthWest = new System.Windows.Forms.Label();
            this.Identification = new System.Windows.Forms.GroupBox();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radEnquiry = new System.Windows.Forms.RadioButton();
            this.radLodgment = new System.Windows.Forms.RadioButton();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radDepositAmount = new System.Windows.Forms.RadioButton();
            this.radCashsave = new System.Windows.Forms.RadioButton();
            this.radCurrentAccount = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxChequeBook = new System.Windows.Forms.CheckBox();
            this.checkBoxRecepit = new System.Windows.Forms.CheckBox();
            this.BtnProceed = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.Identification.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SouthWest
            // 
            this.SouthWest.AutoSize = true;
            this.SouthWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SouthWest.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.SouthWest.Location = new System.Drawing.Point(244, 9);
            this.SouthWest.Name = "SouthWest";
            this.SouthWest.Size = new System.Drawing.Size(265, 25);
            this.SouthWest.TabIndex = 0;
            this.SouthWest.Text = "South West Banking Ltd";
            this.SouthWest.Click += new System.EventHandler(this.SouthWest_Click);
            // 
            // Identification
            // 
            this.Identification.Controls.Add(this.txtPIN);
            this.Identification.Controls.Add(this.label1);
            this.Identification.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Identification.Location = new System.Drawing.Point(161, 74);
            this.Identification.Name = "Identification";
            this.Identification.Size = new System.Drawing.Size(439, 66);
            this.Identification.TabIndex = 1;
            this.Identification.TabStop = false;
            this.Identification.Text = "Identification";
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(180, 24);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(215, 20);
            this.txtPIN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter Your PIN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radEnquiry);
            this.groupBox1.Controls.Add(this.radLodgment);
            this.groupBox1.Controls.Add(this.radCash);
            this.groupBox1.Location = new System.Drawing.Point(161, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Required ";
            // 
            // radEnquiry
            // 
            this.radEnquiry.AutoSize = true;
            this.radEnquiry.Location = new System.Drawing.Point(9, 65);
            this.radEnquiry.Name = "radEnquiry";
            this.radEnquiry.Size = new System.Drawing.Size(103, 17);
            this.radEnquiry.TabIndex = 2;
            this.radEnquiry.TabStop = true;
            this.radEnquiry.Text = "Account Enquiry";
            this.radEnquiry.UseVisualStyleBackColor = true;
            // 
            // radLodgment
            // 
            this.radLodgment.AutoSize = true;
            this.radLodgment.Location = new System.Drawing.Point(9, 42);
            this.radLodgment.Name = "radLodgment";
            this.radLodgment.Size = new System.Drawing.Size(72, 17);
            this.radLodgment.TabIndex = 1;
            this.radLodgment.TabStop = true;
            this.radLodgment.Text = "Lodgment";
            this.radLodgment.UseVisualStyleBackColor = true;
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(9, 19);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(105, 17);
            this.radCash.TabIndex = 0;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash Withdrawal";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radDepositAmount);
            this.groupBox2.Controls.Add(this.radCashsave);
            this.groupBox2.Controls.Add(this.radCurrentAccount);
            this.groupBox2.Location = new System.Drawing.Point(404, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 99);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Type";
            // 
            // radDepositAmount
            // 
            this.radDepositAmount.AutoSize = true;
            this.radDepositAmount.Location = new System.Drawing.Point(6, 65);
            this.radDepositAmount.Name = "radDepositAmount";
            this.radDepositAmount.Size = new System.Drawing.Size(100, 17);
            this.radDepositAmount.TabIndex = 3;
            this.radDepositAmount.TabStop = true;
            this.radDepositAmount.Text = "Deposit Amount";
            this.radDepositAmount.UseVisualStyleBackColor = true;
            // 
            // radCashsave
            // 
            this.radCashsave.AutoSize = true;
            this.radCashsave.Location = new System.Drawing.Point(6, 42);
            this.radCashsave.Name = "radCashsave";
            this.radCashsave.Size = new System.Drawing.Size(72, 17);
            this.radCashsave.TabIndex = 2;
            this.radCashsave.TabStop = true;
            this.radCashsave.Text = "Cashsave";
            this.radCashsave.UseVisualStyleBackColor = true;
            // 
            // radCurrentAccount
            // 
            this.radCurrentAccount.AutoSize = true;
            this.radCurrentAccount.Location = new System.Drawing.Point(6, 19);
            this.radCurrentAccount.Name = "radCurrentAccount";
            this.radCurrentAccount.Size = new System.Drawing.Size(102, 17);
            this.radCurrentAccount.TabIndex = 1;
            this.radCurrentAccount.TabStop = true;
            this.radCurrentAccount.Text = "Current Account";
            this.radCurrentAccount.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxChequeBook);
            this.groupBox3.Controls.Add(this.checkBoxRecepit);
            this.groupBox3.Location = new System.Drawing.Point(161, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 69);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Request ";
            // 
            // checkBoxChequeBook
            // 
            this.checkBoxChequeBook.AutoSize = true;
            this.checkBoxChequeBook.Location = new System.Drawing.Point(275, 34);
            this.checkBoxChequeBook.Name = "checkBoxChequeBook";
            this.checkBoxChequeBook.Size = new System.Drawing.Size(120, 17);
            this.checkBoxChequeBook.TabIndex = 1;
            this.checkBoxChequeBook.Text = "Order Cheque Book";
            this.checkBoxChequeBook.UseVisualStyleBackColor = true;
            // 
            // checkBoxRecepit
            // 
            this.checkBoxRecepit.AutoSize = true;
            this.checkBoxRecepit.Location = new System.Drawing.Point(45, 34);
            this.checkBoxRecepit.Name = "checkBoxRecepit";
            this.checkBoxRecepit.Size = new System.Drawing.Size(106, 17);
            this.checkBoxRecepit.TabIndex = 0;
            this.checkBoxRecepit.Text = "Receipt Request";
            this.checkBoxRecepit.UseVisualStyleBackColor = true;
            // 
            // BtnProceed
            // 
            this.BtnProceed.Location = new System.Drawing.Point(206, 326);
            this.BtnProceed.Name = "BtnProceed";
            this.BtnProceed.Size = new System.Drawing.Size(63, 22);
            this.BtnProceed.TabIndex = 5;
            this.BtnProceed.Text = "Proceed";
            this.BtnProceed.UseVisualStyleBackColor = true;
            this.BtnProceed.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(341, 326);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(63, 22);
            this.BtnNext.TabIndex = 6;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.Location = new System.Drawing.Point(503, 326);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(63, 22);
            this.BtnEnd.TabIndex = 7;
            this.BtnEnd.Text = "End";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDetails.Location = new System.Drawing.Point(161, 354);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(439, 76);
            this.txtDetails.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnProceed);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Identification);
            this.Controls.Add(this.SouthWest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Identification.ResumeLayout(false);
            this.Identification.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SouthWest;
        private System.Windows.Forms.GroupBox Identification;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radEnquiry;
        private System.Windows.Forms.RadioButton radLodgment;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radDepositAmount;
        private System.Windows.Forms.RadioButton radCashsave;
        private System.Windows.Forms.RadioButton radCurrentAccount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxChequeBook;
        private System.Windows.Forms.CheckBox checkBoxRecepit;
        private System.Windows.Forms.Button BtnProceed;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.TextBox txtDetails;
    }
}

