using Data;
using Logic;
using System.Diagnostics;

namespace Forms
{
    public partial class SortAndSearch : Form
    {
        private readonly Stopwatch stopwatch;
        private readonly SortService sortService;
        private readonly SearchService searchService;
        public SortAndSearch()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            sortService = new SortService();
            searchService = new SearchService();
        }
        private void SortAndSearch_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            bubbleSortResultLbl.Visible = false;
            mergeSortResultLbl.Visible = false;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            ClearAll();
            try
            {
                var options = new NumberGeneratorOptions((int)countNumericUpDown.Value,
               (int)minValueNumericUpDown.Value,
               (int)maxValueNumericUpDown.Value,
               allowDuplicatesCheckBox.Checked);

                if (!options.AllowDuplicates && options.ValueRange <= options.Count)
                {
                    throw new Exception("The value range is greater than the number of values to generate and duplicates are not allowed. Please change the entries.");

                }

                List<int> randomNumbers = NumberGenerator.GenerateNumbers(options);
                unsortedListBox.DataSource = randomNumbers;

                stopwatch.Start();
                List<int> sortedNumbers = sortService.SortNumbers("bubbleSort", randomNumbers);
                stopwatch.Stop();
                bubbleSortResultLbl.Visible = true;
                bubbleSortResultLbl.Text = $"{stopwatch.Elapsed.TotalMilliseconds / 1000.0} Seconds";
                stopwatch.Reset();

                stopwatch.Start();
                _ = sortService.SortNumbers("mergeSort", randomNumbers);
                stopwatch.Stop();
                mergeSortResultLbl.Visible = true;
                mergeSortResultLbl.Text = $"{stopwatch.Elapsed.TotalMilliseconds / 1000.0} Seconds";

                sortedListBox.DataSource = sortedNumbers;
                groupBox2.Visible = true;
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
            }
        }

        private void ClearAll()
        {
            unsortedListBox.DataSource = null;
            sortedListBox.DataSource = null;
            bubbleSortResultLbl.Text = String.Empty;
            mergeSortResultLbl.Text = String.Empty;

            searchNumericUpDown.Value = 0;
            binarySearchResultLbl.Text = String.Empty;
            jumpSearchResultLbl.Text = String.Empty;
            SearchedNumber.Text = String.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<int> items = sortedListBox.Items.Cast<int>().ToList();
            int position, value;

            stopwatch.Reset();
            stopwatch.Start();
            (position, value) = searchService.SearchNumbes("binary", items, (int)searchNumericUpDown.Value);
            stopwatch.Stop();
            binarySearchResultLbl.Text = $"{stopwatch.Elapsed.TotalMilliseconds / 1000.0} Seconds";

            stopwatch.Reset();
            stopwatch.Start();
            (_, _) = searchService.SearchNumbes("jump", items, (int)searchNumericUpDown.Value);
            stopwatch.Stop();
            jumpSearchResultLbl.Text = $"{stopwatch.Elapsed.TotalMilliseconds / 1000.0} Seconds";



            if (position == -1)
            {
                MessageBox.Show("Value not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
                return;
            }
            SearchedNumber.Text = $"Position: {position}, Number:{value}";
        }
    }
}
