namespace BankATMForm
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
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accountEnquiryServiceRadioButton = new System.Windows.Forms.RadioButton();
            this.lodgmentServiceRadioButton = new System.Windows.Forms.RadioButton();
            this.cashWithdrawalServiceRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.depositAccountTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.cashsaverAccountTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.currentAccountTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chequeBookRequestCheckBox = new System.Windows.Forms.CheckBox();
            this.recepitRequestCheckBox = new System.Windows.Forms.CheckBox();
            this.proceedButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
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
            this.Identification.Controls.Add(this.pinTextBox);
            this.Identification.Controls.Add(this.label1);
            this.Identification.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Identification.Location = new System.Drawing.Point(161, 74);
            this.Identification.Name = "Identification";
            this.Identification.Size = new System.Drawing.Size(439, 66);
            this.Identification.TabIndex = 1;
            this.Identification.TabStop = false;
            this.Identification.Text = "Identification";
            // 
            // pinTextBox
            // 
            this.pinTextBox.Location = new System.Drawing.Point(180, 27);
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(215, 20);
            this.pinTextBox.TabIndex = 1;
            this.pinTextBox.Text = "1234";
            this.pinTextBox.TextChanged += new System.EventHandler(this.TxtPIN_TextChanged);
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
            this.groupBox1.Controls.Add(this.accountEnquiryServiceRadioButton);
            this.groupBox1.Controls.Add(this.lodgmentServiceRadioButton);
            this.groupBox1.Controls.Add(this.cashWithdrawalServiceRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(161, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Required ";
            // 
            // accountEnquiryServiceRadioButton
            // 
            this.accountEnquiryServiceRadioButton.AutoSize = true;
            this.accountEnquiryServiceRadioButton.Location = new System.Drawing.Point(9, 65);
            this.accountEnquiryServiceRadioButton.Name = "accountEnquiryServiceRadioButton";
            this.accountEnquiryServiceRadioButton.Size = new System.Drawing.Size(103, 17);
            this.accountEnquiryServiceRadioButton.TabIndex = 2;
            this.accountEnquiryServiceRadioButton.Text = "Account Enquiry";
            this.accountEnquiryServiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // lodgmentServiceRadioButton
            // 
            this.lodgmentServiceRadioButton.AutoSize = true;
            this.lodgmentServiceRadioButton.Location = new System.Drawing.Point(9, 42);
            this.lodgmentServiceRadioButton.Name = "lodgmentServiceRadioButton";
            this.lodgmentServiceRadioButton.Size = new System.Drawing.Size(72, 17);
            this.lodgmentServiceRadioButton.TabIndex = 1;
            this.lodgmentServiceRadioButton.Text = "Lodgment";
            this.lodgmentServiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // cashWithdrawalServiceRadioButton
            // 
            this.cashWithdrawalServiceRadioButton.AutoSize = true;
            this.cashWithdrawalServiceRadioButton.Checked = true;
            this.cashWithdrawalServiceRadioButton.Location = new System.Drawing.Point(9, 19);
            this.cashWithdrawalServiceRadioButton.Name = "cashWithdrawalServiceRadioButton";
            this.cashWithdrawalServiceRadioButton.Size = new System.Drawing.Size(105, 17);
            this.cashWithdrawalServiceRadioButton.TabIndex = 0;
            this.cashWithdrawalServiceRadioButton.TabStop = true;
            this.cashWithdrawalServiceRadioButton.Text = "Cash Withdrawal";
            this.cashWithdrawalServiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.depositAccountTypeRadioButton);
            this.groupBox2.Controls.Add(this.cashsaverAccountTypeRadioButton);
            this.groupBox2.Controls.Add(this.currentAccountTypeRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(404, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 99);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Type";
            // 
            // depositAccountTypeRadioButton
            // 
            this.depositAccountTypeRadioButton.AutoSize = true;
            this.depositAccountTypeRadioButton.Location = new System.Drawing.Point(6, 65);
            this.depositAccountTypeRadioButton.Name = "depositAccountTypeRadioButton";
            this.depositAccountTypeRadioButton.Size = new System.Drawing.Size(61, 17);
            this.depositAccountTypeRadioButton.TabIndex = 3;
            this.depositAccountTypeRadioButton.Text = "Deposit";
            this.depositAccountTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // cashsaverAccountTypeRadioButton
            // 
            this.cashsaverAccountTypeRadioButton.AutoSize = true;
            this.cashsaverAccountTypeRadioButton.Location = new System.Drawing.Point(6, 42);
            this.cashsaverAccountTypeRadioButton.Name = "cashsaverAccountTypeRadioButton";
            this.cashsaverAccountTypeRadioButton.Size = new System.Drawing.Size(75, 17);
            this.cashsaverAccountTypeRadioButton.TabIndex = 2;
            this.cashsaverAccountTypeRadioButton.Text = "Cashsaver";
            this.cashsaverAccountTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // currentAccountTypeRadioButton
            // 
            this.currentAccountTypeRadioButton.AutoSize = true;
            this.currentAccountTypeRadioButton.Checked = true;
            this.currentAccountTypeRadioButton.Location = new System.Drawing.Point(6, 19);
            this.currentAccountTypeRadioButton.Name = "currentAccountTypeRadioButton";
            this.currentAccountTypeRadioButton.Size = new System.Drawing.Size(59, 17);
            this.currentAccountTypeRadioButton.TabIndex = 1;
            this.currentAccountTypeRadioButton.TabStop = true;
            this.currentAccountTypeRadioButton.Text = "Current";
            this.currentAccountTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chequeBookRequestCheckBox);
            this.groupBox3.Controls.Add(this.recepitRequestCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(161, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 69);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Request ";
            // 
            // chequeBookRequestCheckBox
            // 
            this.chequeBookRequestCheckBox.AutoSize = true;
            this.chequeBookRequestCheckBox.Location = new System.Drawing.Point(275, 34);
            this.chequeBookRequestCheckBox.Name = "chequeBookRequestCheckBox";
            this.chequeBookRequestCheckBox.Size = new System.Drawing.Size(120, 17);
            this.chequeBookRequestCheckBox.TabIndex = 1;
            this.chequeBookRequestCheckBox.Text = "Order Cheque Book";
            this.chequeBookRequestCheckBox.UseVisualStyleBackColor = true;
            // 
            // recepitRequestCheckBox
            // 
            this.recepitRequestCheckBox.AutoSize = true;
            this.recepitRequestCheckBox.Location = new System.Drawing.Point(45, 34);
            this.recepitRequestCheckBox.Name = "recepitRequestCheckBox";
            this.recepitRequestCheckBox.Size = new System.Drawing.Size(106, 17);
            this.recepitRequestCheckBox.TabIndex = 0;
            this.recepitRequestCheckBox.Text = "Receipt Request";
            this.recepitRequestCheckBox.UseVisualStyleBackColor = true;
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(206, 326);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(63, 22);
            this.proceedButton.TabIndex = 5;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(341, 326);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(63, 22);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
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
            // detailsTextBox
            // 
            this.detailsTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.detailsTextBox.Location = new System.Drawing.Point(161, 354);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(439, 76);
            this.detailsTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Identification);
            this.Controls.Add(this.SouthWest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton accountEnquiryServiceRadioButton;
        private System.Windows.Forms.RadioButton lodgmentServiceRadioButton;
        private System.Windows.Forms.RadioButton cashWithdrawalServiceRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton depositAccountTypeRadioButton;
        private System.Windows.Forms.RadioButton cashsaverAccountTypeRadioButton;
        private System.Windows.Forms.RadioButton currentAccountTypeRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chequeBookRequestCheckBox;
        private System.Windows.Forms.CheckBox recepitRequestCheckBox;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.TextBox detailsTextBox;
    }
}

