namespace Finance
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.button_income = new System.Windows.Forms.Button();
            this.button_expense = new System.Windows.Forms.Button();
            this.Add_record = new System.Windows.Forms.Button();
            this.dataGridView_finance = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet = new Finance.financeDataSet();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomeTableAdapter = new Finance.financeDataSetTableAdapters.incomeTableAdapter();
            this.add_rec = new System.Windows.Forms.Panel();
            this.panelAddCategory = new System.Windows.Forms.Panel();
            this.textBoxAddCategory = new System.Windows.Forms.TextBox();
            this.buttonCategoryAdd = new System.Windows.Forms.Button();
            this.buttonCategoryCancel = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonExp = new System.Windows.Forms.Button();
            this.buttonInc = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFinance = new System.Windows.Forms.DateTimePicker();
            this.cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.expenseTableAdapter = new Finance.financeDataSetTableAdapters.expenseTableAdapter();
            this.balance = new System.Windows.Forms.Label();
            this.buttonDeleteRecord = new System.Windows.Forms.Button();
            this.buttonEditRecord = new System.Windows.Forms.Button();
            this.buttonToday = new System.Windows.Forms.Button();
            this.buttonWeek = new System.Windows.Forms.Button();
            this.buttonMonth = new System.Windows.Forms.Button();
            this.buttonYear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_finance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            this.add_rec.SuspendLayout();
            this.panelAddCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_income
            // 
            this.button_income.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button_income.Font = new System.Drawing.Font("Montserrat", 8F);
            this.button_income.ForeColor = System.Drawing.Color.Black;
            this.button_income.Location = new System.Drawing.Point(31, 32);
            this.button_income.Name = "button_income";
            this.button_income.Size = new System.Drawing.Size(97, 45);
            this.button_income.TabIndex = 0;
            this.button_income.Text = "Доходы";
            this.button_income.UseVisualStyleBackColor = false;
            this.button_income.Click += new System.EventHandler(this.button_income_Click);
            // 
            // button_expense
            // 
            this.button_expense.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button_expense.Font = new System.Drawing.Font("Montserrat", 8F);
            this.button_expense.ForeColor = System.Drawing.Color.Black;
            this.button_expense.Location = new System.Drawing.Point(134, 32);
            this.button_expense.Name = "button_expense";
            this.button_expense.Size = new System.Drawing.Size(97, 45);
            this.button_expense.TabIndex = 1;
            this.button_expense.Text = "Расходы";
            this.button_expense.UseVisualStyleBackColor = false;
            this.button_expense.Click += new System.EventHandler(this.button_expense_Click);
            // 
            // Add_record
            // 
            this.Add_record.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Add_record.Font = new System.Drawing.Font("Montserrat", 8F);
            this.Add_record.ForeColor = System.Drawing.Color.Black;
            this.Add_record.Location = new System.Drawing.Point(237, 32);
            this.Add_record.Name = "Add_record";
            this.Add_record.Size = new System.Drawing.Size(162, 45);
            this.Add_record.TabIndex = 2;
            this.Add_record.Text = "Добавить запись";
            this.Add_record.UseVisualStyleBackColor = false;
            this.Add_record.Click += new System.EventHandler(this.Add_record_Click);
            // 
            // dataGridView_finance
            // 
            this.dataGridView_finance.AllowUserToAddRows = false;
            this.dataGridView_finance.AllowUserToDeleteRows = false;
            this.dataGridView_finance.AutoGenerateColumns = false;
            this.dataGridView_finance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_finance.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_finance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_finance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_finance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.description,
            this.data,
            this.sum});
            this.dataGridView_finance.DataSource = this.financeDataSetBindingSource;
            this.dataGridView_finance.GridColor = System.Drawing.Color.Black;
            this.dataGridView_finance.Location = new System.Drawing.Point(31, 118);
            this.dataGridView_finance.MultiSelect = false;
            this.dataGridView_finance.Name = "dataGridView_finance";
            this.dataGridView_finance.ReadOnly = true;
            this.dataGridView_finance.RowHeadersWidth = 51;
            this.dataGridView_finance.RowTemplate.Height = 24;
            this.dataGridView_finance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_finance.Size = new System.Drawing.Size(523, 338);
            this.dataGridView_finance.TabIndex = 3;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Наименование";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Коментарий";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Дата";
            this.data.MinimumWidth = 6;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // sum
            // 
            this.sum.DataPropertyName = "sum";
            this.sum.HeaderText = "Сумма";
            this.sum.MinimumWidth = 6;
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            // 
            // financeDataSetBindingSource
            // 
            this.financeDataSetBindingSource.DataSource = this.financeDataSet;
            this.financeDataSetBindingSource.Position = 0;
            // 
            // financeDataSet
            // 
            this.financeDataSet.DataSetName = "financeDataSet";
            this.financeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataMember = "expense";
            this.expenseBindingSource.DataSource = this.financeDataSetBindingSource;
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataMember = "income";
            this.incomeBindingSource.DataSource = this.financeDataSet;
            // 
            // incomeTableAdapter
            // 
            this.incomeTableAdapter.ClearBeforeFill = true;
            // 
            // add_rec
            // 
            this.add_rec.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_rec.Controls.Add(this.panelAddCategory);
            this.add_rec.Controls.Add(this.buttonAddCategory);
            this.add_rec.Controls.Add(this.buttonExp);
            this.add_rec.Controls.Add(this.buttonInc);
            this.add_rec.Controls.Add(this.comboBoxCategory);
            this.add_rec.Controls.Add(this.label4);
            this.add_rec.Controls.Add(this.dateTimePickerFinance);
            this.add_rec.Controls.Add(this.cancel);
            this.add_rec.Controls.Add(this.label5);
            this.add_rec.Controls.Add(this.label3);
            this.add_rec.Controls.Add(this.textSum);
            this.add_rec.Controls.Add(this.label2);
            this.add_rec.Controls.Add(this.label1);
            this.add_rec.Controls.Add(this.textDescription);
            this.add_rec.Controls.Add(this.buttonDelete);
            this.add_rec.Controls.Add(this.buttonSave);
            this.add_rec.Controls.Add(this.Create);
            this.add_rec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.add_rec.ForeColor = System.Drawing.Color.BlueViolet;
            this.add_rec.Location = new System.Drawing.Point(0, 25);
            this.add_rec.Name = "add_rec";
            this.add_rec.Size = new System.Drawing.Size(591, 524);
            this.add_rec.TabIndex = 4;
            this.add_rec.Visible = false;
            // 
            // panelAddCategory
            // 
            this.panelAddCategory.Controls.Add(this.textBoxAddCategory);
            this.panelAddCategory.Controls.Add(this.buttonCategoryAdd);
            this.panelAddCategory.Controls.Add(this.buttonCategoryCancel);
            this.panelAddCategory.Location = new System.Drawing.Point(0, 63);
            this.panelAddCategory.Name = "panelAddCategory";
            this.panelAddCategory.Size = new System.Drawing.Size(591, 470);
            this.panelAddCategory.TabIndex = 33;
            this.panelAddCategory.Visible = false;
            // 
            // textBoxAddCategory
            // 
            this.textBoxAddCategory.Location = new System.Drawing.Point(21, 32);
            this.textBoxAddCategory.Name = "textBoxAddCategory";
            this.textBoxAddCategory.Size = new System.Drawing.Size(379, 22);
            this.textBoxAddCategory.TabIndex = 34;
            // 
            // buttonCategoryAdd
            // 
            this.buttonCategoryAdd.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonCategoryAdd.Font = new System.Drawing.Font("Montserrat", 8F);
            this.buttonCategoryAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonCategoryAdd.Location = new System.Drawing.Point(23, 80);
            this.buttonCategoryAdd.Name = "buttonCategoryAdd";
            this.buttonCategoryAdd.Size = new System.Drawing.Size(187, 46);
            this.buttonCategoryAdd.TabIndex = 33;
            this.buttonCategoryAdd.Text = "Добавить";
            this.buttonCategoryAdd.UseVisualStyleBackColor = false;
            this.buttonCategoryAdd.Click += new System.EventHandler(this.buttonCategoryAdd_Click);
            // 
            // buttonCategoryCancel
            // 
            this.buttonCategoryCancel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonCategoryCancel.Font = new System.Drawing.Font("Montserrat", 8F);
            this.buttonCategoryCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCategoryCancel.Location = new System.Drawing.Point(216, 80);
            this.buttonCategoryCancel.Name = "buttonCategoryCancel";
            this.buttonCategoryCancel.Size = new System.Drawing.Size(187, 46);
            this.buttonCategoryCancel.TabIndex = 32;
            this.buttonCategoryCancel.Text = "Отмена";
            this.buttonCategoryCancel.UseVisualStyleBackColor = false;
            this.buttonCategoryCancel.Click += new System.EventHandler(this.buttonCategoryCancel_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonAddCategory.Font = new System.Drawing.Font("Montserrat", 8F);
            this.buttonAddCategory.ForeColor = System.Drawing.Color.Black;
            this.buttonAddCategory.Location = new System.Drawing.Point(501, 85);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(31, 29);
            this.buttonAddCategory.TabIndex = 32;
            this.buttonAddCategory.Text = "+";
            this.buttonAddCategory.UseVisualStyleBackColor = false;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonExp
            // 
            this.buttonExp.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonExp.Font = new System.Drawing.Font("Montserrat", 8F);
            this.buttonExp.ForeColor = System.Drawing.Color.Black;
            this.buttonExp.Location = new System.Drawing.Point(212, 11);
            this.buttonExp.Name = "buttonExp";
            this.buttonExp.Size = new System.Drawing.Size(187, 46);
            this.buttonExp.TabIndex = 31;
            this.buttonExp.Text = "Расход";
            this.buttonExp.UseVisualStyleBackColor = false;
            this.buttonExp.Click += new System.EventHandler(this.buttonExp_Click);
            // 
            // buttonInc
            // 
            this.buttonInc.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonInc.Font = new System.Drawing.Font("Montserrat", 8F);
            this.buttonInc.ForeColor = System.Drawing.Color.Crimson;
            this.buttonInc.Location = new System.Drawing.Point(19, 11);
            this.buttonInc.Name = "buttonInc";
            this.buttonInc.Size = new System.Drawing.Size(187, 46);
            this.buttonInc.TabIndex = 30;
            this.buttonInc.Text = "Доход";
            this.buttonInc.UseVisualStyleBackColor = false;
            this.buttonInc.Click += new System.EventHandler(this.buttonInc_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(19, 88);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(477, 24);
            this.comboBoxCategory.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Location = new System.Drawing.Point(17, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Дата";
            // 
            // dateTimePickerFinance
            // 
            this.dateTimePickerFinance.Font = new System.Drawing.Font("Montserrat", 8F);
            this.dateTimePickerFinance.Location = new System.Drawing.Point(20, 256);
            this.dateTimePickerFinance.Name = "dateTimePickerFinance";
            this.dateTimePickerFinance.Size = new System.Drawing.Size(545, 24);
            this.dateTimePickerFinance.TabIndex = 27;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cancel.Font = new System.Drawing.Font("Montserrat", 8F);
            this.cancel.ForeColor = System.Drawing.Color.Black;
            this.cancel.Location = new System.Drawing.Point(213, 356);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(187, 46);
            this.cancel.TabIndex = 26;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label5.Location = new System.Drawing.Point(530, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "BYN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Location = new System.Drawing.Point(18, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Сумма";
            // 
            // textSum
            // 
            this.textSum.Location = new System.Drawing.Point(20, 313);
            this.textSum.Name = "textSum";
            this.textSum.Size = new System.Drawing.Size(504, 22);
            this.textSum.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Location = new System.Drawing.Point(20, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Коментарий";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Категории";
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(20, 145);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(545, 84);
            this.textDescription.TabIndex = 15;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonDelete.Font = new System.Drawing.Font("Montserrat", 8F);
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(534, 85);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(31, 29);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "-";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonSave.Font = new System.Drawing.Font("Montserrat", 8F);
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(19, 355);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(187, 46);
            this.buttonSave.TabIndex = 35;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Create.Font = new System.Drawing.Font("Montserrat", 8F);
            this.Create.ForeColor = System.Drawing.Color.Black;
            this.Create.Location = new System.Drawing.Point(20, 355);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(187, 46);
            this.Create.TabIndex = 14;
            this.Create.Text = "Добавить запись";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // expenseTableAdapter
            // 
            this.expenseTableAdapter.ClearBeforeFill = true;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.BackColor = System.Drawing.Color.Transparent;
            this.balance.Font = new System.Drawing.Font("Montserrat", 8F);
            this.balance.ForeColor = System.Drawing.Color.White;
            this.balance.Location = new System.Drawing.Point(411, 46);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(51, 20);
            this.balance.TabIndex = 5;
            this.balance.Text = "label6";
            // 
            // buttonDeleteRecord
            // 
            this.buttonDeleteRecord.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonDeleteRecord.Font = new System.Drawing.Font("Montserrat", 8F);
            this.buttonDeleteRecord.ForeColor = System.Drawing.Color.Black;
            this.buttonDeleteRecord.Location = new System.Drawing.Point(31, 83);
            this.buttonDeleteRecord.Name = "buttonDeleteRecord";
            this.buttonDeleteRecord.Size = new System.Drawing.Size(97, 29);
            this.buttonDeleteRecord.TabIndex = 6;
            this.buttonDeleteRecord.Text = "Удалить";
            this.buttonDeleteRecord.UseVisualStyleBackColor = false;
            this.buttonDeleteRecord.Click += new System.EventHandler(this.buttonDeleteRecord_Click);
            // 
            // buttonEditRecord
            // 
            this.buttonEditRecord.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonEditRecord.Font = new System.Drawing.Font("Montserrat", 8F);
            this.buttonEditRecord.ForeColor = System.Drawing.Color.Black;
            this.buttonEditRecord.Location = new System.Drawing.Point(134, 83);
            this.buttonEditRecord.Name = "buttonEditRecord";
            this.buttonEditRecord.Size = new System.Drawing.Size(141, 29);
            this.buttonEditRecord.TabIndex = 7;
            this.buttonEditRecord.Text = "Редактировать";
            this.buttonEditRecord.UseVisualStyleBackColor = false;
            this.buttonEditRecord.Click += new System.EventHandler(this.buttonEditRecord_Click);
            // 
            // buttonToday
            // 
            this.buttonToday.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonToday.Font = new System.Drawing.Font("Montserrat", 8F);
            this.buttonToday.ForeColor = System.Drawing.Color.Black;
            this.buttonToday.Location = new System.Drawing.Point(24, 462);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(97, 29);
            this.buttonToday.TabIndex = 8;
            this.buttonToday.Text = "Сегодня";
            this.buttonToday.UseVisualStyleBackColor = false;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // buttonWeek
            // 
            this.buttonWeek.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonWeek.Font = new System.Drawing.Font("Montserrat", 8F);
            this.buttonWeek.ForeColor = System.Drawing.Color.Black;
            this.buttonWeek.Location = new System.Drawing.Point(127, 462);
            this.buttonWeek.Name = "buttonWeek";
            this.buttonWeek.Size = new System.Drawing.Size(97, 29);
            this.buttonWeek.TabIndex = 9;
            this.buttonWeek.Text = "Неделя";
            this.buttonWeek.UseVisualStyleBackColor = false;
            this.buttonWeek.Click += new System.EventHandler(this.buttonWeek_Click);
            // 
            // buttonMonth
            // 
            this.buttonMonth.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonMonth.Font = new System.Drawing.Font("Montserrat", 8F);
            this.buttonMonth.ForeColor = System.Drawing.Color.Black;
            this.buttonMonth.Location = new System.Drawing.Point(230, 462);
            this.buttonMonth.Name = "buttonMonth";
            this.buttonMonth.Size = new System.Drawing.Size(97, 29);
            this.buttonMonth.TabIndex = 10;
            this.buttonMonth.Text = "Месяц";
            this.buttonMonth.UseVisualStyleBackColor = false;
            this.buttonMonth.Click += new System.EventHandler(this.buttonMonth_Click);
            // 
            // buttonYear
            // 
            this.buttonYear.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonYear.Font = new System.Drawing.Font("Montserrat", 8F);
            this.buttonYear.ForeColor = System.Drawing.Color.Black;
            this.buttonYear.Location = new System.Drawing.Point(333, 462);
            this.buttonYear.Name = "buttonYear";
            this.buttonYear.Size = new System.Drawing.Size(97, 29);
            this.buttonYear.TabIndex = 11;
            this.buttonYear.Text = "Год";
            this.buttonYear.UseVisualStyleBackColor = false;
            this.buttonYear.Click += new System.EventHandler(this.buttonYear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonExit.Font = new System.Drawing.Font("Montserrat", 8F);
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(482, 462);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(97, 29);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(591, 549);
            this.ControlBox = false;
            this.Controls.Add(this.balance);
            this.Controls.Add(this.add_rec);
            this.Controls.Add(this.dataGridView_finance);
            this.Controls.Add(this.Add_record);
            this.Controls.Add(this.button_expense);
            this.Controls.Add(this.button_income);
            this.Controls.Add(this.buttonEditRecord);
            this.Controls.Add(this.buttonDeleteRecord);
            this.Controls.Add(this.buttonYear);
            this.Controls.Add(this.buttonMonth);
            this.Controls.Add(this.buttonWeek);
            this.Controls.Add(this.buttonToday);
            this.Controls.Add(this.buttonExit);
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_finance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            this.add_rec.ResumeLayout(false);
            this.add_rec.PerformLayout();
            this.panelAddCategory.ResumeLayout(false);
            this.panelAddCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_income;
        private System.Windows.Forms.Button button_expense;
        private System.Windows.Forms.Button Add_record;
        private System.Windows.Forms.DataGridView dataGridView_finance;
        private System.Windows.Forms.BindingSource financeDataSetBindingSource;
        private financeDataSet financeDataSet;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private financeDataSetTableAdapters.incomeTableAdapter incomeTableAdapter;
        private System.Windows.Forms.Panel add_rec;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private financeDataSetTableAdapters.expenseTableAdapter expenseTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSum;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinance;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonExp;
        private System.Windows.Forms.Button buttonInc;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Panel panelAddCategory;
        private System.Windows.Forms.TextBox textBoxAddCategory;
        private System.Windows.Forms.Button buttonCategoryAdd;
        private System.Windows.Forms.Button buttonCategoryCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Button buttonDeleteRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.Button buttonEditRecord;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.Button buttonWeek;
        private System.Windows.Forms.Button buttonMonth;
        private System.Windows.Forms.Button buttonYear;
        private System.Windows.Forms.Button buttonExit;
    }
}