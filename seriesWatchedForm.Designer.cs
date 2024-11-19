
namespace DavCFinalProject
{
    partial class seriesWatchedForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addPanel = new System.Windows.Forms.Panel();
            this.breakPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.ratingGroupBox = new System.Windows.Forms.GroupBox();
            this.tenthRadioButton = new System.Windows.Forms.RadioButton();
            this.oneRadioButton = new System.Windows.Forms.RadioButton();
            this.ninthRadioButton = new System.Windows.Forms.RadioButton();
            this.twoRadioButton = new System.Windows.Forms.RadioButton();
            this.eighthRadioButton = new System.Windows.Forms.RadioButton();
            this.threeRadioButton = new System.Windows.Forms.RadioButton();
            this.seventhRadioButton = new System.Windows.Forms.RadioButton();
            this.fourRadioButton = new System.Windows.Forms.RadioButton();
            this.sixthRadioButton = new System.Windows.Forms.RadioButton();
            this.fifthRadioButton = new System.Windows.Forms.RadioButton();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.seriesWatchedLabel = new System.Windows.Forms.Label();
            this.tablesPanel = new System.Windows.Forms.Panel();
            this.seriesWatchedDataGridView = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coverDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.coverOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.coverImagesImageList = new System.Windows.Forms.ImageList(this.components);
            this.addPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ratingGroupBox.SuspendLayout();
            this.tablesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seriesWatchedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.breakPanel);
            this.addPanel.Controls.Add(this.panel2);
            this.addPanel.Controls.Add(this.seriesWatchedLabel);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.addPanel.Location = new System.Drawing.Point(800, 0);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(480, 800);
            this.addPanel.TabIndex = 0;
            // 
            // breakPanel
            // 
            this.breakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.breakPanel.Location = new System.Drawing.Point(3, 42);
            this.breakPanel.Name = "breakPanel";
            this.breakPanel.Size = new System.Drawing.Size(1, 690);
            this.breakPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.submitButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.uploadButton);
            this.panel2.Controls.Add(this.ratingGroupBox);
            this.panel2.Controls.Add(this.titleTextBox);
            this.panel2.Controls.Add(this.titleLabel);
            this.panel2.Location = new System.Drawing.Point(25, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 600);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DavCFinalProject.Properties.Resources.placeholder;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(54, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 207);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(189, 494);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(245, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "or";
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(296, 297);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(75, 23);
            this.uploadButton.TabIndex = 3;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // ratingGroupBox
            // 
            this.ratingGroupBox.Controls.Add(this.tenthRadioButton);
            this.ratingGroupBox.Controls.Add(this.oneRadioButton);
            this.ratingGroupBox.Controls.Add(this.ninthRadioButton);
            this.ratingGroupBox.Controls.Add(this.twoRadioButton);
            this.ratingGroupBox.Controls.Add(this.eighthRadioButton);
            this.ratingGroupBox.Controls.Add(this.threeRadioButton);
            this.ratingGroupBox.Controls.Add(this.seventhRadioButton);
            this.ratingGroupBox.Controls.Add(this.fourRadioButton);
            this.ratingGroupBox.Controls.Add(this.sixthRadioButton);
            this.ratingGroupBox.Controls.Add(this.fifthRadioButton);
            this.ratingGroupBox.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.ratingGroupBox.Location = new System.Drawing.Point(22, 58);
            this.ratingGroupBox.Name = "ratingGroupBox";
            this.ratingGroupBox.Size = new System.Drawing.Size(391, 100);
            this.ratingGroupBox.TabIndex = 2;
            this.ratingGroupBox.TabStop = false;
            this.ratingGroupBox.Text = "Rating";
            // 
            // tenthRadioButton
            // 
            this.tenthRadioButton.AutoSize = true;
            this.tenthRadioButton.Location = new System.Drawing.Point(339, 52);
            this.tenthRadioButton.Name = "tenthRadioButton";
            this.tenthRadioButton.Size = new System.Drawing.Size(14, 13);
            this.tenthRadioButton.TabIndex = 10;
            this.tenthRadioButton.TabStop = true;
            this.tenthRadioButton.UseVisualStyleBackColor = true;
            // 
            // oneRadioButton
            // 
            this.oneRadioButton.AutoSize = true;
            this.oneRadioButton.Location = new System.Drawing.Point(45, 52);
            this.oneRadioButton.Name = "oneRadioButton";
            this.oneRadioButton.Size = new System.Drawing.Size(14, 13);
            this.oneRadioButton.TabIndex = 1;
            this.oneRadioButton.TabStop = true;
            this.oneRadioButton.UseVisualStyleBackColor = true;
            // 
            // ninthRadioButton
            // 
            this.ninthRadioButton.AutoSize = true;
            this.ninthRadioButton.Location = new System.Drawing.Point(307, 52);
            this.ninthRadioButton.Name = "ninthRadioButton";
            this.ninthRadioButton.Size = new System.Drawing.Size(14, 13);
            this.ninthRadioButton.TabIndex = 9;
            this.ninthRadioButton.TabStop = true;
            this.ninthRadioButton.UseVisualStyleBackColor = true;
            // 
            // twoRadioButton
            // 
            this.twoRadioButton.AutoSize = true;
            this.twoRadioButton.Location = new System.Drawing.Point(77, 52);
            this.twoRadioButton.Name = "twoRadioButton";
            this.twoRadioButton.Size = new System.Drawing.Size(14, 13);
            this.twoRadioButton.TabIndex = 2;
            this.twoRadioButton.TabStop = true;
            this.twoRadioButton.UseVisualStyleBackColor = true;
            // 
            // eighthRadioButton
            // 
            this.eighthRadioButton.AutoSize = true;
            this.eighthRadioButton.Location = new System.Drawing.Point(274, 52);
            this.eighthRadioButton.Name = "eighthRadioButton";
            this.eighthRadioButton.Size = new System.Drawing.Size(14, 13);
            this.eighthRadioButton.TabIndex = 8;
            this.eighthRadioButton.TabStop = true;
            this.eighthRadioButton.UseVisualStyleBackColor = true;
            // 
            // threeRadioButton
            // 
            this.threeRadioButton.AutoSize = true;
            this.threeRadioButton.Location = new System.Drawing.Point(110, 52);
            this.threeRadioButton.Name = "threeRadioButton";
            this.threeRadioButton.Size = new System.Drawing.Size(14, 13);
            this.threeRadioButton.TabIndex = 3;
            this.threeRadioButton.TabStop = true;
            this.threeRadioButton.UseVisualStyleBackColor = true;
            // 
            // seventhRadioButton
            // 
            this.seventhRadioButton.AutoSize = true;
            this.seventhRadioButton.Location = new System.Drawing.Point(242, 52);
            this.seventhRadioButton.Name = "seventhRadioButton";
            this.seventhRadioButton.Size = new System.Drawing.Size(14, 13);
            this.seventhRadioButton.TabIndex = 7;
            this.seventhRadioButton.TabStop = true;
            this.seventhRadioButton.UseVisualStyleBackColor = true;
            // 
            // fourRadioButton
            // 
            this.fourRadioButton.AutoSize = true;
            this.fourRadioButton.Location = new System.Drawing.Point(142, 52);
            this.fourRadioButton.Name = "fourRadioButton";
            this.fourRadioButton.Size = new System.Drawing.Size(14, 13);
            this.fourRadioButton.TabIndex = 4;
            this.fourRadioButton.TabStop = true;
            this.fourRadioButton.UseVisualStyleBackColor = true;
            // 
            // sixthRadioButton
            // 
            this.sixthRadioButton.AutoSize = true;
            this.sixthRadioButton.Location = new System.Drawing.Point(209, 52);
            this.sixthRadioButton.Name = "sixthRadioButton";
            this.sixthRadioButton.Size = new System.Drawing.Size(14, 13);
            this.sixthRadioButton.TabIndex = 6;
            this.sixthRadioButton.TabStop = true;
            this.sixthRadioButton.UseVisualStyleBackColor = true;
            // 
            // fifthRadioButton
            // 
            this.fifthRadioButton.AutoSize = true;
            this.fifthRadioButton.Location = new System.Drawing.Point(176, 52);
            this.fifthRadioButton.Name = "fifthRadioButton";
            this.fifthRadioButton.Size = new System.Drawing.Size(14, 13);
            this.fifthRadioButton.TabIndex = 5;
            this.fifthRadioButton.TabStop = true;
            this.fifthRadioButton.UseVisualStyleBackColor = true;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTextBox.Location = new System.Drawing.Point(88, 20);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(325, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.titleLabel.Location = new System.Drawing.Point(18, 16);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(73, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title : ";
            // 
            // seriesWatchedLabel
            // 
            this.seriesWatchedLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.seriesWatchedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.seriesWatchedLabel.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriesWatchedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.seriesWatchedLabel.Location = new System.Drawing.Point(25, 50);
            this.seriesWatchedLabel.Name = "seriesWatchedLabel";
            this.seriesWatchedLabel.Size = new System.Drawing.Size(435, 60);
            this.seriesWatchedLabel.TabIndex = 0;
            this.seriesWatchedLabel.Text = "Add Series";
            this.seriesWatchedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablesPanel
            // 
            this.tablesPanel.Controls.Add(this.seriesWatchedDataGridView);
            this.tablesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesPanel.Location = new System.Drawing.Point(0, 0);
            this.tablesPanel.Name = "tablesPanel";
            this.tablesPanel.Size = new System.Drawing.Size(800, 800);
            this.tablesPanel.TabIndex = 1;
            // 
            // seriesWatchedDataGridView
            // 
            this.seriesWatchedDataGridView.AllowUserToAddRows = false;
            this.seriesWatchedDataGridView.AllowUserToDeleteRows = false;
            this.seriesWatchedDataGridView.AllowUserToResizeColumns = false;
            this.seriesWatchedDataGridView.AllowUserToResizeRows = false;
            this.seriesWatchedDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.seriesWatchedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.seriesWatchedDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.seriesWatchedDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.seriesWatchedDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seriesWatchedDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.seriesWatchedDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.seriesWatchedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seriesWatchedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.coverDataGridViewImageColumn});
            this.seriesWatchedDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.seriesWatchedDataGridView.Location = new System.Drawing.Point(43, 50);
            this.seriesWatchedDataGridView.Margin = new System.Windows.Forms.Padding(50);
            this.seriesWatchedDataGridView.MaximumSize = new System.Drawing.Size(720, 750);
            this.seriesWatchedDataGridView.MinimumSize = new System.Drawing.Size(720, 100);
            this.seriesWatchedDataGridView.Name = "seriesWatchedDataGridView";
            this.seriesWatchedDataGridView.ReadOnly = true;
            this.seriesWatchedDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.seriesWatchedDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.seriesWatchedDataGridView.RowHeadersVisible = false;
            this.seriesWatchedDataGridView.RowTemplate.ReadOnly = true;
            this.seriesWatchedDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.seriesWatchedDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seriesWatchedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.seriesWatchedDataGridView.Size = new System.Drawing.Size(720, 750);
            this.seriesWatchedDataGridView.TabIndex = 0;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.titleDataGridViewTextBoxColumn.FillWeight = 50F;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.titleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.titleDataGridViewTextBoxColumn.Width = 360;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ratingDataGridViewTextBoxColumn.FillWeight = 10F;
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.MinimumWidth = 25;
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            this.ratingDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ratingDataGridViewTextBoxColumn.Width = 72;
            // 
            // coverDataGridViewImageColumn
            // 
            this.coverDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.coverDataGridViewImageColumn.FillWeight = 40F;
            this.coverDataGridViewImageColumn.HeaderText = "Cover Image";
            this.coverDataGridViewImageColumn.MinimumWidth = 100;
            this.coverDataGridViewImageColumn.Name = "coverDataGridViewImageColumn";
            this.coverDataGridViewImageColumn.ReadOnly = true;
            this.coverDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coverDataGridViewImageColumn.Width = 288;
            // 
            // coverOpenFileDialog
            // 
            this.coverOpenFileDialog.FileName = "openFileDialog1";
            // 
            // coverImagesImageList
            // 
            this.coverImagesImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.coverImagesImageList.ImageSize = new System.Drawing.Size(150, 200);
            this.coverImagesImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // seriesWatchedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.tablesPanel);
            this.Controls.Add(this.addPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "seriesWatchedForm";
            this.Text = "Series Watched";
            this.addPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ratingGroupBox.ResumeLayout(false);
            this.ratingGroupBox.PerformLayout();
            this.tablesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seriesWatchedDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Label seriesWatchedLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel breakPanel;
        private System.Windows.Forms.Panel tablesPanel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RadioButton tenthRadioButton;
        private System.Windows.Forms.RadioButton ninthRadioButton;
        private System.Windows.Forms.RadioButton eighthRadioButton;
        private System.Windows.Forms.RadioButton seventhRadioButton;
        private System.Windows.Forms.RadioButton sixthRadioButton;
        private System.Windows.Forms.RadioButton fifthRadioButton;
        private System.Windows.Forms.RadioButton fourRadioButton;
        private System.Windows.Forms.RadioButton threeRadioButton;
        private System.Windows.Forms.RadioButton twoRadioButton;
        private System.Windows.Forms.RadioButton oneRadioButton;
        private System.Windows.Forms.GroupBox ratingGroupBox;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.OpenFileDialog coverOpenFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DataGridView seriesWatchedDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn coverDataGridViewImageColumn;
        private System.Windows.Forms.ImageList coverImagesImageList;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}