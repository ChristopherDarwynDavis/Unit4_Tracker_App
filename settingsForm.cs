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
 * Date: 12.4.2021
 * Desc: This is a form that lets the user set their save files
 */
namespace DavCFinalProject
{
    public partial class settingsForm : Form
    {
        //Creating const int of 6
        const int FILES_NUM = 6;
        //Creating a string called files with a length of const int FILES_NUM
        string[] files = new string[FILES_NUM];

        public settingsForm()
        {
            InitializeComponent();

            //Try the following on load
            try
            {
                //Creating an int called index
                int index = 0;

                //Creating a streamreader object
                StreamReader inputFile;
                inputFile = File.OpenText("files.txt");

                //While not at the end of inputFile
                while (!inputFile.EndOfStream)
                {
                    //Setting the values in inputFile to files array
                    files[index] = inputFile.ReadLine();
                    //Adding one to index
                    index++;
                }
                //Closing the inputFile
                inputFile.Close();

                //Setting the current locations textbox's
                currentSeriesTitleTextBox.Text = files[0];
                currentRatingTextBox.Text = files[1];
                currentCoverTextBox.Text = files[2];
                currentPreTitlesTextBox.Text = files[3];
                currentPricingTextBox.Text = files[4];
                currentImageTextBox.Text = files[5];
            }
            catch
            {
                //Displays a message box
                MessageBox.Show("Saves file is corrupted or missing");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //If all fields have been given a path
            if (seriesTitleTextBox.Text != "" && ratingFileTextBox.Text != "" && coverFileTextBox.Text != ""
                && preTitlesTextBox.Text != "" && ratingFileTextBox.Text != "" && imageFileTextBox.Text != "") 
            {
                //Try the following
                try
                {
                    //Clearing the files.txt file
                    File.WriteAllText("files.txt", String.Empty);
                    //Creating stream writer object
                    StreamWriter outputFile;
                    outputFile = File.AppendText("files.txt");
                    //Writing file locations to outputFile
                    outputFile.WriteLine(seriesTitleTextBox.Text);
                    outputFile.WriteLine(ratingFileTextBox.Text);
                    outputFile.WriteLine(coverFileTextBox.Text);
                    outputFile.WriteLine(preTitlesTextBox.Text);
                    outputFile.WriteLine(pricingFileTextBox.Text);
                    outputFile.WriteLine(imageFileTextBox.Text);
                    //Closing the outputFile
                    outputFile.Close();
                }
                catch
                {
                    //Displaying a message box
                    MessageBox.Show("Unable to locate locations save file");
                }
            }
            else
            {
                //Displays a message box
                MessageBox.Show("Must select a file location for all");
            }
        }

        private void seriesTitleFileButton_Click(object sender, EventArgs e)
        {
            //Opens a file dialog and if the result is ok
            if (seriesTitleOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Sets the path to the textbox
                seriesTitleTextBox.Text = seriesTitleOpenFileDialog.FileName;
            }
            else
            {
                //Displays a message telling the user to select a file
                MessageBox.Show("Please select a text file");
            }
        }

        private void seriesRatingFileButton_Click(object sender, EventArgs e)
        {
            //Opens a file dialog and if the result is ok
            if (seriesRatingOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Sets the path to the textbox
                ratingFileTextBox.Text = seriesRatingOpenFileDialog.FileName;
            }
            else
            {
                //Displays a message telling the user to select a file
                MessageBox.Show("Please select a text file");
            }
        }

        private void seriesCoverFileButton_Click(object sender, EventArgs e)
        {
            //Opens a file dialog and if the result is ok
            if (seriesCoverOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Sets the path to the textbox
                coverFileTextBox.Text = seriesCoverOpenFileDialog.FileName;
            }
            else
            {
                //Displays a message telling the user to select a file
                MessageBox.Show("Please select a text file");
            }
        }

        private void preTitleFileButton_Click(object sender, EventArgs e)
        {
            //Opens a file dialog and if the result is ok
            if (preOrderTitleOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Sets the path to the textbox
                preTitlesTextBox.Text = preOrderTitleOpenFileDialog.FileName;
            }
            else
            {
                //Displays a message telling the user to select a file
                MessageBox.Show("Please select a text file");
            }
        }

        private void prePricingFileButton_Click(object sender, EventArgs e)
        {
            //Opens a file dialog and if the result is ok
            if (preOrderPricingOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Sets the path to the textbox
                pricingFileTextBox.Text = preOrderPricingOpenFileDialog.FileName;
            }
            else
            {
                //Displays a message telling the user to select a file
                MessageBox.Show("Please select a text file");
            }
        }

        private void preImagesFileButton_Click(object sender, EventArgs e)
        {
            //Opens a file dialog and if the result is ok
            if (preOrderImageOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Sets the path to the textbox
                imageFileTextBox.Text = preOrderImageOpenFileDialog.FileName;
            }
            else
            {
                //Displays a message telling the user to select a file
                MessageBox.Show("Please select a text file");
            }
        }
    }
}
