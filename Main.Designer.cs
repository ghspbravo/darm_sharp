namespace DARM_sharp
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.leftSideBar = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Panel();
            this.searchFormContainer = new System.Windows.Forms.Panel();
            this.searchResultsContainer = new System.Windows.Forms.Panel();
            this.searchForm = new System.Windows.Forms.GroupBox();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResults = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filtersForm = new System.Windows.Forms.GroupBox();
            this.partTitleAndYearFilter = new System.Windows.Forms.RadioButton();
            this.partTitleFilter = new System.Windows.Forms.RadioButton();
            this.allWordsInTitleFilter = new System.Windows.Forms.RadioButton();
            this.OneWordInTitleFilter = new System.Windows.Forms.RadioButton();
            this.header.SuspendLayout();
            this.leftSideBar.SuspendLayout();
            this.content.SuspendLayout();
            this.searchFormContainer.SuspendLayout();
            this.searchResultsContainer.SuspendLayout();
            this.searchForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResults)).BeginInit();
            this.filtersForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.header.Controls.Add(this.label1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1184, 100);
            this.header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(150, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search engine name";
            // 
            // leftSideBar
            // 
            this.leftSideBar.Controls.Add(this.filtersForm);
            this.leftSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSideBar.Location = new System.Drawing.Point(0, 100);
            this.leftSideBar.Name = "leftSideBar";
            this.leftSideBar.Size = new System.Drawing.Size(150, 661);
            this.leftSideBar.TabIndex = 1;
            // 
            // content
            // 
            this.content.Controls.Add(this.searchResultsContainer);
            this.content.Controls.Add(this.searchFormContainer);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(150, 100);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1034, 661);
            this.content.TabIndex = 2;
            // 
            // footer
            // 
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(150, 711);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1034, 50);
            this.footer.TabIndex = 3;
            // 
            // searchFormContainer
            // 
            this.searchFormContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchFormContainer.Controls.Add(this.searchForm);
            this.searchFormContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchFormContainer.Location = new System.Drawing.Point(0, 0);
            this.searchFormContainer.Name = "searchFormContainer";
            this.searchFormContainer.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.searchFormContainer.Size = new System.Drawing.Size(1034, 100);
            this.searchFormContainer.TabIndex = 0;
            // 
            // searchResultsContainer
            // 
            this.searchResultsContainer.Controls.Add(this.searchResults);
            this.searchResultsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultsContainer.Location = new System.Drawing.Point(0, 100);
            this.searchResultsContainer.Name = "searchResultsContainer";
            this.searchResultsContainer.Padding = new System.Windows.Forms.Padding(50, 30, 50, 80);
            this.searchResultsContainer.Size = new System.Drawing.Size(1034, 561);
            this.searchResultsContainer.TabIndex = 1;
            // 
            // searchForm
            // 
            this.searchForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchForm.Controls.Add(this.searchButton);
            this.searchForm.Controls.Add(this.searchInput);
            this.searchForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchForm.Location = new System.Drawing.Point(20, 10);
            this.searchForm.Name = "searchForm";
            this.searchForm.Padding = new System.Windows.Forms.Padding(10);
            this.searchForm.Size = new System.Drawing.Size(994, 80);
            this.searchForm.TabIndex = 0;
            this.searchForm.TabStop = false;
            this.searchForm.Text = "Query";
            // 
            // searchInput
            // 
            this.searchInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchInput.Location = new System.Drawing.Point(10, 33);
            this.searchInput.MaximumSize = new System.Drawing.Size(850, 0);
            this.searchInput.MinimumSize = new System.Drawing.Size(400, 0);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(850, 30);
            this.searchInput.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchButton.Location = new System.Drawing.Point(866, 33);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(118, 37);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchResults
            // 
            this.searchResults.AllowUserToAddRows = false;
            this.searchResults.AllowUserToDeleteRows = false;
            this.searchResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.searchResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.searchResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.searchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Title,
            this.Year});
            this.searchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResults.Location = new System.Drawing.Point(50, 30);
            this.searchResults.Name = "searchResults";
            this.searchResults.ReadOnly = true;
            this.searchResults.RowTemplate.Height = 30;
            this.searchResults.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.searchResults.Size = new System.Drawing.Size(934, 451);
            this.searchResults.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 100;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 250;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 700;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 100;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // filtersForm
            // 
            this.filtersForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filtersForm.Controls.Add(this.OneWordInTitleFilter);
            this.filtersForm.Controls.Add(this.allWordsInTitleFilter);
            this.filtersForm.Controls.Add(this.partTitleFilter);
            this.filtersForm.Controls.Add(this.partTitleAndYearFilter);
            this.filtersForm.Location = new System.Drawing.Point(12, 24);
            this.filtersForm.Name = "filtersForm";
            this.filtersForm.Padding = new System.Windows.Forms.Padding(10);
            this.filtersForm.Size = new System.Drawing.Size(124, 557);
            this.filtersForm.TabIndex = 0;
            this.filtersForm.TabStop = false;
            this.filtersForm.Text = "Filters";
            // 
            // partTitleAndYearFilter
            // 
            this.partTitleAndYearFilter.AutoEllipsis = true;
            this.partTitleAndYearFilter.Checked = true;
            this.partTitleAndYearFilter.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partTitleAndYearFilter.Location = new System.Drawing.Point(13, 36);
            this.partTitleAndYearFilter.Name = "partTitleAndYearFilter";
            this.partTitleAndYearFilter.Size = new System.Drawing.Size(98, 52);
            this.partTitleAndYearFilter.TabIndex = 0;
            this.partTitleAndYearFilter.Text = "part title and year";
            this.partTitleAndYearFilter.UseVisualStyleBackColor = true;
            // 
            // partTitleFilter
            // 
            this.partTitleFilter.AutoEllipsis = true;
            this.partTitleFilter.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partTitleFilter.Location = new System.Drawing.Point(13, 94);
            this.partTitleFilter.Name = "partTitleFilter";
            this.partTitleFilter.Size = new System.Drawing.Size(98, 52);
            this.partTitleFilter.TabIndex = 1;
            this.partTitleFilter.Text = "part title";
            this.partTitleFilter.UseVisualStyleBackColor = true;
            // 
            // allWordsInTitleFilter
            // 
            this.allWordsInTitleFilter.AutoEllipsis = true;
            this.allWordsInTitleFilter.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allWordsInTitleFilter.Location = new System.Drawing.Point(13, 152);
            this.allWordsInTitleFilter.Name = "allWordsInTitleFilter";
            this.allWordsInTitleFilter.Size = new System.Drawing.Size(98, 52);
            this.allWordsInTitleFilter.TabIndex = 2;
            this.allWordsInTitleFilter.Text = "all words in title";
            this.allWordsInTitleFilter.UseVisualStyleBackColor = true;
            // 
            // OneWordInTitleFilter
            // 
            this.OneWordInTitleFilter.AutoEllipsis = true;
            this.OneWordInTitleFilter.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneWordInTitleFilter.Location = new System.Drawing.Point(13, 210);
            this.OneWordInTitleFilter.Name = "OneWordInTitleFilter";
            this.OneWordInTitleFilter.Size = new System.Drawing.Size(98, 52);
            this.OneWordInTitleFilter.TabIndex = 3;
            this.OneWordInTitleFilter.Text = "one word in title";
            this.OneWordInTitleFilter.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.content);
            this.Controls.Add(this.leftSideBar);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Main";
            this.Text = "Search Engine Name";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.leftSideBar.ResumeLayout(false);
            this.content.ResumeLayout(false);
            this.searchFormContainer.ResumeLayout(false);
            this.searchResultsContainer.ResumeLayout(false);
            this.searchForm.ResumeLayout(false);
            this.searchForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResults)).EndInit();
            this.filtersForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel leftSideBar;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel searchResultsContainer;
        private System.Windows.Forms.Panel searchFormContainer;
        private System.Windows.Forms.GroupBox searchForm;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.DataGridView searchResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.GroupBox filtersForm;
        private System.Windows.Forms.RadioButton OneWordInTitleFilter;
        private System.Windows.Forms.RadioButton allWordsInTitleFilter;
        private System.Windows.Forms.RadioButton partTitleFilter;
        private System.Windows.Forms.RadioButton partTitleAndYearFilter;
    }
}

