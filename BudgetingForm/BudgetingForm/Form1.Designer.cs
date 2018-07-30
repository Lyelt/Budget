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
            this.ComboBox_AddCategory = new System.Windows.Forms.ComboBox();
            this.ComboBox_AddExpense = new System.Windows.Forms.ComboBox();
            this.Label_Difference_Y = new System.Windows.Forms.Label();
            this.Label_Expenses_Y = new System.Windows.Forms.Label();
            this.Label_Income_Y = new System.Windows.Forms.Label();
            this.Label_Difference_M = new System.Windows.Forms.Label();
            this.Label_Expenses_M = new System.Windows.Forms.Label();
            this.Label_Income_M = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.Label_Difference_W = new System.Windows.Forms.Label();
            this.Label_Expenses_W = new System.Windows.Forms.Label();
            this.Label_Income_W = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RadioButton_ManageIncome = new System.Windows.Forms.RadioButton();
            this.RadioButton_ManageExpenses = new System.Windows.Forms.RadioButton();
            this.Button_AddIncomeOrExpense = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Numeric_Weekly = new System.Windows.Forms.NumericUpDown();
            this.Numeric_Yearly = new System.Windows.Forms.NumericUpDown();
            this.Numeric_Monthly = new System.Windows.Forms.NumericUpDown();
            this.Panel_ManageExpenses = new System.Windows.Forms.Panel();
            this.ListBox_ExpenseCategories = new System.Windows.Forms.ListBox();
            this.ListBox_Expenses = new System.Windows.Forms.ListBox();
            this.Panel_ManageIncome = new System.Windows.Forms.Panel();
            this.ComboBox_IncomeSources = new System.Windows.Forms.ComboBox();
            this.TabPage_Spending = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MonthCalendar_SpendingMonth = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_SpendingSubmit = new System.Windows.Forms.Button();
            this.TextBox_SpendingDescription = new System.Windows.Forms.TextBox();
            this.Numeric_SpendingAmount = new System.Windows.Forms.NumericUpDown();
            this.ComboBox_SpendingExpense = new System.Windows.Forms.ComboBox();
            this.ComboBox_SpendingCategory = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_NewBudget = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox_CreateBudget = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TabControl_Main.SuspendLayout();
            this.TabPage_Budget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Weekly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Yearly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Monthly)).BeginInit();
            this.Panel_ManageExpenses.SuspendLayout();
            this.Panel_ManageIncome.SuspendLayout();
            this.TabPage_Spending.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SpendingAmount)).BeginInit();
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
            this.TabPage_Budget.Controls.Add(this.Label_Difference_Y);
            this.TabPage_Budget.Controls.Add(this.Label_Expenses_Y);
            this.TabPage_Budget.Controls.Add(this.Label_Income_Y);
            this.TabPage_Budget.Controls.Add(this.Label_Difference_M);
            this.TabPage_Budget.Controls.Add(this.Label_Expenses_M);
            this.TabPage_Budget.Controls.Add(this.Label_Income_M);
            this.TabPage_Budget.Controls.Add(this.label14);
            this.TabPage_Budget.Controls.Add(this.label13);
            this.TabPage_Budget.Controls.Add(this.label44);
            this.TabPage_Budget.Controls.Add(this.Label_Difference_W);
            this.TabPage_Budget.Controls.Add(this.Label_Expenses_W);
            this.TabPage_Budget.Controls.Add(this.Label_Income_W);
            this.TabPage_Budget.Controls.Add(this.label8);
            this.TabPage_Budget.Controls.Add(this.label7);
            this.TabPage_Budget.Controls.Add(this.label6);
            this.TabPage_Budget.Controls.Add(this.RadioButton_ManageIncome);
            this.TabPage_Budget.Controls.Add(this.RadioButton_ManageExpenses);
            this.TabPage_Budget.Controls.Add(this.Button_AddIncomeOrExpense);
            this.TabPage_Budget.Controls.Add(this.label9);
            this.TabPage_Budget.Controls.Add(this.label10);
            this.TabPage_Budget.Controls.Add(this.label11);
            this.TabPage_Budget.Controls.Add(this.Numeric_Weekly);
            this.TabPage_Budget.Controls.Add(this.Numeric_Yearly);
            this.TabPage_Budget.Controls.Add(this.Numeric_Monthly);
            this.TabPage_Budget.Controls.Add(this.Panel_ManageExpenses);
            this.TabPage_Budget.Controls.Add(this.Panel_ManageIncome);
            this.TabPage_Budget.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Budget.Name = "TabPage_Budget";
            this.TabPage_Budget.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Budget.Size = new System.Drawing.Size(493, 422);
            this.TabPage_Budget.TabIndex = 0;
            this.TabPage_Budget.Text = "Budget";
            this.TabPage_Budget.UseVisualStyleBackColor = true;
            // 
            // ComboBox_AddCategory
            // 
            this.ComboBox_AddCategory.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ComboBox_AddCategory.FormattingEnabled = true;
            this.ComboBox_AddCategory.Location = new System.Drawing.Point(14, 191);
            this.ComboBox_AddCategory.Name = "ComboBox_AddCategory";
            this.ComboBox_AddCategory.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_AddCategory.TabIndex = 36;
            this.ComboBox_AddCategory.Text = "Add or create new...";
            this.ComboBox_AddCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBox_AddCategory_SelectedIndexChanged);
            this.ComboBox_AddCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_AddCategory_KeyPress);
            // 
            // ComboBox_AddExpense
            // 
            this.ComboBox_AddExpense.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ComboBox_AddExpense.FormattingEnabled = true;
            this.ComboBox_AddExpense.Location = new System.Drawing.Point(182, 191);
            this.ComboBox_AddExpense.Name = "ComboBox_AddExpense";
            this.ComboBox_AddExpense.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_AddExpense.TabIndex = 35;
            this.ComboBox_AddExpense.Text = "Add or create new...";
            this.ComboBox_AddExpense.SelectedIndexChanged += new System.EventHandler(this.ComboBox_AddExpense_SelectedIndexChanged);
            this.ComboBox_AddExpense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_AddExpense_KeyPress);
            // 
            // Label_Difference_Y
            // 
            this.Label_Difference_Y.AutoSize = true;
            this.Label_Difference_Y.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label_Difference_Y.Location = new System.Drawing.Point(282, 367);
            this.Label_Difference_Y.Name = "Label_Difference_Y";
            this.Label_Difference_Y.Size = new System.Drawing.Size(34, 13);
            this.Label_Difference_Y.TabIndex = 34;
            this.Label_Difference_Y.Text = "$0.00";
            // 
            // Label_Expenses_Y
            // 
            this.Label_Expenses_Y.AutoSize = true;
            this.Label_Expenses_Y.Location = new System.Drawing.Point(165, 367);
            this.Label_Expenses_Y.Name = "Label_Expenses_Y";
            this.Label_Expenses_Y.Size = new System.Drawing.Size(34, 13);
            this.Label_Expenses_Y.TabIndex = 33;
            this.Label_Expenses_Y.Text = "$0.00";
            // 
            // Label_Income_Y
            // 
            this.Label_Income_Y.AutoSize = true;
            this.Label_Income_Y.Location = new System.Drawing.Point(64, 367);
            this.Label_Income_Y.Name = "Label_Income_Y";
            this.Label_Income_Y.Size = new System.Drawing.Size(34, 13);
            this.Label_Income_Y.TabIndex = 32;
            this.Label_Income_Y.Text = "$0.00";
            // 
            // Label_Difference_M
            // 
            this.Label_Difference_M.AutoSize = true;
            this.Label_Difference_M.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label_Difference_M.Location = new System.Drawing.Point(282, 334);
            this.Label_Difference_M.Name = "Label_Difference_M";
            this.Label_Difference_M.Size = new System.Drawing.Size(34, 13);
            this.Label_Difference_M.TabIndex = 31;
            this.Label_Difference_M.Text = "$0.00";
            // 
            // Label_Expenses_M
            // 
            this.Label_Expenses_M.AutoSize = true;
            this.Label_Expenses_M.Location = new System.Drawing.Point(165, 334);
            this.Label_Expenses_M.Name = "Label_Expenses_M";
            this.Label_Expenses_M.Size = new System.Drawing.Size(34, 13);
            this.Label_Expenses_M.TabIndex = 30;
            this.Label_Expenses_M.Text = "$0.00";
            // 
            // Label_Income_M
            // 
            this.Label_Income_M.AutoSize = true;
            this.Label_Income_M.Location = new System.Drawing.Point(64, 334);
            this.Label_Income_M.Name = "Label_Income_M";
            this.Label_Income_M.Size = new System.Drawing.Size(34, 13);
            this.Label_Income_M.TabIndex = 29;
            this.Label_Income_M.Text = "$0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 367);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Yearly";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 334);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Monthly";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(9, 305);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(49, 13);
            this.label44.TabIndex = 26;
            this.label44.Text = "Weekly";
            // 
            // Label_Difference_W
            // 
            this.Label_Difference_W.AutoSize = true;
            this.Label_Difference_W.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label_Difference_W.Location = new System.Drawing.Point(282, 305);
            this.Label_Difference_W.Name = "Label_Difference_W";
            this.Label_Difference_W.Size = new System.Drawing.Size(34, 13);
            this.Label_Difference_W.TabIndex = 25;
            this.Label_Difference_W.Text = "$0.00";
            // 
            // Label_Expenses_W
            // 
            this.Label_Expenses_W.AutoSize = true;
            this.Label_Expenses_W.Location = new System.Drawing.Point(165, 305);
            this.Label_Expenses_W.Name = "Label_Expenses_W";
            this.Label_Expenses_W.Size = new System.Drawing.Size(34, 13);
            this.Label_Expenses_W.TabIndex = 24;
            this.Label_Expenses_W.Text = "$0.00";
            // 
            // Label_Income_W
            // 
            this.Label_Income_W.AutoSize = true;
            this.Label_Income_W.Location = new System.Drawing.Point(64, 305);
            this.Label_Income_W.Name = "Label_Income_W";
            this.Label_Income_W.Size = new System.Drawing.Size(34, 13);
            this.Label_Income_W.TabIndex = 23;
            this.Label_Income_W.Text = "$0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(285, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Difference";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(168, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total Expenses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total Income";
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
            // Button_AddIncomeOrExpense
            // 
            this.Button_AddIncomeOrExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AddIncomeOrExpense.Enabled = false;
            this.Button_AddIncomeOrExpense.Location = new System.Drawing.Point(359, 114);
            this.Button_AddIncomeOrExpense.Name = "Button_AddIncomeOrExpense";
            this.Button_AddIncomeOrExpense.Size = new System.Drawing.Size(105, 23);
            this.Button_AddIncomeOrExpense.TabIndex = 15;
            this.Button_AddIncomeOrExpense.Text = "Confirm";
            this.Button_AddIncomeOrExpense.UseVisualStyleBackColor = true;
            this.Button_AddIncomeOrExpense.Click += new System.EventHandler(this.Button_AddIncomeOrExpense_Click);
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
            // Numeric_Weekly
            // 
            this.Numeric_Weekly.DecimalPlaces = 2;
            this.Numeric_Weekly.Location = new System.Drawing.Point(398, 32);
            this.Numeric_Weekly.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Numeric_Weekly.Name = "Numeric_Weekly";
            this.Numeric_Weekly.Size = new System.Drawing.Size(66, 20);
            this.Numeric_Weekly.TabIndex = 9;
            this.Numeric_Weekly.ThousandsSeparator = true;
            // 
            // Numeric_Yearly
            // 
            this.Numeric_Yearly.DecimalPlaces = 2;
            this.Numeric_Yearly.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Numeric_Yearly.Location = new System.Drawing.Point(398, 88);
            this.Numeric_Yearly.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Numeric_Yearly.Name = "Numeric_Yearly";
            this.Numeric_Yearly.Size = new System.Drawing.Size(66, 20);
            this.Numeric_Yearly.TabIndex = 11;
            this.Numeric_Yearly.ThousandsSeparator = true;
            // 
            // Numeric_Monthly
            // 
            this.Numeric_Monthly.DecimalPlaces = 2;
            this.Numeric_Monthly.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Numeric_Monthly.Location = new System.Drawing.Point(398, 61);
            this.Numeric_Monthly.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Numeric_Monthly.Name = "Numeric_Monthly";
            this.Numeric_Monthly.Size = new System.Drawing.Size(66, 20);
            this.Numeric_Monthly.TabIndex = 10;
            this.Numeric_Monthly.ThousandsSeparator = true;
            // 
            // Panel_ManageExpenses
            // 
            this.Panel_ManageExpenses.Controls.Add(this.ComboBox_AddCategory);
            this.Panel_ManageExpenses.Controls.Add(this.ListBox_ExpenseCategories);
            this.Panel_ManageExpenses.Controls.Add(this.ComboBox_AddExpense);
            this.Panel_ManageExpenses.Controls.Add(this.ListBox_Expenses);
            this.Panel_ManageExpenses.Location = new System.Drawing.Point(18, 34);
            this.Panel_ManageExpenses.Name = "Panel_ManageExpenses";
            this.Panel_ManageExpenses.Size = new System.Drawing.Size(315, 221);
            this.Panel_ManageExpenses.TabIndex = 16;
            // 
            // ListBox_ExpenseCategories
            // 
            this.ListBox_ExpenseCategories.FormattingEnabled = true;
            this.ListBox_ExpenseCategories.Location = new System.Drawing.Point(14, 12);
            this.ListBox_ExpenseCategories.Name = "ListBox_ExpenseCategories";
            this.ListBox_ExpenseCategories.Size = new System.Drawing.Size(120, 173);
            this.ListBox_ExpenseCategories.TabIndex = 0;
            this.ListBox_ExpenseCategories.SelectedIndexChanged += new System.EventHandler(this.ListBox_ExpenseCategories_SelectedIndexChanged);
            // 
            // ListBox_Expenses
            // 
            this.ListBox_Expenses.FormattingEnabled = true;
            this.ListBox_Expenses.Location = new System.Drawing.Point(183, 12);
            this.ListBox_Expenses.Name = "ListBox_Expenses";
            this.ListBox_Expenses.Size = new System.Drawing.Size(120, 173);
            this.ListBox_Expenses.TabIndex = 1;
            this.ListBox_Expenses.SelectedIndexChanged += new System.EventHandler(this.ListBox_Expenses_SelectedIndexChanged);
            // 
            // Panel_ManageIncome
            // 
            this.Panel_ManageIncome.Controls.Add(this.ComboBox_IncomeSources);
            this.Panel_ManageIncome.Location = new System.Drawing.Point(15, 30);
            this.Panel_ManageIncome.Name = "Panel_ManageIncome";
            this.Panel_ManageIncome.Size = new System.Drawing.Size(327, 78);
            this.Panel_ManageIncome.TabIndex = 19;
            this.Panel_ManageIncome.Visible = false;
            // 
            // ComboBox_IncomeSources
            // 
            this.ComboBox_IncomeSources.FormattingEnabled = true;
            this.ComboBox_IncomeSources.Location = new System.Drawing.Point(6, 7);
            this.ComboBox_IncomeSources.Name = "ComboBox_IncomeSources";
            this.ComboBox_IncomeSources.Size = new System.Drawing.Size(182, 21);
            this.ComboBox_IncomeSources.TabIndex = 0;
            this.ComboBox_IncomeSources.Text = "Select income source...";
            this.ComboBox_IncomeSources.SelectedIndexChanged += new System.EventHandler(this.ComboBox_IncomeSources_SelectedIndexChanged);
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
            // MonthCalendar_SpendingMonth
            // 
            this.MonthCalendar_SpendingMonth.Location = new System.Drawing.Point(120, 133);
            this.MonthCalendar_SpendingMonth.Name = "MonthCalendar_SpendingMonth";
            this.MonthCalendar_SpendingMonth.TabIndex = 4;
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
            // TextBox_SpendingDescription
            // 
            this.TextBox_SpendingDescription.Location = new System.Drawing.Point(120, 101);
            this.TextBox_SpendingDescription.Multiline = true;
            this.TextBox_SpendingDescription.Name = "TextBox_SpendingDescription";
            this.TextBox_SpendingDescription.Size = new System.Drawing.Size(227, 20);
            this.TextBox_SpendingDescription.TabIndex = 4;
            // 
            // Numeric_SpendingAmount
            // 
            this.Numeric_SpendingAmount.Location = new System.Drawing.Point(120, 75);
            this.Numeric_SpendingAmount.Name = "Numeric_SpendingAmount";
            this.Numeric_SpendingAmount.Size = new System.Drawing.Size(227, 20);
            this.Numeric_SpendingAmount.TabIndex = 3;
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
            // ComboBox_SpendingCategory
            // 
            this.ComboBox_SpendingCategory.FormattingEnabled = true;
            this.ComboBox_SpendingCategory.Location = new System.Drawing.Point(120, 21);
            this.ComboBox_SpendingCategory.Name = "ComboBox_SpendingCategory";
            this.ComboBox_SpendingCategory.Size = new System.Drawing.Size(227, 21);
            this.ComboBox_SpendingCategory.TabIndex = 1;
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
            this.MenuItem_NewBudget,
            this.toolStripSeparator1});
            this.MenuItem_Open.Name = "MenuItem_Open";
            this.MenuItem_Open.Size = new System.Drawing.Size(103, 22);
            this.MenuItem_Open.Text = "Open";
            this.MenuItem_Open.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuItem_Open_DropDownItemClicked);
            // 
            // MenuItem_NewBudget
            // 
            this.MenuItem_NewBudget.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBox_CreateBudget});
            this.MenuItem_NewBudget.Name = "MenuItem_NewBudget";
            this.MenuItem_NewBudget.Size = new System.Drawing.Size(139, 22);
            this.MenuItem_NewBudget.Text = "New Budget";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
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
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Weekly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Yearly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Monthly)).EndInit();
            this.Panel_ManageExpenses.ResumeLayout(false);
            this.Panel_ManageIncome.ResumeLayout(false);
            this.TabPage_Spending.ResumeLayout(false);
            this.TabPage_Spending.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_SpendingAmount)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem MenuItem_NewBudget;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox TextBox_CreateBudget;
        private System.Windows.Forms.Label Label_Difference_W;
        private System.Windows.Forms.Label Label_Expenses_W;
        private System.Windows.Forms.Label Label_Income_W;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Label_Difference_Y;
        private System.Windows.Forms.Label Label_Expenses_Y;
        private System.Windows.Forms.Label Label_Income_Y;
        private System.Windows.Forms.Label Label_Difference_M;
        private System.Windows.Forms.Label Label_Expenses_M;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label Label_Income_M;
        private System.Windows.Forms.ComboBox ComboBox_AddCategory;
        private System.Windows.Forms.ComboBox ComboBox_AddExpense;
    }
}

