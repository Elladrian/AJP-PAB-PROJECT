using FinancialHelper.Entities;
using FinancialHelper.Migrations;
using FinancialHelper.Shared;
using FinancialHelper.Shared.Contracts;
using FinancialHelper.Shared.Services;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinancialHelper
{
    public partial class MainForm : Form
    {
        List<Entities.BankData> BankDatas;
        List<Entities.Category> Categories;
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

            refreshYourCategoryDate();
            refreshYourProfileData();
        }

        private void refreshYourCategoryDate()
        {
            try
            {
                using (CategoryService categoryService = new())
                {
                    this.Categories = categoryService.GetCategories(loggedUserId);
                    this.categoriesDataGridView.DataSource = new BindingList<Entities.Category>(this.Categories);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured upon downloading your categories data. More details:\n{ex.Message}", "Error");
            }

            this.categoriesDataGridView.Refresh();
        }

        private void refreshYourProfileData()
        {
            try
            {
                using (BankDataService bankDataService = new())
                {
                    ((DataGridViewComboBoxColumn)this.profileDataGridView.Columns[0]).Items.Clear();

                    foreach (Category category in this.Categories)
                    {
                        ((DataGridViewComboBoxColumn)this.profileDataGridView.Columns[0]).Items.Add(category.Name);
                    }

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

        private void submitCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (CategoryService categoryService = new())
                {
                    categoryService.CreateNewCategory(
                        newCategoryNameTextBox.Text,
                        newCategoryCommentaryRichTextBox.Text,
                        loggedUserId);
                }

                MessageBox.Show($"New category has benn successfully added", "Information");
                refreshYourCategoryDate();
                refreshYourProfileData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured upon adding new category. More details:\n{ex.Message}", "Error");
            }
            finally
            {
                newCategoryCommentaryRichTextBox.Text = "";
                newCategoryNameTextBox.Text = "";
            }
        }

        private void newCategoryNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (newCategoryCommentaryRichTextBox.Text != "" && newCategoryNameTextBox.Text != "") submitCategoryButton.Enabled = true;
        }

        private void newCategoryCommentaryRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (newCategoryCommentaryRichTextBox.Text != "" && newCategoryNameTextBox.Text != "") submitCategoryButton.Enabled = true;
        }

        private void categoriesDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (categoriesDataGridView.SelectedRows.Count > 0)
            {
                modifyCategyGroupBox.Visible = true;

                modifyCategoryIdTextBox.Text = e.Row.Cells[0].Value.ToString();
                modifyCategoryNameTextBox.Text = e.Row.Cells[1].Value.ToString();
                modifyCategoryCommentaryRichTextBox.Text = e.Row.Cells[2].Value.ToString();
            }
        }

        private void modifyCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (CategoryService categoryService = new())
                {
                    categoryService.ModifyCategory(
                        Int32.Parse(modifyCategoryIdTextBox.Text),
                        modifyCategoryNameTextBox.Text,
                        modifyCategoryCommentaryRichTextBox.Text,
                        loggedUserId);

                    refreshYourCategoryDate();
                    refreshYourProfileData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured upon editing your category. More details:\n{ex.Message}", "Error");
            }
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (CategoryService categoryService = new())
                {
                    categoryService.DeleteCategory(
                        Int32.Parse(modifyCategoryIdTextBox.Text),
                        loggedUserId);

                    refreshYourCategoryDate();
                    refreshYourProfileData();

                    modifyCategyGroupBox.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured upon deliting your category. More details:\n{ex.Message}", "Error");
            }
        }

        private void profileDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.profileDataGridView.Rows.Count > 0)
            {
                try
                {
                    string newCategory = this.profileDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    var category = this.Categories.Where(c => c.Name == newCategory).FirstOrDefault();
                    var dataId = Int32.Parse(this.profileDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                    var data = this.BankDatas.Where(bd => bd.Id == dataId).FirstOrDefault();
                    if (category.Id != data.CategoryId)
                    {
                        using (BankDataService bankDataService = new())
                        {
                            bankDataService.ModifyCategory(dataId, category.Id);

                            this.BankDatas = bankDataService.GetUserData(loggedUserId);
                            this.profileDataGridView.DataSource = new BindingList<Entities.BankData>(this.BankDatas);
                            this.profileDataGridView.Refresh();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occured upon modificating data category. More details:\n{ex.Message}", "Error");
                }
            }
        }

        private void submitDateRangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fromDateTimePicker.Value < toDateTimePicker.Value)
                {
                    using (CategoryService categoryService = new CategoryService())
                    {
                        var result = categoryService.GetCategoryChartDatas(
                            fromDateTimePicker.Value,
                            toDateTimePicker.Value,
                            loggedUserId);


                        foreach(var series in categoriesChart.Series)
                        {
                            series.Points.Clear();
                        }
                        categoriesChart.Series.Clear();
                        categoriesChart.Titles.Clear();

                        categoriesChart.Titles.Add("Category Chart");
                        foreach (var data in result)
                        {
                            if(data.AmountMinus != 0)
                            {
                                categoriesChart.Series.Add(new Series(data.Name == null ? "uncategorized" + " (minus)" : data.Name + " (minus)"));
                                categoriesChart.Series[data.Name == null ? "uncategorized" + " (minus)" : data.Name + " (minus)"].IsValueShownAsLabel = true;
                                categoriesChart.Series[data.Name == null ? "uncategorized" + " (minus)" : data.Name + " (minus)"].Points.AddXY(data.Name == null ? " " : data.Name, data.AmountMinus);
                            }

                            if(data.AmountPlus != 0)
                            {
                                categoriesChart.Series.Add(new Series(data.Name == null ? "uncategorized" + " (plus)" : data.Name + " (plus)"));
                                categoriesChart.Series[data.Name == null ? "uncategorized" + " (plus)" : data.Name + " (plus)"].IsValueShownAsLabel = true;
                                categoriesChart.Series[data.Name == null ? "uncategorized" + " (plus)" : data.Name + " (plus)"].Points.AddXY(data.Name == null ? " " : data.Name, data.AmountPlus);
                            }
                        }

                        categoriesChart.ChartAreas["ChartArea1"].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep45;
                        categoriesChart.ChartAreas["ChartArea1"].AxisY.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep45;
                    }
                }
                else
                {
                    MessageBox.Show($"Please select correct date range!", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured upon generating chart. More details:\n{ex.Message}", "Error");
            }

        }
    }
}