namespace FinancialHelper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            tabControl = new TabControl();
            profilePage = new TabPage();
            importPage = new TabPage();
            addToProfileButton = new Button();
            importCSVProgressBar = new ProgressBar();
            bankDataDataGridView = new DataGridView();
            operationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valueDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            currencyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saldoAfterTransactionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDescriptionAdditional1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDescriptionAdditional2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDescriptionAdditional3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDescriptionAdditional4DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDescriptionAdditional5DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDescriptionAdditional6DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDescriptionAdditional7DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bankDataBindingSource = new BindingSource(components);
            importButton = new Button();
            dataPage = new TabPage();
            searchTextBox = new TextBox();
            searchButton = new Button();
            profileDataGridView = new DataGridView();
            CategorySelect = new DataGridViewComboBoxColumn();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            operationDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            valueDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            transactionTypeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            currencyDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            saldoAfterTransactionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            transactionDescriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            transactionDescriptionAdditional1DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            transactionDescriptionAdditional2DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            transactionDescriptionAdditional3DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            transactionDescriptionAdditional4DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            transactionDescriptionAdditional5DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            transactionDescriptionAdditional6DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            transactionDescriptionAdditional7DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            profileBankDataBindingSource = new BindingSource(components);
            statisticsPage = new TabPage();
            categoriesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            rangeDataGroupBox = new GroupBox();
            submitDateRangeButton = new Button();
            toDateTimePicker = new DateTimePicker();
            fromDateTimePicker = new DateTimePicker();
            categoriesPage = new TabPage();
            categoriesDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryBindingSource = new BindingSource(components);
            modifyCategyGroupBox = new GroupBox();
            modifyCategoryNameTextBox = new TextBox();
            modifyCategoryCommentaryRichTextBox = new RichTextBox();
            deleteCategoryButton = new Button();
            modifyCategoryButton = new Button();
            modifyCategoryIdTextBox = new TextBox();
            addNewCategoryGroupBox = new GroupBox();
            newCategoryCommentaryRichTextBox = new RichTextBox();
            submitCategoryButton = new Button();
            newCategoryNameTextBox = new TextBox();
            tabControl.SuspendLayout();
            importPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bankDataDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bankDataBindingSource).BeginInit();
            dataPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profileBankDataBindingSource).BeginInit();
            statisticsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoriesChart).BeginInit();
            rangeDataGroupBox.SuspendLayout();
            categoriesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoriesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            modifyCategyGroupBox.SuspendLayout();
            addNewCategoryGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(profilePage);
            tabControl.Controls.Add(importPage);
            tabControl.Controls.Add(dataPage);
            tabControl.Controls.Add(statisticsPage);
            tabControl.Controls.Add(categoriesPage);
            tabControl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1200, 809);
            tabControl.TabIndex = 0;
            // 
            // profilePage
            // 
            profilePage.Location = new Point(4, 34);
            profilePage.Name = "profilePage";
            profilePage.Size = new Size(1192, 771);
            profilePage.TabIndex = 5;
            profilePage.Text = "Your profile";
            profilePage.UseVisualStyleBackColor = true;
            // 
            // importPage
            // 
            importPage.Controls.Add(addToProfileButton);
            importPage.Controls.Add(importCSVProgressBar);
            importPage.Controls.Add(bankDataDataGridView);
            importPage.Controls.Add(importButton);
            importPage.Location = new Point(4, 34);
            importPage.Name = "importPage";
            importPage.Padding = new Padding(3);
            importPage.Size = new Size(1192, 771);
            importPage.TabIndex = 2;
            importPage.Text = "Import Data";
            importPage.UseVisualStyleBackColor = true;
            // 
            // addToProfileButton
            // 
            addToProfileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addToProfileButton.Enabled = false;
            addToProfileButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addToProfileButton.Location = new Point(958, 6);
            addToProfileButton.Name = "addToProfileButton";
            addToProfileButton.Size = new Size(228, 65);
            addToProfileButton.TabIndex = 3;
            addToProfileButton.Text = "Add to Your Profile";
            addToProfileButton.UseVisualStyleBackColor = true;
            addToProfileButton.Click += addToProfileButton_Click;
            // 
            // importCSVProgressBar
            // 
            importCSVProgressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            importCSVProgressBar.Location = new Point(277, 6);
            importCSVProgressBar.Name = "importCSVProgressBar";
            importCSVProgressBar.Size = new Size(675, 65);
            importCSVProgressBar.Step = 20;
            importCSVProgressBar.TabIndex = 2;
            // 
            // bankDataDataGridView
            // 
            bankDataDataGridView.AllowUserToAddRows = false;
            bankDataDataGridView.AllowUserToDeleteRows = false;
            bankDataDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bankDataDataGridView.AutoGenerateColumns = false;
            bankDataDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bankDataDataGridView.Columns.AddRange(new DataGridViewColumn[] { operationDateDataGridViewTextBoxColumn, valueDateDataGridViewTextBoxColumn, transactionTypeDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, currencyDataGridViewTextBoxColumn, saldoAfterTransactionDataGridViewTextBoxColumn, transactionDescriptionDataGridViewTextBoxColumn, transactionDescriptionAdditional1DataGridViewTextBoxColumn, transactionDescriptionAdditional2DataGridViewTextBoxColumn, transactionDescriptionAdditional3DataGridViewTextBoxColumn, transactionDescriptionAdditional4DataGridViewTextBoxColumn, transactionDescriptionAdditional5DataGridViewTextBoxColumn, transactionDescriptionAdditional6DataGridViewTextBoxColumn, transactionDescriptionAdditional7DataGridViewTextBoxColumn });
            bankDataDataGridView.DataSource = bankDataBindingSource;
            bankDataDataGridView.Location = new Point(6, 77);
            bankDataDataGridView.MultiSelect = false;
            bankDataDataGridView.Name = "bankDataDataGridView";
            bankDataDataGridView.ReadOnly = true;
            bankDataDataGridView.RowTemplate.Height = 25;
            bankDataDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bankDataDataGridView.Size = new Size(1180, 688);
            bankDataDataGridView.TabIndex = 1;
            // 
            // operationDateDataGridViewTextBoxColumn
            // 
            operationDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            operationDateDataGridViewTextBoxColumn.DataPropertyName = "OperationDate";
            operationDateDataGridViewTextBoxColumn.HeaderText = "OperationDate";
            operationDateDataGridViewTextBoxColumn.Name = "operationDateDataGridViewTextBoxColumn";
            operationDateDataGridViewTextBoxColumn.ReadOnly = true;
            operationDateDataGridViewTextBoxColumn.Width = 161;
            // 
            // valueDateDataGridViewTextBoxColumn
            // 
            valueDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            valueDateDataGridViewTextBoxColumn.DataPropertyName = "ValueDate";
            valueDateDataGridViewTextBoxColumn.HeaderText = "ValueDate";
            valueDateDataGridViewTextBoxColumn.Name = "valueDateDataGridViewTextBoxColumn";
            valueDateDataGridViewTextBoxColumn.ReadOnly = true;
            valueDateDataGridViewTextBoxColumn.Width = 123;
            // 
            // transactionTypeDataGridViewTextBoxColumn
            // 
            transactionTypeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
            transactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType";
            transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
            transactionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            transactionTypeDataGridViewTextBoxColumn.Width = 172;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            amountDataGridViewTextBoxColumn.Width = 104;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            currencyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            currencyDataGridViewTextBoxColumn.ReadOnly = true;
            currencyDataGridViewTextBoxColumn.Width = 113;
            // 
            // saldoAfterTransactionDataGridViewTextBoxColumn
            // 
            saldoAfterTransactionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            saldoAfterTransactionDataGridViewTextBoxColumn.DataPropertyName = "SaldoAfterTransaction";
            saldoAfterTransactionDataGridViewTextBoxColumn.HeaderText = "SaldoAfterTransaction";
            saldoAfterTransactionDataGridViewTextBoxColumn.Name = "saldoAfterTransactionDataGridViewTextBoxColumn";
            saldoAfterTransactionDataGridViewTextBoxColumn.ReadOnly = true;
            saldoAfterTransactionDataGridViewTextBoxColumn.Width = 221;
            // 
            // transactionDescriptionDataGridViewTextBoxColumn
            // 
            transactionDescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TransactionDescription";
            transactionDescriptionDataGridViewTextBoxColumn.HeaderText = "TransactionDescription";
            transactionDescriptionDataGridViewTextBoxColumn.Name = "transactionDescriptionDataGridViewTextBoxColumn";
            transactionDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            transactionDescriptionDataGridViewTextBoxColumn.Width = 229;
            // 
            // transactionDescriptionAdditional1DataGridViewTextBoxColumn
            // 
            transactionDescriptionAdditional1DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional1DataGridViewTextBoxColumn.DataPropertyName = "TransactionDescriptionAdditional1";
            transactionDescriptionAdditional1DataGridViewTextBoxColumn.HeaderText = "TransactionDescriptionAdditional1";
            transactionDescriptionAdditional1DataGridViewTextBoxColumn.Name = "transactionDescriptionAdditional1DataGridViewTextBoxColumn";
            transactionDescriptionAdditional1DataGridViewTextBoxColumn.ReadOnly = true;
            transactionDescriptionAdditional1DataGridViewTextBoxColumn.Width = 326;
            // 
            // transactionDescriptionAdditional2DataGridViewTextBoxColumn
            // 
            transactionDescriptionAdditional2DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional2DataGridViewTextBoxColumn.DataPropertyName = "TransactionDescriptionAdditional2";
            transactionDescriptionAdditional2DataGridViewTextBoxColumn.HeaderText = "TransactionDescriptionAdditional2";
            transactionDescriptionAdditional2DataGridViewTextBoxColumn.Name = "transactionDescriptionAdditional2DataGridViewTextBoxColumn";
            transactionDescriptionAdditional2DataGridViewTextBoxColumn.ReadOnly = true;
            transactionDescriptionAdditional2DataGridViewTextBoxColumn.Width = 326;
            // 
            // transactionDescriptionAdditional3DataGridViewTextBoxColumn
            // 
            transactionDescriptionAdditional3DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional3DataGridViewTextBoxColumn.DataPropertyName = "TransactionDescriptionAdditional3";
            transactionDescriptionAdditional3DataGridViewTextBoxColumn.HeaderText = "TransactionDescriptionAdditional3";
            transactionDescriptionAdditional3DataGridViewTextBoxColumn.Name = "transactionDescriptionAdditional3DataGridViewTextBoxColumn";
            transactionDescriptionAdditional3DataGridViewTextBoxColumn.ReadOnly = true;
            transactionDescriptionAdditional3DataGridViewTextBoxColumn.Width = 326;
            // 
            // transactionDescriptionAdditional4DataGridViewTextBoxColumn
            // 
            transactionDescriptionAdditional4DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional4DataGridViewTextBoxColumn.DataPropertyName = "TransactionDescriptionAdditional4";
            transactionDescriptionAdditional4DataGridViewTextBoxColumn.HeaderText = "TransactionDescriptionAdditional4";
            transactionDescriptionAdditional4DataGridViewTextBoxColumn.Name = "transactionDescriptionAdditional4DataGridViewTextBoxColumn";
            transactionDescriptionAdditional4DataGridViewTextBoxColumn.ReadOnly = true;
            transactionDescriptionAdditional4DataGridViewTextBoxColumn.Width = 326;
            // 
            // transactionDescriptionAdditional5DataGridViewTextBoxColumn
            // 
            transactionDescriptionAdditional5DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional5DataGridViewTextBoxColumn.DataPropertyName = "TransactionDescriptionAdditional5";
            transactionDescriptionAdditional5DataGridViewTextBoxColumn.HeaderText = "TransactionDescriptionAdditional5";
            transactionDescriptionAdditional5DataGridViewTextBoxColumn.Name = "transactionDescriptionAdditional5DataGridViewTextBoxColumn";
            transactionDescriptionAdditional5DataGridViewTextBoxColumn.ReadOnly = true;
            transactionDescriptionAdditional5DataGridViewTextBoxColumn.Width = 326;
            // 
            // transactionDescriptionAdditional6DataGridViewTextBoxColumn
            // 
            transactionDescriptionAdditional6DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional6DataGridViewTextBoxColumn.DataPropertyName = "TransactionDescriptionAdditional6";
            transactionDescriptionAdditional6DataGridViewTextBoxColumn.HeaderText = "TransactionDescriptionAdditional6";
            transactionDescriptionAdditional6DataGridViewTextBoxColumn.Name = "transactionDescriptionAdditional6DataGridViewTextBoxColumn";
            transactionDescriptionAdditional6DataGridViewTextBoxColumn.ReadOnly = true;
            transactionDescriptionAdditional6DataGridViewTextBoxColumn.Width = 326;
            // 
            // transactionDescriptionAdditional7DataGridViewTextBoxColumn
            // 
            transactionDescriptionAdditional7DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional7DataGridViewTextBoxColumn.DataPropertyName = "TransactionDescriptionAdditional7";
            transactionDescriptionAdditional7DataGridViewTextBoxColumn.HeaderText = "TransactionDescriptionAdditional7";
            transactionDescriptionAdditional7DataGridViewTextBoxColumn.Name = "transactionDescriptionAdditional7DataGridViewTextBoxColumn";
            transactionDescriptionAdditional7DataGridViewTextBoxColumn.ReadOnly = true;
            transactionDescriptionAdditional7DataGridViewTextBoxColumn.Width = 326;
            // 
            // bankDataBindingSource
            // 
            bankDataBindingSource.DataSource = typeof(Shared.BankData);
            // 
            // importButton
            // 
            importButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            importButton.Location = new Point(6, 6);
            importButton.Name = "importButton";
            importButton.Size = new Size(265, 65);
            importButton.TabIndex = 0;
            importButton.Text = "Import Data From CSV";
            importButton.UseVisualStyleBackColor = true;
            importButton.Click += importButton_Click;
            // 
            // dataPage
            // 
            dataPage.Controls.Add(searchTextBox);
            dataPage.Controls.Add(searchButton);
            dataPage.Controls.Add(profileDataGridView);
            dataPage.Location = new Point(4, 34);
            dataPage.Name = "dataPage";
            dataPage.Size = new Size(1192, 771);
            dataPage.TabIndex = 3;
            dataPage.Text = "Your finances";
            dataPage.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(3, 3);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(907, 39);
            searchTextBox.TabIndex = 4;
            searchTextBox.Text = "Search Text";
            searchTextBox.TextAlign = HorizontalAlignment.Center;
            searchTextBox.WordWrap = false;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(916, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(273, 40);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // profileDataGridView
            // 
            profileDataGridView.AllowUserToAddRows = false;
            profileDataGridView.AllowUserToDeleteRows = false;
            profileDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            profileDataGridView.AutoGenerateColumns = false;
            profileDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            profileDataGridView.Columns.AddRange(new DataGridViewColumn[] { CategorySelect, idDataGridViewTextBoxColumn1, Category, operationDateDataGridViewTextBoxColumn1, valueDateDataGridViewTextBoxColumn1, transactionTypeDataGridViewTextBoxColumn1, amountDataGridViewTextBoxColumn1, currencyDataGridViewTextBoxColumn1, saldoAfterTransactionDataGridViewTextBoxColumn1, transactionDescriptionDataGridViewTextBoxColumn1, transactionDescriptionAdditional1DataGridViewTextBoxColumn1, transactionDescriptionAdditional2DataGridViewTextBoxColumn1, transactionDescriptionAdditional3DataGridViewTextBoxColumn1, transactionDescriptionAdditional4DataGridViewTextBoxColumn1, transactionDescriptionAdditional5DataGridViewTextBoxColumn1, transactionDescriptionAdditional6DataGridViewTextBoxColumn1, transactionDescriptionAdditional7DataGridViewTextBoxColumn1 });
            profileDataGridView.DataSource = profileBankDataBindingSource;
            profileDataGridView.Location = new Point(3, 49);
            profileDataGridView.MultiSelect = false;
            profileDataGridView.Name = "profileDataGridView";
            profileDataGridView.RowTemplate.Height = 25;
            profileDataGridView.Size = new Size(1186, 719);
            profileDataGridView.TabIndex = 0;
            profileDataGridView.CellValueChanged += profileDataGridView_CellValueChanged;
            // 
            // CategorySelect
            // 
            CategorySelect.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CategorySelect.HeaderText = "Select Category";
            CategorySelect.Name = "CategorySelect";
            CategorySelect.Width = 149;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // operationDateDataGridViewTextBoxColumn1
            // 
            operationDateDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            operationDateDataGridViewTextBoxColumn1.DataPropertyName = "OperationDate";
            operationDateDataGridViewTextBoxColumn1.HeaderText = "OperationDate";
            operationDateDataGridViewTextBoxColumn1.Name = "operationDateDataGridViewTextBoxColumn1";
            operationDateDataGridViewTextBoxColumn1.ReadOnly = true;
            operationDateDataGridViewTextBoxColumn1.Width = 161;
            // 
            // valueDateDataGridViewTextBoxColumn1
            // 
            valueDateDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            valueDateDataGridViewTextBoxColumn1.DataPropertyName = "ValueDate";
            valueDateDataGridViewTextBoxColumn1.HeaderText = "ValueDate";
            valueDateDataGridViewTextBoxColumn1.Name = "valueDateDataGridViewTextBoxColumn1";
            valueDateDataGridViewTextBoxColumn1.ReadOnly = true;
            valueDateDataGridViewTextBoxColumn1.Width = 123;
            // 
            // transactionTypeDataGridViewTextBoxColumn1
            // 
            transactionTypeDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionTypeDataGridViewTextBoxColumn1.DataPropertyName = "TransactionType";
            transactionTypeDataGridViewTextBoxColumn1.HeaderText = "TransactionType";
            transactionTypeDataGridViewTextBoxColumn1.Name = "transactionTypeDataGridViewTextBoxColumn1";
            transactionTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            transactionTypeDataGridViewTextBoxColumn1.Width = 172;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            amountDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            amountDataGridViewTextBoxColumn1.ReadOnly = true;
            amountDataGridViewTextBoxColumn1.Width = 104;
            // 
            // currencyDataGridViewTextBoxColumn1
            // 
            currencyDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            currencyDataGridViewTextBoxColumn1.DataPropertyName = "Currency";
            currencyDataGridViewTextBoxColumn1.HeaderText = "Currency";
            currencyDataGridViewTextBoxColumn1.Name = "currencyDataGridViewTextBoxColumn1";
            currencyDataGridViewTextBoxColumn1.ReadOnly = true;
            currencyDataGridViewTextBoxColumn1.Width = 113;
            // 
            // saldoAfterTransactionDataGridViewTextBoxColumn1
            // 
            saldoAfterTransactionDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            saldoAfterTransactionDataGridViewTextBoxColumn1.DataPropertyName = "SaldoAfterTransaction";
            saldoAfterTransactionDataGridViewTextBoxColumn1.HeaderText = "SaldoAfterTransaction";
            saldoAfterTransactionDataGridViewTextBoxColumn1.Name = "saldoAfterTransactionDataGridViewTextBoxColumn1";
            saldoAfterTransactionDataGridViewTextBoxColumn1.ReadOnly = true;
            saldoAfterTransactionDataGridViewTextBoxColumn1.Width = 221;
            // 
            // transactionDescriptionDataGridViewTextBoxColumn1
            // 
            transactionDescriptionDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "TransactionDescription";
            transactionDescriptionDataGridViewTextBoxColumn1.HeaderText = "TransactionDescription";
            transactionDescriptionDataGridViewTextBoxColumn1.Name = "transactionDescriptionDataGridViewTextBoxColumn1";
            transactionDescriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            transactionDescriptionDataGridViewTextBoxColumn1.Width = 229;
            // 
            // transactionDescriptionAdditional1DataGridViewTextBoxColumn1
            // 
            transactionDescriptionAdditional1DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional1DataGridViewTextBoxColumn1.DataPropertyName = "TransactionDescriptionAdditional1";
            transactionDescriptionAdditional1DataGridViewTextBoxColumn1.HeaderText = "TransactionDescriptionAdditional1";
            transactionDescriptionAdditional1DataGridViewTextBoxColumn1.Name = "transactionDescriptionAdditional1DataGridViewTextBoxColumn1";
            transactionDescriptionAdditional1DataGridViewTextBoxColumn1.ReadOnly = true;
            transactionDescriptionAdditional1DataGridViewTextBoxColumn1.Width = 326;
            // 
            // transactionDescriptionAdditional2DataGridViewTextBoxColumn1
            // 
            transactionDescriptionAdditional2DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional2DataGridViewTextBoxColumn1.DataPropertyName = "TransactionDescriptionAdditional2";
            transactionDescriptionAdditional2DataGridViewTextBoxColumn1.HeaderText = "TransactionDescriptionAdditional2";
            transactionDescriptionAdditional2DataGridViewTextBoxColumn1.Name = "transactionDescriptionAdditional2DataGridViewTextBoxColumn1";
            transactionDescriptionAdditional2DataGridViewTextBoxColumn1.ReadOnly = true;
            transactionDescriptionAdditional2DataGridViewTextBoxColumn1.Width = 326;
            // 
            // transactionDescriptionAdditional3DataGridViewTextBoxColumn1
            // 
            transactionDescriptionAdditional3DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional3DataGridViewTextBoxColumn1.DataPropertyName = "TransactionDescriptionAdditional3";
            transactionDescriptionAdditional3DataGridViewTextBoxColumn1.HeaderText = "TransactionDescriptionAdditional3";
            transactionDescriptionAdditional3DataGridViewTextBoxColumn1.Name = "transactionDescriptionAdditional3DataGridViewTextBoxColumn1";
            transactionDescriptionAdditional3DataGridViewTextBoxColumn1.ReadOnly = true;
            transactionDescriptionAdditional3DataGridViewTextBoxColumn1.Width = 326;
            // 
            // transactionDescriptionAdditional4DataGridViewTextBoxColumn1
            // 
            transactionDescriptionAdditional4DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional4DataGridViewTextBoxColumn1.DataPropertyName = "TransactionDescriptionAdditional4";
            transactionDescriptionAdditional4DataGridViewTextBoxColumn1.HeaderText = "TransactionDescriptionAdditional4";
            transactionDescriptionAdditional4DataGridViewTextBoxColumn1.Name = "transactionDescriptionAdditional4DataGridViewTextBoxColumn1";
            transactionDescriptionAdditional4DataGridViewTextBoxColumn1.ReadOnly = true;
            transactionDescriptionAdditional4DataGridViewTextBoxColumn1.Width = 326;
            // 
            // transactionDescriptionAdditional5DataGridViewTextBoxColumn1
            // 
            transactionDescriptionAdditional5DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional5DataGridViewTextBoxColumn1.DataPropertyName = "TransactionDescriptionAdditional5";
            transactionDescriptionAdditional5DataGridViewTextBoxColumn1.HeaderText = "TransactionDescriptionAdditional5";
            transactionDescriptionAdditional5DataGridViewTextBoxColumn1.Name = "transactionDescriptionAdditional5DataGridViewTextBoxColumn1";
            transactionDescriptionAdditional5DataGridViewTextBoxColumn1.ReadOnly = true;
            transactionDescriptionAdditional5DataGridViewTextBoxColumn1.Width = 326;
            // 
            // transactionDescriptionAdditional6DataGridViewTextBoxColumn1
            // 
            transactionDescriptionAdditional6DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional6DataGridViewTextBoxColumn1.DataPropertyName = "TransactionDescriptionAdditional6";
            transactionDescriptionAdditional6DataGridViewTextBoxColumn1.HeaderText = "TransactionDescriptionAdditional6";
            transactionDescriptionAdditional6DataGridViewTextBoxColumn1.Name = "transactionDescriptionAdditional6DataGridViewTextBoxColumn1";
            transactionDescriptionAdditional6DataGridViewTextBoxColumn1.ReadOnly = true;
            transactionDescriptionAdditional6DataGridViewTextBoxColumn1.Width = 326;
            // 
            // transactionDescriptionAdditional7DataGridViewTextBoxColumn1
            // 
            transactionDescriptionAdditional7DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional7DataGridViewTextBoxColumn1.DataPropertyName = "TransactionDescriptionAdditional7";
            transactionDescriptionAdditional7DataGridViewTextBoxColumn1.HeaderText = "TransactionDescriptionAdditional7";
            transactionDescriptionAdditional7DataGridViewTextBoxColumn1.Name = "transactionDescriptionAdditional7DataGridViewTextBoxColumn1";
            transactionDescriptionAdditional7DataGridViewTextBoxColumn1.ReadOnly = true;
            transactionDescriptionAdditional7DataGridViewTextBoxColumn1.Width = 326;
            // 
            // profileBankDataBindingSource
            // 
            profileBankDataBindingSource.DataSource = typeof(Entities.BankData);
            // 
            // statisticsPage
            // 
            statisticsPage.Controls.Add(categoriesChart);
            statisticsPage.Controls.Add(rangeDataGroupBox);
            statisticsPage.Location = new Point(4, 34);
            statisticsPage.Name = "statisticsPage";
            statisticsPage.Size = new Size(1192, 771);
            statisticsPage.TabIndex = 4;
            statisticsPage.Text = "Your Statistics";
            statisticsPage.UseVisualStyleBackColor = true;
            // 
            // categoriesChart
            // 
            categoriesChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            categoriesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            categoriesChart.Legends.Add(legend1);
            categoriesChart.Location = new Point(9, 178);
            categoriesChart.Name = "categoriesChart";
            categoriesChart.Size = new Size(1171, 590);
            categoriesChart.TabIndex = 1;
            categoriesChart.Text = "Categories Chart";
            // 
            // rangeDataGroupBox
            // 
            rangeDataGroupBox.Controls.Add(submitDateRangeButton);
            rangeDataGroupBox.Controls.Add(toDateTimePicker);
            rangeDataGroupBox.Controls.Add(fromDateTimePicker);
            rangeDataGroupBox.Location = new Point(3, 3);
            rangeDataGroupBox.Name = "rangeDataGroupBox";
            rangeDataGroupBox.Size = new Size(448, 169);
            rangeDataGroupBox.TabIndex = 0;
            rangeDataGroupBox.TabStop = false;
            rangeDataGroupBox.Text = "Date Range";
            // 
            // submitDateRangeButton
            // 
            submitDateRangeButton.Location = new Point(6, 91);
            submitDateRangeButton.Name = "submitDateRangeButton";
            submitDateRangeButton.Size = new Size(436, 59);
            submitDateRangeButton.TabIndex = 2;
            submitDateRangeButton.Text = "Submit";
            submitDateRangeButton.UseVisualStyleBackColor = true;
            submitDateRangeButton.Click += submitDateRangeButton_Click;
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.Location = new Point(236, 32);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new Size(200, 33);
            toDateTimePicker.TabIndex = 1;
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.Location = new Point(6, 32);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(200, 33);
            fromDateTimePicker.TabIndex = 0;
            // 
            // categoriesPage
            // 
            categoriesPage.Controls.Add(categoriesDataGridView);
            categoriesPage.Controls.Add(modifyCategyGroupBox);
            categoriesPage.Controls.Add(addNewCategoryGroupBox);
            categoriesPage.Location = new Point(4, 34);
            categoriesPage.Name = "categoriesPage";
            categoriesPage.Size = new Size(1192, 771);
            categoriesPage.TabIndex = 6;
            categoriesPage.Text = "Your categories";
            categoriesPage.UseVisualStyleBackColor = true;
            // 
            // categoriesDataGridView
            // 
            categoriesDataGridView.AllowUserToAddRows = false;
            categoriesDataGridView.AllowUserToDeleteRows = false;
            categoriesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoriesDataGridView.AutoGenerateColumns = false;
            categoriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoriesDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, commentaryDataGridViewTextBoxColumn });
            categoriesDataGridView.DataSource = categoryBindingSource;
            categoriesDataGridView.Location = new Point(292, 13);
            categoriesDataGridView.MultiSelect = false;
            categoriesDataGridView.Name = "categoriesDataGridView";
            categoriesDataGridView.ReadOnly = true;
            categoriesDataGridView.RowTemplate.Height = 25;
            categoriesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categoriesDataGridView.Size = new Size(897, 755);
            categoriesDataGridView.TabIndex = 3;
            categoriesDataGridView.RowStateChanged += categoriesDataGridView_RowStateChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 53;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 87;
            // 
            // commentaryDataGridViewTextBoxColumn
            // 
            commentaryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            commentaryDataGridViewTextBoxColumn.DataPropertyName = "Commentary";
            commentaryDataGridViewTextBoxColumn.HeaderText = "Commentary";
            commentaryDataGridViewTextBoxColumn.Name = "commentaryDataGridViewTextBoxColumn";
            commentaryDataGridViewTextBoxColumn.ReadOnly = true;
            commentaryDataGridViewTextBoxColumn.Width = 145;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Entities.Category);
            // 
            // modifyCategyGroupBox
            // 
            modifyCategyGroupBox.Controls.Add(modifyCategoryNameTextBox);
            modifyCategyGroupBox.Controls.Add(modifyCategoryCommentaryRichTextBox);
            modifyCategyGroupBox.Controls.Add(deleteCategoryButton);
            modifyCategyGroupBox.Controls.Add(modifyCategoryButton);
            modifyCategyGroupBox.Controls.Add(modifyCategoryIdTextBox);
            modifyCategyGroupBox.Location = new Point(9, 305);
            modifyCategyGroupBox.Name = "modifyCategyGroupBox";
            modifyCategyGroupBox.Size = new Size(277, 379);
            modifyCategyGroupBox.TabIndex = 2;
            modifyCategyGroupBox.TabStop = false;
            modifyCategyGroupBox.Text = "Modify Category";
            modifyCategyGroupBox.Visible = false;
            // 
            // modifyCategoryNameTextBox
            // 
            modifyCategoryNameTextBox.Location = new Point(6, 92);
            modifyCategoryNameTextBox.Name = "modifyCategoryNameTextBox";
            modifyCategoryNameTextBox.Size = new Size(265, 33);
            modifyCategoryNameTextBox.TabIndex = 5;
            // 
            // modifyCategoryCommentaryRichTextBox
            // 
            modifyCategoryCommentaryRichTextBox.Location = new Point(6, 145);
            modifyCategoryCommentaryRichTextBox.Name = "modifyCategoryCommentaryRichTextBox";
            modifyCategoryCommentaryRichTextBox.Size = new Size(265, 99);
            modifyCategoryCommentaryRichTextBox.TabIndex = 4;
            modifyCategoryCommentaryRichTextBox.Text = "";
            // 
            // deleteCategoryButton
            // 
            deleteCategoryButton.Location = new Point(6, 312);
            deleteCategoryButton.Name = "deleteCategoryButton";
            deleteCategoryButton.Size = new Size(265, 56);
            deleteCategoryButton.TabIndex = 3;
            deleteCategoryButton.Text = "Delete";
            deleteCategoryButton.UseVisualStyleBackColor = true;
            deleteCategoryButton.Click += deleteCategoryButton_Click;
            // 
            // modifyCategoryButton
            // 
            modifyCategoryButton.Location = new Point(6, 250);
            modifyCategoryButton.Name = "modifyCategoryButton";
            modifyCategoryButton.Size = new Size(265, 56);
            modifyCategoryButton.TabIndex = 1;
            modifyCategoryButton.Text = "Modify";
            modifyCategoryButton.UseVisualStyleBackColor = true;
            modifyCategoryButton.Click += modifyCategoryButton_Click;
            // 
            // modifyCategoryIdTextBox
            // 
            modifyCategoryIdTextBox.Location = new Point(6, 42);
            modifyCategoryIdTextBox.Name = "modifyCategoryIdTextBox";
            modifyCategoryIdTextBox.ReadOnly = true;
            modifyCategoryIdTextBox.Size = new Size(265, 33);
            modifyCategoryIdTextBox.TabIndex = 0;
            // 
            // addNewCategoryGroupBox
            // 
            addNewCategoryGroupBox.Controls.Add(newCategoryCommentaryRichTextBox);
            addNewCategoryGroupBox.Controls.Add(submitCategoryButton);
            addNewCategoryGroupBox.Controls.Add(newCategoryNameTextBox);
            addNewCategoryGroupBox.Location = new Point(9, 13);
            addNewCategoryGroupBox.Name = "addNewCategoryGroupBox";
            addNewCategoryGroupBox.Size = new Size(277, 286);
            addNewCategoryGroupBox.TabIndex = 0;
            addNewCategoryGroupBox.TabStop = false;
            addNewCategoryGroupBox.Text = "Add New Category";
            // 
            // newCategoryCommentaryRichTextBox
            // 
            newCategoryCommentaryRichTextBox.Location = new Point(6, 89);
            newCategoryCommentaryRichTextBox.Name = "newCategoryCommentaryRichTextBox";
            newCategoryCommentaryRichTextBox.Size = new Size(265, 129);
            newCategoryCommentaryRichTextBox.TabIndex = 2;
            newCategoryCommentaryRichTextBox.Text = "";
            newCategoryCommentaryRichTextBox.TextChanged += newCategoryCommentaryRichTextBox_TextChanged;
            // 
            // submitCategoryButton
            // 
            submitCategoryButton.Enabled = false;
            submitCategoryButton.Location = new Point(6, 224);
            submitCategoryButton.Name = "submitCategoryButton";
            submitCategoryButton.Size = new Size(265, 56);
            submitCategoryButton.TabIndex = 1;
            submitCategoryButton.Text = "Submit";
            submitCategoryButton.UseVisualStyleBackColor = true;
            submitCategoryButton.Click += submitCategoryButton_Click;
            // 
            // newCategoryNameTextBox
            // 
            newCategoryNameTextBox.Location = new Point(6, 50);
            newCategoryNameTextBox.Name = "newCategoryNameTextBox";
            newCategoryNameTextBox.Size = new Size(265, 33);
            newCategoryNameTextBox.TabIndex = 0;
            newCategoryNameTextBox.TextChanged += newCategoryNameTextBox_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 833);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "FinancialHelper";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            importPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bankDataDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bankDataBindingSource).EndInit();
            dataPage.ResumeLayout(false);
            dataPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profileDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)profileBankDataBindingSource).EndInit();
            statisticsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)categoriesChart).EndInit();
            rangeDataGroupBox.ResumeLayout(false);
            categoriesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)categoriesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            modifyCategyGroupBox.ResumeLayout(false);
            modifyCategyGroupBox.PerformLayout();
            addNewCategoryGroupBox.ResumeLayout(false);
            addNewCategoryGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl;
        private TabPage importPage;
        private DataGridView bankDataDataGridView;
        private Button importButton;
        private ProgressBar importCSVProgressBar;
        private BindingSource bankDataBindingSource;
        private Button addToProfileButton;
        private DataGridViewTextBoxColumn operationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valueDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saldoAfterTransactionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDescriptionAdditional1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDescriptionAdditional2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDescriptionAdditional3DataGridViewTextBoxColumn;
        private TabPage profilePage;
        private TabPage dataPage;
        private TabPage statisticsPage;
        private DataGridViewTextBoxColumn transactionDescriptionAdditional4DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDescriptionAdditional5DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDescriptionAdditional6DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDescriptionAdditional7DataGridViewTextBoxColumn;
        private DataGridView profileDataGridView;
        private BindingSource profileBankDataBindingSource;
        private Button searchButton;
        private TextBox newCategoryNameTextBox;
        private TextBox searchTextBox;
        private TabPage categoriesPage;
        private GroupBox addNewCategoryGroupBox;
        private GroupBox modifyCategyGroupBox;
        private Button deleteCategoryButton;
        private Button modifyCategoryButton;
        private TextBox modifyCategoryIdTextBox;
        private Button submitCategoryButton;
        private RichTextBox modifyCategoryCommentaryRichTextBox;
        private RichTextBox newCategoryCommentaryRichTextBox;
        private DataGridView categoriesDataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentaryDataGridViewTextBoxColumn;
        private BindingSource categoryBindingSource;
        private TextBox modifyCategoryNameTextBox;
        private DataGridViewComboBoxColumn CategorySelect;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn operationDateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn valueDateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn saldoAfterTransactionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn transactionDescriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn transactionDescriptionAdditional1DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn transactionDescriptionAdditional2DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn transactionDescriptionAdditional3DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn transactionDescriptionAdditional4DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn transactionDescriptionAdditional5DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn transactionDescriptionAdditional6DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn transactionDescriptionAdditional7DataGridViewTextBoxColumn1;
        private GroupBox rangeDataGroupBox;
        private Button submitDateRangeButton;
        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DataVisualization.Charting.Chart categoriesChart;
    }
}