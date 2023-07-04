namespace FinancialHelper
{
    partial class Form1
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
            tabControl = new TabControl();
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
            bankDataBindingSource = new BindingSource(components);
            importButton = new Button();
            tabControl.SuspendLayout();
            importPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bankDataDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bankDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(importPage);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1200, 660);
            tabControl.TabIndex = 0;
            // 
            // importPage
            // 
            importPage.Controls.Add(addToProfileButton);
            importPage.Controls.Add(importCSVProgressBar);
            importPage.Controls.Add(bankDataDataGridView);
            importPage.Controls.Add(importButton);
            importPage.Location = new Point(4, 24);
            importPage.Name = "importPage";
            importPage.Padding = new Padding(3);
            importPage.Size = new Size(1192, 632);
            importPage.TabIndex = 2;
            importPage.Text = "Import Data";
            importPage.UseVisualStyleBackColor = true;
            // 
            // addToProfileButton
            // 
            addToProfileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addToProfileButton.Enabled = false;
            addToProfileButton.Location = new Point(1053, 6);
            addToProfileButton.Name = "addToProfileButton";
            addToProfileButton.Size = new Size(133, 65);
            addToProfileButton.TabIndex = 3;
            addToProfileButton.Text = "Add to Your Profile";
            addToProfileButton.UseVisualStyleBackColor = true;
            // 
            // importCSVProgressBar
            // 
            importCSVProgressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            importCSVProgressBar.Location = new Point(145, 6);
            importCSVProgressBar.Name = "importCSVProgressBar";
            importCSVProgressBar.Size = new Size(902, 65);
            importCSVProgressBar.Step = 20;
            importCSVProgressBar.TabIndex = 2;
            // 
            // bankDataDataGridView
            // 
            bankDataDataGridView.AllowUserToAddRows = false;
            bankDataDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bankDataDataGridView.AutoGenerateColumns = false;
            bankDataDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bankDataDataGridView.Columns.AddRange(new DataGridViewColumn[] { operationDateDataGridViewTextBoxColumn, valueDateDataGridViewTextBoxColumn, transactionTypeDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, currencyDataGridViewTextBoxColumn, saldoAfterTransactionDataGridViewTextBoxColumn, transactionDescriptionDataGridViewTextBoxColumn, transactionDescriptionAdditional1DataGridViewTextBoxColumn, transactionDescriptionAdditional2DataGridViewTextBoxColumn, transactionDescriptionAdditional3DataGridViewTextBoxColumn });
            bankDataDataGridView.DataSource = bankDataBindingSource;
            bankDataDataGridView.Location = new Point(6, 77);
            bankDataDataGridView.Name = "bankDataDataGridView";
            bankDataDataGridView.RowTemplate.Height = 25;
            bankDataDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bankDataDataGridView.Size = new Size(1180, 549);
            bankDataDataGridView.TabIndex = 1;
            // 
            // operationDateDataGridViewTextBoxColumn
            // 
            operationDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            operationDateDataGridViewTextBoxColumn.DataPropertyName = "OperationDate";
            operationDateDataGridViewTextBoxColumn.HeaderText = "OperationDate";
            operationDateDataGridViewTextBoxColumn.Name = "operationDateDataGridViewTextBoxColumn";
            operationDateDataGridViewTextBoxColumn.ReadOnly = true;
            operationDateDataGridViewTextBoxColumn.Width = 109;
            // 
            // valueDateDataGridViewTextBoxColumn
            // 
            valueDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            valueDateDataGridViewTextBoxColumn.DataPropertyName = "ValueDate";
            valueDateDataGridViewTextBoxColumn.HeaderText = "ValueDate";
            valueDateDataGridViewTextBoxColumn.Name = "valueDateDataGridViewTextBoxColumn";
            valueDateDataGridViewTextBoxColumn.ReadOnly = true;
            valueDateDataGridViewTextBoxColumn.Width = 84;
            // 
            // transactionTypeDataGridViewTextBoxColumn
            // 
            transactionTypeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
            transactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType";
            transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
            transactionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            transactionTypeDataGridViewTextBoxColumn.Width = 116;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            amountDataGridViewTextBoxColumn.Width = 76;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            currencyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            currencyDataGridViewTextBoxColumn.ReadOnly = true;
            currencyDataGridViewTextBoxColumn.Width = 80;
            // 
            // saldoAfterTransactionDataGridViewTextBoxColumn
            // 
            saldoAfterTransactionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            saldoAfterTransactionDataGridViewTextBoxColumn.DataPropertyName = "SaldoAfterTransaction";
            saldoAfterTransactionDataGridViewTextBoxColumn.HeaderText = "SaldoAfterTransaction";
            saldoAfterTransactionDataGridViewTextBoxColumn.Name = "saldoAfterTransactionDataGridViewTextBoxColumn";
            saldoAfterTransactionDataGridViewTextBoxColumn.ReadOnly = true;
            saldoAfterTransactionDataGridViewTextBoxColumn.Width = 147;
            // 
            // transactionDescriptionDataGridViewTextBoxColumn
            // 
            transactionDescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TransactionDescription";
            transactionDescriptionDataGridViewTextBoxColumn.HeaderText = "TransactionDescription";
            transactionDescriptionDataGridViewTextBoxColumn.Name = "transactionDescriptionDataGridViewTextBoxColumn";
            transactionDescriptionDataGridViewTextBoxColumn.Width = 152;
            // 
            // transactionDescriptionAdditional1DataGridViewTextBoxColumn
            // 
            transactionDescriptionAdditional1DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional1DataGridViewTextBoxColumn.DataPropertyName = "TransactionDescriptionAdditional1";
            transactionDescriptionAdditional1DataGridViewTextBoxColumn.HeaderText = "TransactionDescriptionAdditional1";
            transactionDescriptionAdditional1DataGridViewTextBoxColumn.Name = "transactionDescriptionAdditional1DataGridViewTextBoxColumn";
            transactionDescriptionAdditional1DataGridViewTextBoxColumn.Width = 213;
            // 
            // transactionDescriptionAdditional2DataGridViewTextBoxColumn
            // 
            transactionDescriptionAdditional2DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional2DataGridViewTextBoxColumn.DataPropertyName = "TransactionDescriptionAdditional2";
            transactionDescriptionAdditional2DataGridViewTextBoxColumn.HeaderText = "TransactionDescriptionAdditional2";
            transactionDescriptionAdditional2DataGridViewTextBoxColumn.Name = "transactionDescriptionAdditional2DataGridViewTextBoxColumn";
            transactionDescriptionAdditional2DataGridViewTextBoxColumn.Width = 213;
            // 
            // transactionDescriptionAdditional3DataGridViewTextBoxColumn
            // 
            transactionDescriptionAdditional3DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDescriptionAdditional3DataGridViewTextBoxColumn.DataPropertyName = "TransactionDescriptionAdditional3";
            transactionDescriptionAdditional3DataGridViewTextBoxColumn.HeaderText = "TransactionDescriptionAdditional3";
            transactionDescriptionAdditional3DataGridViewTextBoxColumn.Name = "transactionDescriptionAdditional3DataGridViewTextBoxColumn";
            transactionDescriptionAdditional3DataGridViewTextBoxColumn.Width = 213;
            // 
            // bankDataBindingSource
            // 
            bankDataBindingSource.DataSource = typeof(Shared.BankData);
            // 
            // importButton
            // 
            importButton.Location = new Point(6, 6);
            importButton.Name = "importButton";
            importButton.Size = new Size(133, 65);
            importButton.TabIndex = 0;
            importButton.Text = "Import Data From CSV";
            importButton.UseVisualStyleBackColor = true;
            importButton.Click += importButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 684);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "FinancialHelper";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            importPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bankDataDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bankDataBindingSource).EndInit();
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
    }
}