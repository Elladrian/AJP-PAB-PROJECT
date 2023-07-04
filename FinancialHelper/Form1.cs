using FinancialHelper.Entities;
using FinancialHelper.Shared;
using FinancialHelper.Shared.Contracts;
using FinancialHelper.Shared.Services;

namespace FinancialHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addToProfileButton.Enabled = false;
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                InitialDirectory = @"C:\",
                Title = "Import Data from CSV",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "CSV UTF-8 (Comma delimited)(*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Shared.BankData> importedData = new();

                    using (CSVService csvService = new())
                    {
                        importCSVProgressBar.PerformStep();
                        importCSVProgressBar.Update();

                        importedData = csvService.GetDataFromFile(openFileDialog.FileName);
                    }

                    MessageBox.Show($"Imported rows: {importedData.Count}", "Import Information");

                    importCSVProgressBar.PerformStep();
                    importCSVProgressBar.Update();

                    this.bankDataDataGridView.DataSource = importedData;

                    if (importedData.Count > 0)
                    {
                        addToProfileButton.Enabled = true;
                    }

                    importCSVProgressBar.Value = 100;
                    importCSVProgressBar.Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occured upon data importation. More details:\n{ex.Message}", "Import Error");
                }
                finally
                {
                    importCSVProgressBar.Value = 0;
                    importCSVProgressBar.Update();
                }
            }
        }
    }
}