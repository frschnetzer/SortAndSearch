namespace Forms
{
    partial class SortAndSearch
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
            this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.allowDuplicatesCheckBox = new System.Windows.Forms.CheckBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sortedListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unsortedListBox = new System.Windows.Forms.ListBox();
            this.mergeSortResultLbl = new System.Windows.Forms.Label();
            this.bubbleSortResultLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.jumpSearchResultLbl = new System.Windows.Forms.Label();
            this.binarySearchResultLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchedNumber = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValueNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.Location = new System.Drawing.Point(83, 28);
            this.countNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.countNumericUpDown.TabIndex = 0;
            // 
            // minValueNumericUpDown
            // 
            this.minValueNumericUpDown.Location = new System.Drawing.Point(83, 65);
            this.minValueNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.minValueNumericUpDown.Name = "minValueNumericUpDown";
            this.minValueNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.minValueNumericUpDown.TabIndex = 1;
            // 
            // maxValueNumericUpDown
            // 
            this.maxValueNumericUpDown.Location = new System.Drawing.Point(83, 99);
            this.maxValueNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxValueNumericUpDown.Name = "maxValueNumericUpDown";
            this.maxValueNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.maxValueNumericUpDown.TabIndex = 2;
            // 
            // allowDuplicatesCheckBox
            // 
            this.allowDuplicatesCheckBox.AutoSize = true;
            this.allowDuplicatesCheckBox.Location = new System.Drawing.Point(92, 138);
            this.allowDuplicatesCheckBox.Name = "allowDuplicatesCheckBox";
            this.allowDuplicatesCheckBox.Size = new System.Drawing.Size(141, 24);
            this.allowDuplicatesCheckBox.TabIndex = 3;
            this.allowDuplicatesCheckBox.Text = "allow Duplicates";
            this.allowDuplicatesCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(139, 168);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(94, 29);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Min:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max:";
            // 
            // sortedListBox
            // 
            this.sortedListBox.FormattingEnabled = true;
            this.sortedListBox.ItemHeight = 20;
            this.sortedListBox.Location = new System.Drawing.Point(430, 101);
            this.sortedListBox.Name = "sortedListBox";
            this.sortedListBox.Size = new System.Drawing.Size(154, 144);
            this.sortedListBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unsortedListBox);
            this.groupBox1.Controls.Add(this.mergeSortResultLbl);
            this.groupBox1.Controls.Add(this.bubbleSortResultLbl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSort);
            this.groupBox1.Controls.Add(this.sortedListBox);
            this.groupBox1.Controls.Add(this.countNumericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.minValueNumericUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maxValueNumericUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.allowDuplicatesCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 253);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            // 
            // unsortedListBox
            // 
            this.unsortedListBox.FormattingEnabled = true;
            this.unsortedListBox.ItemHeight = 20;
            this.unsortedListBox.Location = new System.Drawing.Point(250, 101);
            this.unsortedListBox.Name = "unsortedListBox";
            this.unsortedListBox.Size = new System.Drawing.Size(154, 144);
            this.unsortedListBox.TabIndex = 13;
            // 
            // mergeSortResultLbl
            // 
            this.mergeSortResultLbl.AutoSize = true;
            this.mergeSortResultLbl.Location = new System.Drawing.Point(342, 67);
            this.mergeSortResultLbl.Name = "mergeSortResultLbl";
            this.mergeSortResultLbl.Size = new System.Drawing.Size(13, 20);
            this.mergeSortResultLbl.TabIndex = 12;
            this.mergeSortResultLbl.Text = " ";
            // 
            // bubbleSortResultLbl
            // 
            this.bubbleSortResultLbl.AutoSize = true;
            this.bubbleSortResultLbl.Location = new System.Drawing.Point(346, 30);
            this.bubbleSortResultLbl.Name = "bubbleSortResultLbl";
            this.bubbleSortResultLbl.Size = new System.Drawing.Size(13, 20);
            this.bubbleSortResultLbl.TabIndex = 11;
            this.bubbleSortResultLbl.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Merge Sort:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bubble Sort:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(271, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 41);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sort And Search";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.jumpSearchResultLbl);
            this.groupBox2.Controls.Add(this.binarySearchResultLbl);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.SearchedNumber);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.searchNumericUpDown);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 148);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // jumpSearchResultLbl
            // 
            this.jumpSearchResultLbl.AutoSize = true;
            this.jumpSearchResultLbl.Location = new System.Drawing.Point(361, 71);
            this.jumpSearchResultLbl.Name = "jumpSearchResultLbl";
            this.jumpSearchResultLbl.Size = new System.Drawing.Size(13, 20);
            this.jumpSearchResultLbl.TabIndex = 14;
            this.jumpSearchResultLbl.Text = " ";
            // 
            // binarySearchResultLbl
            // 
            this.binarySearchResultLbl.AutoSize = true;
            this.binarySearchResultLbl.Location = new System.Drawing.Point(361, 36);
            this.binarySearchResultLbl.Name = "binarySearchResultLbl";
            this.binarySearchResultLbl.Size = new System.Drawing.Size(13, 20);
            this.binarySearchResultLbl.TabIndex = 6;
            this.binarySearchResultLbl.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Jump Search:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Binary Search:";
            // 
            // SearchedNumber
            // 
            this.SearchedNumber.AutoSize = true;
            this.SearchedNumber.Location = new System.Drawing.Point(254, 109);
            this.SearchedNumber.Name = "SearchedNumber";
            this.SearchedNumber.Size = new System.Drawing.Size(13, 20);
            this.SearchedNumber.TabIndex = 3;
            this.SearchedNumber.Text = " ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(139, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchNumericUpDown
            // 
            this.searchNumericUpDown.Location = new System.Drawing.Point(149, 34);
            this.searchNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.searchNumericUpDown.Name = "searchNumericUpDown";
            this.searchNumericUpDown.Size = new System.Drawing.Size(84, 27);
            this.searchNumericUpDown.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Searched Number:";
            // 
            // SortAndSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "SortAndSearch";
            this.Text = "SortAndSearch";
            this.Load += new System.EventHandler(this.SortAndSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValueNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown countNumericUpDown;
        private NumericUpDown minValueNumericUpDown;
        private NumericUpDown maxValueNumericUpDown;
        private CheckBox allowDuplicatesCheckBox;
        private Button btnSort;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox sortedListBox;
        private GroupBox groupBox1;
        private Label mergeSortResultLbl;
        private Label bubbleSortResultLbl;
        private Label label6;
        private Label label5;
        private Label label4;
        private ListBox unsortedListBox;
        private GroupBox groupBox2;
        private NumericUpDown searchNumericUpDown;
        private Label label7;
        private Label SearchedNumber;
        private Button btnSearch;
        private Label jumpSearchResultLbl;
        private Label binarySearchResultLbl;
        private Label label9;
        private Label label8;
    }
}