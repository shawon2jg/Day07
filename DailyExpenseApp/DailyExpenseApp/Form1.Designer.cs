namespace DailyExpenseApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.catagoryComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.particularTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maximumExpenseTextBox = new System.Windows.Forms.TextBox();
            this.totalExpenseTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.showListBox = new System.Windows.Forms.ListBox();
            this.viewShowButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.viewCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.catagoryComboBox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.particularTextBox);
            this.groupBox1.Controls.Add(this.amountTextBox);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Expense Entry";
            // 
            // catagoryComboBox
            // 
            this.catagoryComboBox.FormattingEnabled = true;
            this.catagoryComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.catagoryComboBox.Location = new System.Drawing.Point(137, 71);
            this.catagoryComboBox.Name = "catagoryComboBox";
            this.catagoryComboBox.Size = new System.Drawing.Size(172, 21);
            this.catagoryComboBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(208, 149);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(101, 25);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Particular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount";
            // 
            // particularTextBox
            // 
            this.particularTextBox.Location = new System.Drawing.Point(137, 106);
            this.particularTextBox.Name = "particularTextBox";
            this.particularTextBox.Size = new System.Drawing.Size(173, 20);
            this.particularTextBox.TabIndex = 0;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(137, 31);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(173, 20);
            this.amountTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.maximumExpenseTextBox);
            this.groupBox2.Controls.Add(this.totalExpenseTextBox);
            this.groupBox2.Location = new System.Drawing.Point(17, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Summary";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(207, 36);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(102, 25);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Maximum Expense";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Expense";
            // 
            // maximumExpenseTextBox
            // 
            this.maximumExpenseTextBox.Location = new System.Drawing.Point(123, 115);
            this.maximumExpenseTextBox.Name = "maximumExpenseTextBox";
            this.maximumExpenseTextBox.Size = new System.Drawing.Size(186, 20);
            this.maximumExpenseTextBox.TabIndex = 0;
            // 
            // totalExpenseTextBox
            // 
            this.totalExpenseTextBox.Location = new System.Drawing.Point(123, 78);
            this.totalExpenseTextBox.Name = "totalExpenseTextBox";
            this.totalExpenseTextBox.Size = new System.Drawing.Size(186, 20);
            this.totalExpenseTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.totalTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.showListBox);
            this.groupBox3.Controls.Add(this.viewShowButton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.viewCategoryComboBox);
            this.groupBox3.Location = new System.Drawing.Point(398, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 415);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Catagorywise Expense";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(96, 371);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(202, 20);
            this.totalTextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total";
            // 
            // showListBox
            // 
            this.showListBox.FormattingEnabled = true;
            this.showListBox.Location = new System.Drawing.Point(45, 167);
            this.showListBox.Name = "showListBox";
            this.showListBox.Size = new System.Drawing.Size(253, 173);
            this.showListBox.TabIndex = 3;
            // 
            // viewShowButton
            // 
            this.viewShowButton.Location = new System.Drawing.Point(235, 97);
            this.viewShowButton.Name = "viewShowButton";
            this.viewShowButton.Size = new System.Drawing.Size(75, 30);
            this.viewShowButton.TabIndex = 2;
            this.viewShowButton.Text = "Show";
            this.viewShowButton.UseVisualStyleBackColor = true;
            this.viewShowButton.Click += new System.EventHandler(this.viewShowButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Category";
            // 
            // viewCategoryComboBox
            // 
            this.viewCategoryComboBox.FormattingEnabled = true;
            this.viewCategoryComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.viewCategoryComboBox.Location = new System.Drawing.Point(128, 48);
            this.viewCategoryComboBox.Name = "viewCategoryComboBox";
            this.viewCategoryComboBox.Size = new System.Drawing.Size(183, 21);
            this.viewCategoryComboBox.TabIndex = 0;
            this.viewCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.viewCategoryComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 484);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ComboBox catagoryComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox particularTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maximumExpenseTextBox;
        private System.Windows.Forms.TextBox totalExpenseTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox showListBox;
        private System.Windows.Forms.Button viewShowButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox viewCategoryComboBox;
    }
}

