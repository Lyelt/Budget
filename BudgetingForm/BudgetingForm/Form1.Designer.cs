namespace BudgetingForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage_Budget = new System.Windows.Forms.TabPage();
            this.ComboBox_SelectedBudget = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBox_SpendingCategory = new System.Windows.Forms.ComboBox();
            this.ComboBox_SpendingExpense = new System.Windows.Forms.ComboBox();
            this.Numeric_SpendingAmount = new System.Windows.Forms.NumericUpDown();
            this.TextBox_SpendingDescription = new System.Windows.Forms.TextBox();
            this.Button_SpendingSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MonthCalendar_SpendingMonth = new System.Windows.Forms.MonthCalendar();
            this.TabPage_Spending = new System.Windows.Forms.TabPage();
            this.ComboBox_IncomeSources = new System.Windows.Forms.ComboBox();
            this.ListBox_ExpenseCategories = new System.Windows.Forms.ListBox();
            this.ListBox_Expenses = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.Panel_ManageExpenses = new System.Windows.Forms.Panel();
            this.RadioButton_ManageExpenses = new System.Windows.Forms.RadioButton();
            this.RadioButton_ManageIncome = new System.Windows.Forms.RadioButton();
            this.Panel_ManageIncome = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.TabPage_Budget.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SpendingAmount)).BeginInit();
            this.TabPage_Spending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.Panel_ManageExpenses.SuspendLayout();
            this.Panel_ManageIncome.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPage_Budget);
            this.tabControl1.Controls.Add(this.TabPage_Spending);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPage_Budget
            // 
            this.TabPage_Budget.Controls.Add(this.RadioButton_ManageIncome);
            this.TabPage_Budget.Controls.Add(this.RadioButton_ManageExpenses);
            this.TabPage_Budget.Controls.Add(this.Panel_ManageExpenses);
            this.TabPage_Budget.Controls.Add(this.button2);
            this.TabPage_Budget.Controls.Add(this.label9);
            this.TabPage_Budget.Controls.Add(this.label10);
            this.TabPage_Budget.Controls.Add(this.label11);
            this.TabPage_Budget.Controls.Add(this.numericUpDown6);
            this.TabPage_Budget.Controls.Add(this.numericUpDown4);
            this.TabPage_Budget.Controls.Add(this.numericUpDown5);
            this.TabPage_Budget.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Budget.Name = "TabPage_Budget";
            this.TabPage_Budget.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Budget.Size = new System.Drawing.Size(926, 572);
            this.TabPage_Budget.TabIndex = 0;
            this.TabPage_Budget.Text = "Budget";
            this.TabPage_Budget.UseVisualStyleBackColor = true;
            // 
            // ComboBox_SelectedBudget
            // 
            this.ComboBox_SelectedBudget.FormattingEnabled = true;
            this.ComboBox_SelectedBudget.Location = new System.Drawing.Point(12, 4);
            this.ComboBox_SelectedBudget.Name = "ComboBox_SelectedBudget";
            this.ComboBox_SelectedBudget.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_SelectedBudget.TabIndex = 1;
            this.ComboBox_SelectedBudget.Text = "Select a budget...";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.MonthCalendar_SpendingMonth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Button_SpendingSubmit);
            this.groupBox1.Controls.Add(this.TextBox_SpendingDescription);
            this.groupBox1.Controls.Add(this.Numeric_SpendingAmount);
            this.groupBox1.Controls.Add(this.ComboBox_SpendingExpense);
            this.groupBox1.Controls.Add(this.ComboBox_SpendingCategory);
            this.groupBox1.Location = new System.Drawing.Point(20, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 349);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add A Receipt";
            // 
            // ComboBox_SpendingCategory
            // 
            this.ComboBox_SpendingCategory.FormattingEnabled = true;
            this.ComboBox_SpendingCategory.Location = new System.Drawing.Point(120, 21);
            this.ComboBox_SpendingCategory.Name = "ComboBox_SpendingCategory";
            this.ComboBox_SpendingCategory.Size = new System.Drawing.Size(227, 21);
            this.ComboBox_SpendingCategory.TabIndex = 1;
            // 
            // ComboBox_SpendingExpense
            // 
            this.ComboBox_SpendingExpense.Enabled = false;
            this.ComboBox_SpendingExpense.FormattingEnabled = true;
            this.ComboBox_SpendingExpense.Location = new System.Drawing.Point(120, 48);
            this.ComboBox_SpendingExpense.Name = "ComboBox_SpendingExpense";
            this.ComboBox_SpendingExpense.Size = new System.Drawing.Size(227, 21);
            this.ComboBox_SpendingExpense.TabIndex = 2;
            // 
            // Numeric_SpendingAmount
            // 
            this.Numeric_SpendingAmount.Enabled = false;
            this.Numeric_SpendingAmount.Location = new System.Drawing.Point(120, 75);
            this.Numeric_SpendingAmount.Name = "Numeric_SpendingAmount";
            this.Numeric_SpendingAmount.Size = new System.Drawing.Size(227, 20);
            this.Numeric_SpendingAmount.TabIndex = 3;
            // 
            // TextBox_SpendingDescription
            // 
            this.TextBox_SpendingDescription.Enabled = false;
            this.TextBox_SpendingDescription.Location = new System.Drawing.Point(120, 101);
            this.TextBox_SpendingDescription.Multiline = true;
            this.TextBox_SpendingDescription.Name = "TextBox_SpendingDescription";
            this.TextBox_SpendingDescription.Size = new System.Drawing.Size(227, 20);
            this.TextBox_SpendingDescription.TabIndex = 4;
            // 
            // Button_SpendingSubmit
            // 
            this.Button_SpendingSubmit.Enabled = false;
            this.Button_SpendingSubmit.Location = new System.Drawing.Point(241, 307);
            this.Button_SpendingSubmit.Name = "Button_SpendingSubmit";
            this.Button_SpendingSubmit.Size = new System.Drawing.Size(106, 23);
            this.Button_SpendingSubmit.TabIndex = 6;
            this.Button_SpendingSubmit.Text = "Submit";
            this.Button_SpendingSubmit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Expense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // MonthCalendar_SpendingMonth
            // 
            this.MonthCalendar_SpendingMonth.Location = new System.Drawing.Point(120, 133);
            this.MonthCalendar_SpendingMonth.Name = "MonthCalendar_SpendingMonth";
            this.MonthCalendar_SpendingMonth.TabIndex = 4;
            // 
            // TabPage_Spending
            // 
            this.TabPage_Spending.Controls.Add(this.groupBox1);
            this.TabPage_Spending.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Spending.Name = "TabPage_Spending";
            this.TabPage_Spending.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Spending.Size = new System.Drawing.Size(926, 572);
            this.TabPage_Spending.TabIndex = 1;
            this.TabPage_Spending.Text = "Spending";
            this.TabPage_Spending.UseVisualStyleBackColor = true;
            // 
            // ComboBox_IncomeSources
            // 
            this.ComboBox_IncomeSources.FormattingEnabled = true;
            this.ComboBox_IncomeSources.Location = new System.Drawing.Point(121, 20);
            this.ComboBox_IncomeSources.Name = "ComboBox_IncomeSources";
            this.ComboBox_IncomeSources.Size = new System.Drawing.Size(182, 21);
            this.ComboBox_IncomeSources.TabIndex = 0;
            this.ComboBox_IncomeSources.Text = "Select or create income source...";
            // 
            // ListBox_ExpenseCategories
            // 
            this.ListBox_ExpenseCategories.FormattingEnabled = true;
            this.ListBox_ExpenseCategories.Location = new System.Drawing.Point(14, 12);
            this.ListBox_ExpenseCategories.Name = "ListBox_ExpenseCategories";
            this.ListBox_ExpenseCategories.Size = new System.Drawing.Size(120, 173);
            this.ListBox_ExpenseCategories.TabIndex = 0;
            // 
            // ListBox_Expenses
            // 
            this.ListBox_Expenses.FormattingEnabled = true;
            this.ListBox_Expenses.Location = new System.Drawing.Point(183, 12);
            this.ListBox_Expenses.Name = "ListBox_Expenses";
            this.ListBox_Expenses.Size = new System.Drawing.Size(120, 173);
            this.ListBox_Expenses.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(359, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Add To My Budget";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Yearly";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Monthly";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(349, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Weekly";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(398, 88);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown4.TabIndex = 11;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(398, 61);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown5.TabIndex = 10;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(398, 32);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown6.TabIndex = 9;
            // 
            // Panel_ManageExpenses
            // 
            this.Panel_ManageExpenses.Controls.Add(this.ListBox_ExpenseCategories);
            this.Panel_ManageExpenses.Controls.Add(this.ListBox_Expenses);
            this.Panel_ManageExpenses.Controls.Add(this.Panel_ManageIncome);
            this.Panel_ManageExpenses.Location = new System.Drawing.Point(18, 34);
            this.Panel_ManageExpenses.Name = "Panel_ManageExpenses";
            this.Panel_ManageExpenses.Size = new System.Drawing.Size(315, 221);
            this.Panel_ManageExpenses.TabIndex = 16;
            // 
            // RadioButton_ManageExpenses
            // 
            this.RadioButton_ManageExpenses.AutoSize = true;
            this.RadioButton_ManageExpenses.Checked = true;
            this.RadioButton_ManageExpenses.Location = new System.Drawing.Point(18, 7);
            this.RadioButton_ManageExpenses.Name = "RadioButton_ManageExpenses";
            this.RadioButton_ManageExpenses.Size = new System.Drawing.Size(113, 17);
            this.RadioButton_ManageExpenses.TabIndex = 17;
            this.RadioButton_ManageExpenses.TabStop = true;
            this.RadioButton_ManageExpenses.Text = "Manage Expenses";
            this.RadioButton_ManageExpenses.UseVisualStyleBackColor = true;
            // 
            // RadioButton_ManageIncome
            // 
            this.RadioButton_ManageIncome.AutoSize = true;
            this.RadioButton_ManageIncome.Location = new System.Drawing.Point(148, 7);
            this.RadioButton_ManageIncome.Name = "RadioButton_ManageIncome";
            this.RadioButton_ManageIncome.Size = new System.Drawing.Size(102, 17);
            this.RadioButton_ManageIncome.TabIndex = 18;
            this.RadioButton_ManageIncome.TabStop = true;
            this.RadioButton_ManageIncome.Text = "Manage Income";
            this.RadioButton_ManageIncome.UseVisualStyleBackColor = true;
            // 
            // Panel_ManageIncome
            // 
            this.Panel_ManageIncome.Controls.Add(this.ComboBox_IncomeSources);
            this.Panel_ManageIncome.Location = new System.Drawing.Point(0, 0);
            this.Panel_ManageIncome.Name = "Panel_ManageIncome";
            this.Panel_ManageIncome.Size = new System.Drawing.Size(315, 55);
            this.Panel_ManageIncome.TabIndex = 19;
            this.Panel_ManageIncome.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 641);
            this.Controls.Add(this.ComboBox_SelectedBudget);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Lyelt Budgeting";
            this.tabControl1.ResumeLayout(false);
            this.TabPage_Budget.ResumeLayout(false);
            this.TabPage_Budget.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SpendingAmount)).EndInit();
            this.TabPage_Spending.ResumeLayout(false);
            this.TabPage_Spending.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.Panel_ManageExpenses.ResumeLayout(false);
            this.Panel_ManageIncome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage_Budget;
        private System.Windows.Forms.ComboBox ComboBox_SelectedBudget;
        private System.Windows.Forms.TabPage TabPage_Spending;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar MonthCalendar_SpendingMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_SpendingSubmit;
        private System.Windows.Forms.TextBox TextBox_SpendingDescription;
        private System.Windows.Forms.NumericUpDown Numeric_SpendingAmount;
        private System.Windows.Forms.ComboBox ComboBox_SpendingExpense;
        private System.Windows.Forms.ComboBox ComboBox_SpendingCategory;
        private System.Windows.Forms.ComboBox ComboBox_IncomeSources;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.ListBox ListBox_Expenses;
        private System.Windows.Forms.ListBox ListBox_ExpenseCategories;
        private System.Windows.Forms.Panel Panel_ManageExpenses;
        private System.Windows.Forms.RadioButton RadioButton_ManageExpenses;
        private System.Windows.Forms.RadioButton RadioButton_ManageIncome;
        private System.Windows.Forms.Panel Panel_ManageIncome;
    }
}

