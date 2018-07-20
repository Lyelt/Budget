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
            this.TabControl_Main = new System.Windows.Forms.TabControl();
            this.TabPage_Budget = new System.Windows.Forms.TabPage();
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
            this.Button_AddIncomeOrExpense = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Numeric_Yearly = new System.Windows.Forms.NumericUpDown();
            this.Numeric_Monthly = new System.Windows.Forms.NumericUpDown();
            this.Numeric_Weekly = new System.Windows.Forms.NumericUpDown();
            this.Panel_ManageExpenses = new System.Windows.Forms.Panel();
            this.RadioButton_ManageExpenses = new System.Windows.Forms.RadioButton();
            this.RadioButton_ManageIncome = new System.Windows.Forms.RadioButton();
            this.Panel_ManageIncome = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.newBudgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TextBox_CreateBudget = new System.Windows.Forms.ToolStripTextBox();
            this.TabControl_Main.SuspendLayout();
            this.TabPage_Budget.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SpendingAmount)).BeginInit();
            this.TabPage_Spending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Yearly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Monthly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Weekly)).BeginInit();
            this.Panel_ManageExpenses.SuspendLayout();
            this.Panel_ManageIncome.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Controls.Add(this.TabPage_Budget);
            this.TabControl_Main.Controls.Add(this.TabPage_Spending);
            this.TabControl_Main.Enabled = false;
            this.TabControl_Main.Location = new System.Drawing.Point(12, 27);
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(501, 448);
            this.TabControl_Main.TabIndex = 0;
            // 
            // TabPage_Budget
            // 
            this.TabPage_Budget.Controls.Add(this.RadioButton_ManageIncome);
            this.TabPage_Budget.Controls.Add(this.Panel_ManageIncome);
            this.TabPage_Budget.Controls.Add(this.RadioButton_ManageExpenses);
            this.TabPage_Budget.Controls.Add(this.Button_AddIncomeOrExpense);
            this.TabPage_Budget.Controls.Add(this.label9);
            this.TabPage_Budget.Controls.Add(this.label10);
            this.TabPage_Budget.Controls.Add(this.label11);
            this.TabPage_Budget.Controls.Add(this.Numeric_Weekly);
            this.TabPage_Budget.Controls.Add(this.Numeric_Yearly);
            this.TabPage_Budget.Controls.Add(this.Numeric_Monthly);
            this.TabPage_Budget.Controls.Add(this.Panel_ManageExpenses);
            this.TabPage_Budget.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Budget.Name = "TabPage_Budget";
            this.TabPage_Budget.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Budget.Size = new System.Drawing.Size(493, 422);
            this.TabPage_Budget.TabIndex = 0;
            this.TabPage_Budget.Text = "Budget";
            this.TabPage_Budget.UseVisualStyleBackColor = true;
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
            this.Numeric_SpendingAmount.Location = new System.Drawing.Point(120, 75);
            this.Numeric_SpendingAmount.Name = "Numeric_SpendingAmount";
            this.Numeric_SpendingAmount.Size = new System.Drawing.Size(227, 20);
            this.Numeric_SpendingAmount.TabIndex = 3;
            // 
            // TextBox_SpendingDescription
            // 
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
            this.TabPage_Spending.Size = new System.Drawing.Size(493, 422);
            this.TabPage_Spending.TabIndex = 1;
            this.TabPage_Spending.Text = "Spending";
            this.TabPage_Spending.UseVisualStyleBackColor = true;
            // 
            // ComboBox_IncomeSources
            // 
            this.ComboBox_IncomeSources.FormattingEnabled = true;
            this.ComboBox_IncomeSources.Location = new System.Drawing.Point(76, 16);
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
            // Button_AddIncomeOrExpense
            // 
            this.Button_AddIncomeOrExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AddIncomeOrExpense.Enabled = false;
            this.Button_AddIncomeOrExpense.Location = new System.Drawing.Point(359, 114);
            this.Button_AddIncomeOrExpense.Name = "Button_AddIncomeOrExpense";
            this.Button_AddIncomeOrExpense.Size = new System.Drawing.Size(105, 23);
            this.Button_AddIncomeOrExpense.TabIndex = 15;
            this.Button_AddIncomeOrExpense.Text = "Add To My Budget";
            this.Button_AddIncomeOrExpense.UseVisualStyleBackColor = true;
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
            // Numeric_Yearly
            // 
            this.Numeric_Yearly.Location = new System.Drawing.Point(398, 88);
            this.Numeric_Yearly.Name = "Numeric_Yearly";
            this.Numeric_Yearly.Size = new System.Drawing.Size(66, 20);
            this.Numeric_Yearly.TabIndex = 11;
            // 
            // Numeric_Monthly
            // 
            this.Numeric_Monthly.Location = new System.Drawing.Point(398, 61);
            this.Numeric_Monthly.Name = "Numeric_Monthly";
            this.Numeric_Monthly.Size = new System.Drawing.Size(66, 20);
            this.Numeric_Monthly.TabIndex = 10;
            // 
            // Numeric_Weekly
            // 
            this.Numeric_Weekly.Location = new System.Drawing.Point(398, 32);
            this.Numeric_Weekly.Name = "Numeric_Weekly";
            this.Numeric_Weekly.Size = new System.Drawing.Size(66, 20);
            this.Numeric_Weekly.TabIndex = 9;
            // 
            // Panel_ManageExpenses
            // 
            this.Panel_ManageExpenses.Controls.Add(this.ListBox_ExpenseCategories);
            this.Panel_ManageExpenses.Controls.Add(this.ListBox_Expenses);
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
            this.RadioButton_ManageExpenses.CheckedChanged += new System.EventHandler(this.RadioButton_ManageExpenses_CheckedChanged);
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
            this.RadioButton_ManageIncome.CheckedChanged += new System.EventHandler(this.RadioButton_ManageIncome_CheckedChanged);
            // 
            // Panel_ManageIncome
            // 
            this.Panel_ManageIncome.Controls.Add(this.ComboBox_IncomeSources);
            this.Panel_ManageIncome.Location = new System.Drawing.Point(15, 30);
            this.Panel_ManageIncome.Name = "Panel_ManageIncome";
            this.Panel_ManageIncome.Size = new System.Drawing.Size(327, 51);
            this.Panel_ManageIncome.TabIndex = 19;
            this.Panel_ManageIncome.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Open});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuItem_Open
            // 
            this.MenuItem_Open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBudgetToolStripMenuItem,
            this.toolStripSeparator1});
            this.MenuItem_Open.Name = "MenuItem_Open";
            this.MenuItem_Open.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_Open.Text = "Open";
            this.MenuItem_Open.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuItem_Open_DropDownItemClicked);
            // 
            // newBudgetToolStripMenuItem
            // 
            this.newBudgetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBox_CreateBudget});
            this.newBudgetToolStripMenuItem.Name = "newBudgetToolStripMenuItem";
            this.newBudgetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newBudgetToolStripMenuItem.Text = "New Budget";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // TextBox_CreateBudget
            // 
            this.TextBox_CreateBudget.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_CreateBudget.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBox_CreateBudget.Name = "TextBox_CreateBudget";
            this.TextBox_CreateBudget.Size = new System.Drawing.Size(100, 22);
            this.TextBox_CreateBudget.Text = "Budget name...";
            this.TextBox_CreateBudget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_CreateBudget_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 479);
            this.Controls.Add(this.TabControl_Main);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Lyelt Budgeting";
            this.TabControl_Main.ResumeLayout(false);
            this.TabPage_Budget.ResumeLayout(false);
            this.TabPage_Budget.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SpendingAmount)).EndInit();
            this.TabPage_Spending.ResumeLayout(false);
            this.TabPage_Spending.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Yearly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Monthly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Weekly)).EndInit();
            this.Panel_ManageExpenses.ResumeLayout(false);
            this.Panel_ManageIncome.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Main;
        private System.Windows.Forms.TabPage TabPage_Budget;
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
        private System.Windows.Forms.Button Button_AddIncomeOrExpense;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown Numeric_Yearly;
        private System.Windows.Forms.NumericUpDown Numeric_Monthly;
        private System.Windows.Forms.NumericUpDown Numeric_Weekly;
        private System.Windows.Forms.ListBox ListBox_Expenses;
        private System.Windows.Forms.ListBox ListBox_ExpenseCategories;
        private System.Windows.Forms.Panel Panel_ManageExpenses;
        private System.Windows.Forms.RadioButton RadioButton_ManageExpenses;
        private System.Windows.Forms.RadioButton RadioButton_ManageIncome;
        private System.Windows.Forms.Panel Panel_ManageIncome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem newBudgetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox TextBox_CreateBudget;
    }
}

