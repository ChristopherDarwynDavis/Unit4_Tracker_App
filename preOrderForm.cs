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
 * Date: 11.30.2021
 * Description: This form pulls and updates data from a set of text files to display a users saved
 * pre-orders with pricing and a cover image.
 */
namespace DavCFinalProject
{
    public partial class preOrderForm : Form
    {
        //Creating a FileLocation object
        FileLocation files = new FileLocation();
        //Creating a string
        private string orderImages;
        //Creating new strings for file locations
        private string titlesFile;
        private string pricesFile;
        private string imagesFile;
        public preOrderForm()
        {
            InitializeComponent();

            //Setting seriesWatchedDataGridView values to false to use the default values
            preOrderDataGridView.AllowUserToResizeColumns = false;
            preOrderDataGridView.EnableHeadersVisualStyles = false;
            preOrderDataGridView.DefaultCellStyle.BackColor = Color.FromArgb(20,20,20);
            preOrderDataGridView.DefaultCellStyle.Font = new Font("MS UI Gothic", 12f, FontStyle.Regular);
            preOrderDataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(0,100,112);
            preOrderDataGridView.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            preOrderDataGridView.RowHeadersVisible = false;
            preOrderDataGridView.ScrollBars = ScrollBars.Vertical;
            //Setting colors and font styles for the headers of columns
            preOrderDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 50, 60);
            preOrderDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("MS UI Gothic", 16f, FontStyle.Regular);
            preOrderDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 100, 112);
            //Generating file locations
            files.Gen();
            //Setting the file locations to strings
            titlesFile = files.PreOrderTitle();
            pricesFile = files.PreOrderPrice();
            imagesFile = files.PreOrderImages();
            //Calls the update data method
            UpdateData();
        }

        private void UpdateData()
        {
            //Try following
            try
            {
                //Creating Cover object called images
                Cover cover = new Cover();
                //Creating a list bitmap called images and giving it the values from cover.pull
                List<Bitmap> images = cover.Pull(imagesFile, 100, 150);
                //Creating an int called index
                int index = 0;
                //Clears the DataGridView 
                preOrderDataGridView.Rows.Clear();
                //Creating StreamReader objects and opening them
                StreamReader inputOrder;
                inputOrder = File.OpenText(titlesFile);
                StreamReader inputPrice;
                inputPrice = File.OpenText(pricesFile);

                //While not at the end of files
                while (!inputOrder.EndOfStream && !inputPrice.EndOfStream)
                {
                    //Adds a row with the data from inputOrder file, inputPrice file, and the pre-order images
                    preOrderDataGridView.Rows.Add(inputOrder.ReadLine(),
                    double.Parse(inputPrice.ReadLine()).ToString("C"), images[index]);
                    //Adds 1 to index
                    index++;
                }
                //Closing the open text files
                inputOrder.Close();
                inputPrice.Close();
            }
            catch
            {

            }
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            //If the user selects a valid file
            if (preOrderOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Sets the image selected to a new bitmap called preOrderImages
                orderImages = preOrderOpenFileDialog.FileName;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Creating a double
            double price;
            //Creating StreamWriter objects
            StreamWriter outputOrder;
            outputOrder = File.AppendText(titlesFile);
            StreamWriter outputPrice;
            outputPrice = File.AppendText(pricesFile);
            StreamWriter outputImage;
            outputImage = File.AppendText(imagesFile);

            //Checks if there is text in orderTitleTextBox and that the value entered in priceTextBox is a number
            if (orderTitleTextBox.Text != "" && double.TryParse(priceTextBox.Text,out price))
            {
                // If the orderImages string is empty it will give it
                // the default value otherwise if it contains a string
                // it will write to the files
                if (orderImages == "")
                {
                    orderImages = @"Sample Images\placeholder.jpg";
                    //Saving info to file
                    outputImage.WriteLine(orderImages);
                    outputOrder.WriteLine(orderTitleTextBox.Text);
                    outputPrice.WriteLine(priceTextBox.Text);
                }
                else
                {
                    //Saving info to file
                    outputImage.WriteLine(orderImages);
                    outputOrder.WriteLine(orderTitleTextBox.Text);
                    outputPrice.WriteLine(priceTextBox.Text);
                }
            }
            else
            {
                //Displays a message box
                MessageBox.Show("Please enter a title and valid price");
            }

            //Closes the open output files
            outputOrder.Close();
            outputPrice.Close();
            outputImage.Close();
            //Clears the text field of orderTitleTextBox and priceTextBox
            orderTitleTextBox.Text = "";
            priceTextBox.Text = "";
            //Clearing orderImages
            orderImages = "";
            //Calls the UpdateData method
            UpdateData();
        }
    }
}
