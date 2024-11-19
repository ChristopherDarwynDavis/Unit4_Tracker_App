
namespace DavCFinalProject
{
    partial class preOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.seriesWatchedLabel = new System.Windows.Forms.Label();
            this.placeHolderPictureBox = new System.Windows.Forms.PictureBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.orLabel = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.orderTitleTextBox = new System.Windows.Forms.TextBox();
            this.orderTitleLabel = new System.Windows.Forms.Label();
            this.preOrderPanel = new System.Windows.Forms.Panel();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.addPanel = new System.Windows.Forms.Panel();
            this.breakPanel = new System.Windows.Forms.Panel();
            this.tablesPanel = new System.Windows.Forms.Panel();
            this.preOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coverDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.preOrderOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.placeHolderPictureBox)).BeginInit();
            this.preOrderPanel.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.tablesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preOrderDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.seriesWatchedLabel.Text = "Add Pre-Order";
            this.seriesWatchedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // placeHolderPictureBox
            // 
            this.placeHolderPictureBox.BackgroundImage = global::DavCFinalProject.Properties.Resources.placeholder;
            this.placeHolderPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.placeHolderPictureBox.Location = new System.Drawing.Point(54, 197);
            this.placeHolderPictureBox.Name = "placeHolderPictureBox";
            this.placeHolderPictureBox.Size = new System.Drawing.Size(164, 207);
            this.placeHolderPictureBox.TabIndex = 6;
            this.placeHolderPictureBox.TabStop = false;
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
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.orLabel.Location = new System.Drawing.Point(245, 297);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(26, 19);
            this.orLabel.TabIndex = 4;
            this.orLabel.Text = "or";
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
            // orderTitleTextBox
            // 
            this.orderTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.orderTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderTitleTextBox.Location = new System.Drawing.Point(88, 20);
            this.orderTitleTextBox.Name = "orderTitleTextBox";
            this.orderTitleTextBox.Size = new System.Drawing.Size(325, 20);
            this.orderTitleTextBox.TabIndex = 1;
            // 
            // orderTitleLabel
            // 
            this.orderTitleLabel.AutoSize = true;
            this.orderTitleLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.orderTitleLabel.Location = new System.Drawing.Point(18, 16);
            this.orderTitleLabel.Name = "orderTitleLabel";
            this.orderTitleLabel.Size = new System.Drawing.Size(73, 24);
            this.orderTitleLabel.TabIndex = 0;
            this.orderTitleLabel.Text = "Title : ";
            // 
            // preOrderPanel
            // 
            this.preOrderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.preOrderPanel.Controls.Add(this.priceTextBox);
            this.preOrderPanel.Controls.Add(this.priceLabel);
            this.preOrderPanel.Controls.Add(this.placeHolderPictureBox);
            this.preOrderPanel.Controls.Add(this.submitButton);
            this.preOrderPanel.Controls.Add(this.orLabel);
            this.preOrderPanel.Controls.Add(this.uploadButton);
            this.preOrderPanel.Controls.Add(this.orderTitleTextBox);
            this.preOrderPanel.Controls.Add(this.orderTitleLabel);
            this.preOrderPanel.Location = new System.Drawing.Point(25, 125);
            this.preOrderPanel.Name = "preOrderPanel";
            this.preOrderPanel.Size = new System.Drawing.Size(435, 600);
            this.preOrderPanel.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceTextBox.Location = new System.Drawing.Point(88, 89);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(325, 20);
            this.priceTextBox.TabIndex = 2;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.priceLabel.Location = new System.Drawing.Point(10, 85);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(81, 24);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Price : ";
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.breakPanel);
            this.addPanel.Controls.Add(this.preOrderPanel);
            this.addPanel.Controls.Add(this.seriesWatchedLabel);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.addPanel.Location = new System.Drawing.Point(800, 0);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(480, 800);
            this.addPanel.TabIndex = 1;
            // 
            // breakPanel
            // 
            this.breakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.breakPanel.Location = new System.Drawing.Point(3, 42);
            this.breakPanel.Name = "breakPanel";
            this.breakPanel.Size = new System.Drawing.Size(1, 690);
            this.breakPanel.TabIndex = 2;
            // 
            // tablesPanel
            // 
            this.tablesPanel.Controls.Add(this.preOrderDataGridView);
            this.tablesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesPanel.Location = new System.Drawing.Point(0, 0);
            this.tablesPanel.Name = "tablesPanel";
            this.tablesPanel.Size = new System.Drawing.Size(800, 800);
            this.tablesPanel.TabIndex = 2;
            // 
            // preOrderDataGridView
            // 
            this.preOrderDataGridView.AllowUserToAddRows = false;
            this.preOrderDataGridView.AllowUserToDeleteRows = false;
            this.preOrderDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.preOrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.preOrderDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.preOrderDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.preOrderDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.preOrderDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.preOrderDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.preOrderDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.preOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.preOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.coverDataGridViewImageColumn});
            this.preOrderDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.preOrderDataGridView.Location = new System.Drawing.Point(43, 50);
            this.preOrderDataGridView.Margin = new System.Windows.Forms.Padding(50);
            this.preOrderDataGridView.Name = "preOrderDataGridView";
            this.preOrderDataGridView.ReadOnly = true;
            this.preOrderDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.preOrderDataGridView.RowTemplate.ReadOnly = true;
            this.preOrderDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.preOrderDataGridView.Size = new System.Drawing.Size(720, 750);
            this.preOrderDataGridView.TabIndex = 0;
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
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Price";
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
            this.coverDataGridViewImageColumn.HeaderText = "Image";
            this.coverDataGridViewImageColumn.MinimumWidth = 100;
            this.coverDataGridViewImageColumn.Name = "coverDataGridViewImageColumn";
            this.coverDataGridViewImageColumn.ReadOnly = true;
            this.coverDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.coverDataGridViewImageColumn.Width = 288;
            // 
            // preOrderOpenFileDialog
            // 
            this.preOrderOpenFileDialog.FileName = "openFileDialog1";
            // 
            // preOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.tablesPanel);
            this.Controls.Add(this.addPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "preOrderForm";
            this.Text = "preOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.placeHolderPictureBox)).EndInit();
            this.preOrderPanel.ResumeLayout(false);
            this.preOrderPanel.PerformLayout();
            this.addPanel.ResumeLayout(false);
            this.tablesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preOrderDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label seriesWatchedLabel;
        private System.Windows.Forms.PictureBox placeHolderPictureBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.TextBox orderTitleTextBox;
        private System.Windows.Forms.Label orderTitleLabel;
        private System.Windows.Forms.Panel preOrderPanel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Panel breakPanel;
        private System.Windows.Forms.Panel tablesPanel;
        private System.Windows.Forms.DataGridView preOrderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn coverDataGridViewImageColumn;
        private System.Windows.Forms.OpenFileDialog preOrderOpenFileDialog;
    }
}