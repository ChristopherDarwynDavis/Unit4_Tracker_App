using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/* Author: Christopher Davis
 * Date: 11.25.2021
 * Description: This form pulls and updates data from a set of text files to display a users saved
 * titles with rating and a cover image.
 */
namespace DavCFinalProject
{
    public partial class seriesWatchedForm : Form
    {
        //Creating a FileLocation object
        FileLocation files = new FileLocation();
        //Creating a string
        private string cover;
        //Creating the input files strings
        private string titlesFile;
        private string ratingsFile;
        private string coverFile;
        public seriesWatchedForm()
        {
            InitializeComponent();

            //Setting seriesWatchedDataGridView values to false to use the default values
            seriesWatchedDataGridView.AllowUserToResizeColumns = false;
            seriesWatchedDataGridView.EnableHeadersVisualStyles = false;
            seriesWatchedDataGridView.DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20);
            seriesWatchedDataGridView.DefaultCellStyle.Font = new Font("MS UI Gothic", 12f, FontStyle.Regular);
            seriesWatchedDataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(0, 100, 112);
            seriesWatchedDataGridView.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            seriesWatchedDataGridView.RowHeadersVisible = false;
            seriesWatchedDataGridView.ScrollBars = ScrollBars.Vertical;
            //Setting colors and font styles for the headers of columns
            seriesWatchedDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 50, 60);
            seriesWatchedDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("MS UI Gothic", 16f, FontStyle.Regular);
            seriesWatchedDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0,100,112);
            //Generates the files data
            files.Gen();
            //Giving the file locations to the strings
            titlesFile = files.SeriesTitle();
            ratingsFile = files.SeriesRating();
            coverFile = files.SeriesCover();
            //Calling the UpdateData method
            UpdateData();
        }
        private void UpdateData()
        {
            //Trys following
            try
            {
                //Calls the GetCovers Method
                Cover cover = new Cover();

                List<Bitmap> coverReSized = cover.Pull(coverFile, 100, 150);
                //Creating an int called index
                int index = 0;
                //Clears the DataGridView 
                seriesWatchedDataGridView.Rows.Clear();
                //Creating StreamReader's and opening them
                StreamReader inputTitle;
                inputTitle = File.OpenText(titlesFile);
                StreamReader inputRating;
                inputRating = File.OpenText(ratingsFile);

                //While not at the end of files
                while (!inputTitle.EndOfStream && !inputRating.EndOfStream)
                {
                    //Adds a row with the data from inputTitle file, inputRating file, and the cover images
                    seriesWatchedDataGridView.Rows.Add(inputTitle.ReadLine(),
                    inputRating.ReadLine() + "/10", coverReSized[index]);
                    //Adding one to index
                    index++;
                }
                //Closing the open text files
                inputTitle.Close();
                inputRating.Close();
            }
            catch
            {

            }
        }
        private void uploadButton_Click(object sender, EventArgs e)
        {
            //If the user selects a valid file
            if (coverOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Sets the image selected to a new bitmap called orig
                cover = coverOpenFileDialog.FileName;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Creating StreamWriter objects
            StreamWriter outputTitle;
            outputTitle = File.AppendText(titlesFile);
            StreamWriter outputRating;
            outputRating = File.AppendText(ratingsFile);
            StreamWriter outputImage;
            outputImage = File.AppendText(coverFile);

            //Creates a radio button called check and sets it equal to the selected radio button in ratingGroupBox
            RadioButton check = ratingGroupBox.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();

            //Checks if there is text in titleTextBox
            if (titleTextBox.Text != "")
            {
                //Takes the text from the title textbox and writes it to the outputTitle file
                if (cover == "")
                {
                    //Sets the string cover to the placeholder
                    cover = @"Sample Images\placeholder.jpg";
                    //Writes data to text files
                    outputTitle.WriteLine(titleTextBox.Text);
                    outputImage.WriteLine(cover);
                    //If check isn't equal to empty
                    if (check != null)
                    {
                        //Compares the name of the given radioButton and selects the case with the same name
                        switch (check.Name)
                        {
                            //Writes a line to outputRating and deselects the radio button
                            case "oneRadioButton":
                                outputRating.WriteLine("1");
                                oneRadioButton.Checked = false;
                                break;

                            case "twoRadioButton":
                                outputRating.WriteLine("2");
                                twoRadioButton.Checked = false;
                                break;

                            case "threeRadioButton":
                                outputRating.WriteLine("3");
                                threeRadioButton.Checked = false;
                                break;

                            case "fourRadioButton":
                                outputRating.WriteLine("4");
                                fourRadioButton.Checked = false;
                                break;

                            case "fifthRadioButton":
                                outputRating.WriteLine("5");
                                fifthRadioButton.Checked = false;
                                break;

                            case "sixthRadioButton":
                                outputRating.WriteLine("6");
                                sixthRadioButton.Checked = false;
                                break;

                            case "seventhRadioButton":
                                outputRating.WriteLine("7");
                                seventhRadioButton.Checked = false;
                                break;

                            case "eighthRadioButton":
                                outputRating.WriteLine("8");
                                eighthRadioButton.Checked = false;
                                break;

                            case "ninthRadioButton":
                                outputRating.WriteLine("9");
                                ninthRadioButton.Checked = false;
                                break;

                            case "tenthRadioButton":
                                outputRating.WriteLine("10");
                                tenthRadioButton.Checked = false;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select a rating");
                    }
                }
                else
                {
                    //Writes data to text files
                    outputTitle.WriteLine(titleTextBox.Text);
                    outputImage.WriteLine(cover);
                    //If check isn't equal to empty
                    if (check != null)
                    {
                        //Compares the name of the given radioButton and selects the case with the same name
                        switch (check.Name)
                        {
                            //Writes a line to outputRating and deselects the radio button
                            case "oneRadioButton":
                                outputRating.WriteLine("1");
                                oneRadioButton.Checked = false;
                                break;

                            case "twoRadioButton":
                                outputRating.WriteLine("2");
                                twoRadioButton.Checked = false;
                                break;

                            case "threeRadioButton":
                                outputRating.WriteLine("3");
                                threeRadioButton.Checked = false;
                                break;

                            case "fourRadioButton":
                                outputRating.WriteLine("4");
                                fourRadioButton.Checked = false;
                                break;

                            case "fifthRadioButton":
                                outputRating.WriteLine("5");
                                fifthRadioButton.Checked = false;
                                break;

                            case "sixthRadioButton":
                                outputRating.WriteLine("6");
                                sixthRadioButton.Checked = false;
                                break;

                            case "seventhRadioButton":
                                outputRating.WriteLine("7");
                                seventhRadioButton.Checked = false;
                                break;

                            case "eighthRadioButton":
                                outputRating.WriteLine("8");
                                eighthRadioButton.Checked = false;
                                break;

                            case "ninthRadioButton":
                                outputRating.WriteLine("9");
                                ninthRadioButton.Checked = false;
                                break;

                            case "tenthRadioButton":
                                outputRating.WriteLine("10");
                                tenthRadioButton.Checked = false;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select a rating");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a title");
            }

            //Closes the open output files
            outputTitle.Close();
            outputRating.Close();
            outputImage.Close();
            //Clears the text field of titleTextBox
            titleTextBox.Text = "";
            //Sets cover string to empty
            cover = "";
            //Calls the UpdateData method
            UpdateData();
        }
    }
}
