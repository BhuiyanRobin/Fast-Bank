namespace SalaryCalculationApp
{
    partial class BankApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateEntryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.accountNumberEntryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailEntryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameEntryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.depositeButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateDisplayTextBox = new System.Windows.Forms.TextBox();
            this.nameDisplayTextBox = new System.Windows.Forms.TextBox();
            this.balanceDisplayTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.accountNumberDisplayTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.emailDisplayTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.withdrawnButton = new System.Windows.Forms.Button();
            this.showMeDetailsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateEntryTextBox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.accountNumberEntryTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.emailEntryTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameEntryTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CoustomerAndAccountInfoEntry";
            // 
            // dateEntryTextBox
            // 
            this.dateEntryTextBox.Location = new System.Drawing.Point(197, 145);
            this.dateEntryTextBox.Name = "dateEntryTextBox";
            this.dateEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateEntryTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Opening Date";
            // 
            // accountNumberEntryTextBox
            // 
            this.accountNumberEntryTextBox.Location = new System.Drawing.Point(197, 104);
            this.accountNumberEntryTextBox.Name = "accountNumberEntryTextBox";
            this.accountNumberEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.accountNumberEntryTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Account Number";
            // 
            // emailEntryTextBox
            // 
            this.emailEntryTextBox.Location = new System.Drawing.Point(197, 62);
            this.emailEntryTextBox.Name = "emailEntryTextBox";
            this.emailEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailEntryTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Email";
            // 
            // nameEntryTextBox
            // 
            this.nameEntryTextBox.Location = new System.Drawing.Point(197, 19);
            this.nameEntryTextBox.Name = "nameEntryTextBox";
            this.nameEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameEntryTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.withdrawnButton);
            this.groupBox2.Controls.Add(this.depositeButton);
            this.groupBox2.Controls.Add(this.amountTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(22, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tranjaction";
            // 
            // depositeButton
            // 
            this.depositeButton.Location = new System.Drawing.Point(101, 58);
            this.depositeButton.Name = "depositeButton";
            this.depositeButton.Size = new System.Drawing.Size(75, 23);
            this.depositeButton.TabIndex = 1;
            this.depositeButton.Text = "Deposite";
            this.depositeButton.UseVisualStyleBackColor = true;
            this.depositeButton.Click += new System.EventHandler(this.depositeButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(195, 19);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Amount";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.showMeDetailsButton);
            this.groupBox3.Controls.Add(this.dateDisplayTextBox);
            this.groupBox3.Controls.Add(this.nameDisplayTextBox);
            this.groupBox3.Controls.Add(this.balanceDisplayTextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.accountNumberDisplayTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.emailDisplayTextBox);
            this.groupBox3.Location = new System.Drawing.Point(342, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 266);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer And Account Info";
            // 
            // dateDisplayTextBox
            // 
            this.dateDisplayTextBox.Location = new System.Drawing.Point(203, 171);
            this.dateDisplayTextBox.Name = "dateDisplayTextBox";
            this.dateDisplayTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateDisplayTextBox.TabIndex = 1;
            // 
            // nameDisplayTextBox
            // 
            this.nameDisplayTextBox.Location = new System.Drawing.Point(203, 45);
            this.nameDisplayTextBox.Name = "nameDisplayTextBox";
            this.nameDisplayTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameDisplayTextBox.TabIndex = 1;
            // 
            // balanceDisplayTextBox
            // 
            this.balanceDisplayTextBox.Location = new System.Drawing.Point(203, 215);
            this.balanceDisplayTextBox.Name = "balanceDisplayTextBox";
            this.balanceDisplayTextBox.Size = new System.Drawing.Size(100, 20);
            this.balanceDisplayTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Balance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Opening Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customer Name";
            // 
            // accountNumberDisplayTextBox
            // 
            this.accountNumberDisplayTextBox.Location = new System.Drawing.Point(203, 130);
            this.accountNumberDisplayTextBox.Name = "accountNumberDisplayTextBox";
            this.accountNumberDisplayTextBox.Size = new System.Drawing.Size(100, 20);
            this.accountNumberDisplayTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Customer Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Account Number";
            // 
            // emailDisplayTextBox
            // 
            this.emailDisplayTextBox.Location = new System.Drawing.Point(203, 88);
            this.emailDisplayTextBox.Name = "emailDisplayTextBox";
            this.emailDisplayTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailDisplayTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(217, 180);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // withdrawnButton
            // 
            this.withdrawnButton.Location = new System.Drawing.Point(200, 58);
            this.withdrawnButton.Name = "withdrawnButton";
            this.withdrawnButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawnButton.TabIndex = 1;
            this.withdrawnButton.Text = "Withdrawn";
            this.withdrawnButton.UseVisualStyleBackColor = true;
            this.withdrawnButton.Click += new System.EventHandler(this.withdrawnButton_Click);
            // 
            // showMeDetailsButton
            // 
            this.showMeDetailsButton.Location = new System.Drawing.Point(125, 16);
            this.showMeDetailsButton.Name = "showMeDetailsButton";
            this.showMeDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.showMeDetailsButton.TabIndex = 2;
            this.showMeDetailsButton.Text = "Show Me Details";
            this.showMeDetailsButton.UseVisualStyleBackColor = true;
            this.showMeDetailsButton.Click += new System.EventHandler(this.showMeDetailsButton_Click_1);
            // 
            // BankApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 339);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "BankApp";
            this.Text = "Bank UI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dateEntryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox accountNumberEntryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailEntryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameEntryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button depositeButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dateDisplayTextBox;
        private System.Windows.Forms.TextBox nameDisplayTextBox;
        private System.Windows.Forms.TextBox balanceDisplayTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox accountNumberDisplayTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailDisplayTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button withdrawnButton;
        private System.Windows.Forms.Button showMeDetailsButton;
    }
}

