using FinancialHelper.Entities;
using FinancialHelper.Shared;
using FinancialHelper.Shared.Contracts;
using FinancialHelper.Shared.Services;
using System.ComponentModel;

namespace FinancialHelper
{
    public partial class MainForm : Form
    {
        List<Entities.BankData> BankDatas;
        List<Shared.BankData> ImportedBankDatas;
        int loggedUserId = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region GUI Configuration
            addToProfileButton.Enabled = false;
            tabControl.ItemSize = new Size(100, 50);
            #endregion

            refreshYourProfileData();
        }

        private void refreshYourProfileData()
        {
            try
            {
                using (BankDataService bankDataService = new())
                {
                    this.BankDatas = bankDataService.GetUserData(loggedUserId);
                    this.profileDataGridView.DataSource = new BindingList<Entities.BankData>(this.BankDatas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured upon downloading your profile data. More details:\n{ex.Message}", "Error");
            }

            this.profileDataGridView.Refresh();
        }

        private void clearImportDataGridView()
        {
            this.bankDataDataGridView.Rows.Clear();
            this.bankDataDataGridView.Refresh();
        }

        private void clearProfileDataGridView()
        {
            this.profileDataGridView.Rows.Clear();
            this.profileDataGridView.Refresh();
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

                    MessageBox.Show($"Imported rows: {importedData.Count}", "Information");

                    importCSVProgressBar.PerformStep();
                    importCSVProgressBar.Update();

                    this.bankDataDataGridView.DataSource = new BindingList<Shared.BankData>(importedData);
                    this.ImportedBankDatas = importedData;

                    if (importedData.Count > 0)
                    {
                        addToProfileButton.Enabled = true;
                    }

                    importCSVProgressBar.Value = 100;
                    importCSVProgressBar.Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occured upon data importation. More details:\n{ex.Message}", "Error");
                }
                finally
                {
                    importCSVProgressBar.Value = 0;
                    importCSVProgressBar.Update();
                }
            }
        }

        private void addToProfileButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (BankDataService bankDataService = new())
                {
                    this.BankDatas = bankDataService.AddDataToDB(this.ImportedBankDatas, loggedUserId, null);

                    MessageBox.Show($"Added Rows to Your Profile: {this.BankDatas.Count}\nDuplicates: {this.ImportedBankDatas.Count - this.BankDatas.Count}", "Information");

                    refreshYourProfileData();
                    clearImportDataGridView();

                    addToProfileButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured upon adding data to your profile. More details:\n{ex.Message}", "Error");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (BankDataService bankDataService = new())
                {
                    var result = this.BankDatas = bankDataService.GetSearchedData(searchTextBox.Text, loggedUserId);
                    if (result != null)
                    {
                        this.profileDataGridView.DataSource = new BindingList<Entities.BankData>(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured upon adding data to your profile. More details:\n{ex.Message}", "Error");
            }
        }
    }
}