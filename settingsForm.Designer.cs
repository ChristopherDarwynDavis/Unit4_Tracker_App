
namespace DavCFinalProject
{
    partial class settingsForm
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
            this.typesPanel = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.preOrderLabel = new System.Windows.Forms.Label();
            this.seriesWatchedLabel = new System.Windows.Forms.Label();
            this.imagesFileLabel = new System.Windows.Forms.Label();
            this.pricingFileLabel = new System.Windows.Forms.Label();
            this.preOrderTitleLabel = new System.Windows.Forms.Label();
            this.coverFileLabel = new System.Windows.Forms.Label();
            this.ratingFileLabel = new System.Windows.Forms.Label();
            this.seriesTitlesLabel = new System.Windows.Forms.Label();
            this.saveLocationLabel = new System.Windows.Forms.Label();
            this.seriesTitleTextBox = new System.Windows.Forms.TextBox();
            this.ratingFileTextBox = new System.Windows.Forms.TextBox();
            this.coverFileTextBox = new System.Windows.Forms.TextBox();
            this.imageFileTextBox = new System.Windows.Forms.TextBox();
            this.pricingFileTextBox = new System.Windows.Forms.TextBox();
            this.preTitlesTextBox = new System.Windows.Forms.TextBox();
            this.currentPanel = new System.Windows.Forms.Panel();
            this.currentImageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentPricingTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currentPreTitlesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currentCoverTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currentRatingTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.currentSeriesTitleTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.seriesTitleFileButton = new System.Windows.Forms.Button();
            this.seriesRatingFileButton = new System.Windows.Forms.Button();
            this.seriesCoverFileButton = new System.Windows.Forms.Button();
            this.preImagesFileButton = new System.Windows.Forms.Button();
            this.prePricingFileButton = new System.Windows.Forms.Button();
            this.preTitleFileButton = new System.Windows.Forms.Button();
            this.seriesTitleOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.seriesRatingOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.seriesCoverOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.preOrderTitleOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.preOrderPricingOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.preOrderImageOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.typesPanel.SuspendLayout();
            this.currentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // typesPanel
            // 
            this.typesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.typesPanel.Controls.Add(this.updateButton);
            this.typesPanel.Controls.Add(this.preOrderLabel);
            this.typesPanel.Controls.Add(this.seriesWatchedLabel);
            this.typesPanel.Controls.Add(this.imagesFileLabel);
            this.typesPanel.Controls.Add(this.pricingFileLabel);
            this.typesPanel.Controls.Add(this.preOrderTitleLabel);
            this.typesPanel.Controls.Add(this.coverFileLabel);
            this.typesPanel.Controls.Add(this.ratingFileLabel);
            this.typesPanel.Controls.Add(this.seriesTitlesLabel);
            this.typesPanel.Controls.Add(this.saveLocationLabel);
            this.typesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.typesPanel.Location = new System.Drawing.Point(0, 0);
            this.typesPanel.Name = "typesPanel";
            this.typesPanel.Size = new System.Drawing.Size(330, 800);
            this.typesPanel.TabIndex = 0;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.updateButton.Location = new System.Drawing.Point(0, 761);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(330, 39);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Apply";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // preOrderLabel
            // 
            this.preOrderLabel.AutoSize = true;
            this.preOrderLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preOrderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.preOrderLabel.Location = new System.Drawing.Point(185, 251);
            this.preOrderLabel.Name = "preOrderLabel";
            this.preOrderLabel.Size = new System.Drawing.Size(125, 24);
            this.preOrderLabel.TabIndex = 8;
            this.preOrderLabel.Text = "Pre-Orders";
            // 
            // seriesWatchedLabel
            // 
            this.seriesWatchedLabel.AutoSize = true;
            this.seriesWatchedLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriesWatchedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.seriesWatchedLabel.Location = new System.Drawing.Point(146, 63);
            this.seriesWatchedLabel.Name = "seriesWatchedLabel";
            this.seriesWatchedLabel.Size = new System.Drawing.Size(164, 24);
            this.seriesWatchedLabel.TabIndex = 7;
            this.seriesWatchedLabel.Text = "Series Watched";
            // 
            // imagesFileLabel
            // 
            this.imagesFileLabel.AutoSize = true;
            this.imagesFileLabel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagesFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(102)))));
            this.imagesFileLabel.Location = new System.Drawing.Point(202, 391);
            this.imagesFileLabel.Name = "imagesFileLabel";
            this.imagesFileLabel.Size = new System.Drawing.Size(108, 21);
            this.imagesFileLabel.TabIndex = 6;
            this.imagesFileLabel.Text = "Images File";
            // 
            // pricingFileLabel
            // 
            this.pricingFileLabel.AutoSize = true;
            this.pricingFileLabel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricingFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(102)))));
            this.pricingFileLabel.Location = new System.Drawing.Point(203, 336);
            this.pricingFileLabel.Name = "pricingFileLabel";
            this.pricingFileLabel.Size = new System.Drawing.Size(107, 21);
            this.pricingFileLabel.TabIndex = 5;
            this.pricingFileLabel.Text = "Pricing File";
            // 
            // preOrderTitleLabel
            // 
            this.preOrderTitleLabel.AutoSize = true;
            this.preOrderTitleLabel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preOrderTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(102)))));
            this.preOrderTitleLabel.Location = new System.Drawing.Point(217, 287);
            this.preOrderTitleLabel.Name = "preOrderTitleLabel";
            this.preOrderTitleLabel.Size = new System.Drawing.Size(95, 21);
            this.preOrderTitleLabel.TabIndex = 4;
            this.preOrderTitleLabel.Text = "Titles File";
            // 
            // coverFileLabel
            // 
            this.coverFileLabel.AutoSize = true;
            this.coverFileLabel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coverFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(102)))));
            this.coverFileLabel.Location = new System.Drawing.Point(196, 202);
            this.coverFileLabel.Name = "coverFileLabel";
            this.coverFileLabel.Size = new System.Drawing.Size(114, 21);
            this.coverFileLabel.TabIndex = 3;
            this.coverFileLabel.Text = "Cover\'s File";
            // 
            // ratingFileLabel
            // 
            this.ratingFileLabel.AutoSize = true;
            this.ratingFileLabel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(102)))));
            this.ratingFileLabel.Location = new System.Drawing.Point(196, 147);
            this.ratingFileLabel.Name = "ratingFileLabel";
            this.ratingFileLabel.Size = new System.Drawing.Size(116, 21);
            this.ratingFileLabel.TabIndex = 2;
            this.ratingFileLabel.Text = "Rating\'s File";
            // 
            // seriesTitlesLabel
            // 
            this.seriesTitlesLabel.AutoSize = true;
            this.seriesTitlesLabel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriesTitlesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(102)))));
            this.seriesTitlesLabel.Location = new System.Drawing.Point(217, 98);
            this.seriesTitlesLabel.Name = "seriesTitlesLabel";
            this.seriesTitlesLabel.Size = new System.Drawing.Size(95, 21);
            this.seriesTitlesLabel.TabIndex = 1;
            this.seriesTitlesLabel.Text = "Titles File";
            // 
            // saveLocationLabel
            // 
            this.saveLocationLabel.AutoSize = true;
            this.saveLocationLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLocationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.saveLocationLabel.Location = new System.Drawing.Point(58, 9);
            this.saveLocationLabel.Name = "saveLocationLabel";
            this.saveLocationLabel.Size = new System.Drawing.Size(219, 33);
            this.saveLocationLabel.TabIndex = 0;
            this.saveLocationLabel.Text = "Save Locations";
            // 
            // seriesTitleTextBox
            // 
            this.seriesTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.seriesTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seriesTitleTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriesTitleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.seriesTitleTextBox.Location = new System.Drawing.Point(337, 97);
            this.seriesTitleTextBox.Name = "seriesTitleTextBox";
            this.seriesTitleTextBox.ReadOnly = true;
            this.seriesTitleTextBox.Size = new System.Drawing.Size(250, 23);
            this.seriesTitleTextBox.TabIndex = 1;
            this.seriesTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ratingFileTextBox
            // 
            this.ratingFileTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.ratingFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ratingFileTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingFileTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.ratingFileTextBox.Location = new System.Drawing.Point(337, 146);
            this.ratingFileTextBox.Name = "ratingFileTextBox";
            this.ratingFileTextBox.ReadOnly = true;
            this.ratingFileTextBox.Size = new System.Drawing.Size(250, 23);
            this.ratingFileTextBox.TabIndex = 2;
            this.ratingFileTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // coverFileTextBox
            // 
            this.coverFileTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.coverFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coverFileTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coverFileTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.coverFileTextBox.Location = new System.Drawing.Point(337, 201);
            this.coverFileTextBox.Name = "coverFileTextBox";
            this.coverFileTextBox.ReadOnly = true;
            this.coverFileTextBox.Size = new System.Drawing.Size(250, 23);
            this.coverFileTextBox.TabIndex = 3;
            this.coverFileTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // imageFileTextBox
            // 
            this.imageFileTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.imageFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageFileTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageFileTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.imageFileTextBox.Location = new System.Drawing.Point(337, 390);
            this.imageFileTextBox.Name = "imageFileTextBox";
            this.imageFileTextBox.ReadOnly = true;
            this.imageFileTextBox.Size = new System.Drawing.Size(250, 23);
            this.imageFileTextBox.TabIndex = 6;
            this.imageFileTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pricingFileTextBox
            // 
            this.pricingFileTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.pricingFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricingFileTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricingFileTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.pricingFileTextBox.Location = new System.Drawing.Point(337, 335);
            this.pricingFileTextBox.Name = "pricingFileTextBox";
            this.pricingFileTextBox.ReadOnly = true;
            this.pricingFileTextBox.Size = new System.Drawing.Size(250, 23);
            this.pricingFileTextBox.TabIndex = 5;
            this.pricingFileTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // preTitlesTextBox
            // 
            this.preTitlesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.preTitlesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preTitlesTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preTitlesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.preTitlesTextBox.Location = new System.Drawing.Point(337, 286);
            this.preTitlesTextBox.Name = "preTitlesTextBox";
            this.preTitlesTextBox.ReadOnly = true;
            this.preTitlesTextBox.Size = new System.Drawing.Size(250, 23);
            this.preTitlesTextBox.TabIndex = 4;
            this.preTitlesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // currentPanel
            // 
            this.currentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.currentPanel.Controls.Add(this.currentImageTextBox);
            this.currentPanel.Controls.Add(this.label1);
            this.currentPanel.Controls.Add(this.currentPricingTextBox);
            this.currentPanel.Controls.Add(this.label2);
            this.currentPanel.Controls.Add(this.currentPreTitlesTextBox);
            this.currentPanel.Controls.Add(this.label3);
            this.currentPanel.Controls.Add(this.currentCoverTextBox);
            this.currentPanel.Controls.Add(this.label4);
            this.currentPanel.Controls.Add(this.currentRatingTextBox);
            this.currentPanel.Controls.Add(this.label5);
            this.currentPanel.Controls.Add(this.currentSeriesTitleTextBox);
            this.currentPanel.Controls.Add(this.label6);
            this.currentPanel.Controls.Add(this.label7);
            this.currentPanel.Controls.Add(this.label8);
            this.currentPanel.Controls.Add(this.label9);
            this.currentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.currentPanel.Location = new System.Drawing.Point(880, 0);
            this.currentPanel.Name = "currentPanel";
            this.currentPanel.Size = new System.Drawing.Size(400, 800);
            this.currentPanel.TabIndex = 9;
            // 
            // currentImageTextBox
            // 
            this.currentImageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.currentImageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentImageTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentImageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.currentImageTextBox.Location = new System.Drawing.Point(184, 390);
            this.currentImageTextBox.Name = "currentImageTextBox";
            this.currentImageTextBox.ReadOnly = true;
            this.currentImageTextBox.Size = new System.Drawing.Size(204, 23);
            this.currentImageTextBox.TabIndex = 15;
            this.currentImageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label1.Location = new System.Drawing.Point(51, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pre-Orders";
            // 
            // currentPricingTextBox
            // 
            this.currentPricingTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.currentPricingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPricingTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPricingTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.currentPricingTextBox.Location = new System.Drawing.Point(184, 335);
            this.currentPricingTextBox.Name = "currentPricingTextBox";
            this.currentPricingTextBox.ReadOnly = true;
            this.currentPricingTextBox.Size = new System.Drawing.Size(204, 23);
            this.currentPricingTextBox.TabIndex = 14;
            this.currentPricingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Series Watched";
            // 
            // currentPreTitlesTextBox
            // 
            this.currentPreTitlesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.currentPreTitlesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPreTitlesTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPreTitlesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.currentPreTitlesTextBox.Location = new System.Drawing.Point(184, 286);
            this.currentPreTitlesTextBox.Name = "currentPreTitlesTextBox";
            this.currentPreTitlesTextBox.ReadOnly = true;
            this.currentPreTitlesTextBox.Size = new System.Drawing.Size(204, 23);
            this.currentPreTitlesTextBox.TabIndex = 13;
            this.currentPreTitlesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(68, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Images File";
            // 
            // currentCoverTextBox
            // 
            this.currentCoverTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.currentCoverTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentCoverTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCoverTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.currentCoverTextBox.Location = new System.Drawing.Point(184, 201);
            this.currentCoverTextBox.Name = "currentCoverTextBox";
            this.currentCoverTextBox.ReadOnly = true;
            this.currentCoverTextBox.Size = new System.Drawing.Size(204, 23);
            this.currentCoverTextBox.TabIndex = 12;
            this.currentCoverTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label4.Location = new System.Drawing.Point(69, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pricing File";
            // 
            // currentRatingTextBox
            // 
            this.currentRatingTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.currentRatingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentRatingTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRatingTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.currentRatingTextBox.Location = new System.Drawing.Point(184, 146);
            this.currentRatingTextBox.Name = "currentRatingTextBox";
            this.currentRatingTextBox.ReadOnly = true;
            this.currentRatingTextBox.Size = new System.Drawing.Size(204, 23);
            this.currentRatingTextBox.TabIndex = 11;
            this.currentRatingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label5.Location = new System.Drawing.Point(83, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Titles File";
            // 
            // currentSeriesTitleTextBox
            // 
            this.currentSeriesTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.currentSeriesTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentSeriesTitleTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSeriesTitleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.currentSeriesTitleTextBox.Location = new System.Drawing.Point(184, 97);
            this.currentSeriesTitleTextBox.Name = "currentSeriesTitleTextBox";
            this.currentSeriesTitleTextBox.ReadOnly = true;
            this.currentSeriesTitleTextBox.Size = new System.Drawing.Size(204, 23);
            this.currentSeriesTitleTextBox.TabIndex = 10;
            this.currentSeriesTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label6.Location = new System.Drawing.Point(62, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cover\'s File";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label7.Location = new System.Drawing.Point(62, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Rating\'s File";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label8.Location = new System.Drawing.Point(83, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Titles File";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label9.Location = new System.Drawing.Point(78, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 33);
            this.label9.TabIndex = 0;
            this.label9.Text = "Current Locations";
            // 
            // seriesTitleFileButton
            // 
            this.seriesTitleFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seriesTitleFileButton.Image = global::DavCFinalProject.Properties.Resources.menu_16x16_1214316;
            this.seriesTitleFileButton.Location = new System.Drawing.Point(341, 101);
            this.seriesTitleFileButton.Name = "seriesTitleFileButton";
            this.seriesTitleFileButton.Size = new System.Drawing.Size(25, 15);
            this.seriesTitleFileButton.TabIndex = 10;
            this.seriesTitleFileButton.UseVisualStyleBackColor = true;
            this.seriesTitleFileButton.Click += new System.EventHandler(this.seriesTitleFileButton_Click);
            // 
            // seriesRatingFileButton
            // 
            this.seriesRatingFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seriesRatingFileButton.Image = global::DavCFinalProject.Properties.Resources.menu_16x16_1214316;
            this.seriesRatingFileButton.Location = new System.Drawing.Point(341, 150);
            this.seriesRatingFileButton.Name = "seriesRatingFileButton";
            this.seriesRatingFileButton.Size = new System.Drawing.Size(25, 15);
            this.seriesRatingFileButton.TabIndex = 11;
            this.seriesRatingFileButton.UseVisualStyleBackColor = true;
            this.seriesRatingFileButton.Click += new System.EventHandler(this.seriesRatingFileButton_Click);
            // 
            // seriesCoverFileButton
            // 
            this.seriesCoverFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seriesCoverFileButton.Image = global::DavCFinalProject.Properties.Resources.menu_16x16_1214316;
            this.seriesCoverFileButton.Location = new System.Drawing.Point(341, 205);
            this.seriesCoverFileButton.Name = "seriesCoverFileButton";
            this.seriesCoverFileButton.Size = new System.Drawing.Size(25, 15);
            this.seriesCoverFileButton.TabIndex = 12;
            this.seriesCoverFileButton.UseVisualStyleBackColor = true;
            this.seriesCoverFileButton.Click += new System.EventHandler(this.seriesCoverFileButton_Click);
            // 
            // preImagesFileButton
            // 
            this.preImagesFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.preImagesFileButton.Image = global::DavCFinalProject.Properties.Resources.menu_16x16_1214316;
            this.preImagesFileButton.Location = new System.Drawing.Point(341, 394);
            this.preImagesFileButton.Name = "preImagesFileButton";
            this.preImagesFileButton.Size = new System.Drawing.Size(25, 15);
            this.preImagesFileButton.TabIndex = 15;
            this.preImagesFileButton.UseVisualStyleBackColor = true;
            this.preImagesFileButton.Click += new System.EventHandler(this.preImagesFileButton_Click);
            // 
            // prePricingFileButton
            // 
            this.prePricingFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prePricingFileButton.Image = global::DavCFinalProject.Properties.Resources.menu_16x16_1214316;
            this.prePricingFileButton.Location = new System.Drawing.Point(341, 339);
            this.prePricingFileButton.Name = "prePricingFileButton";
            this.prePricingFileButton.Size = new System.Drawing.Size(25, 15);
            this.prePricingFileButton.TabIndex = 14;
            this.prePricingFileButton.UseVisualStyleBackColor = true;
            this.prePricingFileButton.Click += new System.EventHandler(this.prePricingFileButton_Click);
            // 
            // preTitleFileButton
            // 
            this.preTitleFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.preTitleFileButton.Image = global::DavCFinalProject.Properties.Resources.menu_16x16_1214316;
            this.preTitleFileButton.Location = new System.Drawing.Point(341, 290);
            this.preTitleFileButton.Name = "preTitleFileButton";
            this.preTitleFileButton.Size = new System.Drawing.Size(25, 15);
            this.preTitleFileButton.TabIndex = 13;
            this.preTitleFileButton.UseVisualStyleBackColor = true;
            this.preTitleFileButton.Click += new System.EventHandler(this.preTitleFileButton_Click);
            // 
            // seriesTitleOpenFileDialog
            // 
            this.seriesTitleOpenFileDialog.FileName = "seriesTitleOpenFileDialog";
            this.seriesTitleOpenFileDialog.Filter = "Text files|*.txt";
            // 
            // seriesRatingOpenFileDialog
            // 
            this.seriesRatingOpenFileDialog.FileName = "seriesRatingOpenFileDialog";
            this.seriesRatingOpenFileDialog.Filter = "Text files|*.txt";
            // 
            // seriesCoverOpenFileDialog
            // 
            this.seriesCoverOpenFileDialog.FileName = "seriesCoverOpenFileDialog";
            this.seriesCoverOpenFileDialog.Filter = "Text files|*.txt";
            // 
            // preOrderTitleOpenFileDialog
            // 
            this.preOrderTitleOpenFileDialog.FileName = "preOrderTitleOpenFileDialog";
            this.preOrderTitleOpenFileDialog.Filter = "Text files|*.txt";
            // 
            // preOrderPricingOpenFileDialog
            // 
            this.preOrderPricingOpenFileDialog.FileName = "preOrderPricingOpenFileDialog";
            this.preOrderPricingOpenFileDialog.Filter = "Text files|*.txt";
            // 
            // preOrderImageOpenFileDialog
            // 
            this.preOrderImageOpenFileDialog.FileName = "preOrderImageOpenFileDialog";
            this.preOrderImageOpenFileDialog.Filter = "Text files|*.txt";
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.preImagesFileButton);
            this.Controls.Add(this.prePricingFileButton);
            this.Controls.Add(this.preTitleFileButton);
            this.Controls.Add(this.seriesCoverFileButton);
            this.Controls.Add(this.seriesRatingFileButton);
            this.Controls.Add(this.seriesTitleFileButton);
            this.Controls.Add(this.currentPanel);
            this.Controls.Add(this.imageFileTextBox);
            this.Controls.Add(this.pricingFileTextBox);
            this.Controls.Add(this.preTitlesTextBox);
            this.Controls.Add(this.coverFileTextBox);
            this.Controls.Add(this.ratingFileTextBox);
            this.Controls.Add(this.seriesTitleTextBox);
            this.Controls.Add(this.typesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settingsForm";
            this.Text = "settings";
            this.typesPanel.ResumeLayout(false);
            this.typesPanel.PerformLayout();
            this.currentPanel.ResumeLayout(false);
            this.currentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel typesPanel;
        private System.Windows.Forms.Label saveLocationLabel;
        private System.Windows.Forms.Label preOrderLabel;
        private System.Windows.Forms.Label seriesWatchedLabel;
        private System.Windows.Forms.Label imagesFileLabel;
        private System.Windows.Forms.Label pricingFileLabel;
        private System.Windows.Forms.Label preOrderTitleLabel;
        private System.Windows.Forms.Label coverFileLabel;
        private System.Windows.Forms.Label ratingFileLabel;
        private System.Windows.Forms.Label seriesTitlesLabel;
        private System.Windows.Forms.TextBox seriesTitleTextBox;
        private System.Windows.Forms.TextBox ratingFileTextBox;
        private System.Windows.Forms.TextBox coverFileTextBox;
        private System.Windows.Forms.TextBox imageFileTextBox;
        private System.Windows.Forms.TextBox pricingFileTextBox;
        private System.Windows.Forms.TextBox preTitlesTextBox;
        private System.Windows.Forms.Panel currentPanel;
        private System.Windows.Forms.TextBox currentImageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currentPricingTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currentPreTitlesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currentCoverTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currentRatingTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currentSeriesTitleTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button seriesTitleFileButton;
        private System.Windows.Forms.Button seriesRatingFileButton;
        private System.Windows.Forms.Button seriesCoverFileButton;
        private System.Windows.Forms.Button preImagesFileButton;
        private System.Windows.Forms.Button prePricingFileButton;
        private System.Windows.Forms.Button preTitleFileButton;
        private System.Windows.Forms.OpenFileDialog seriesTitleOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog seriesRatingOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog seriesCoverOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog preOrderTitleOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog preOrderPricingOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog preOrderImageOpenFileDialog;
    }
}