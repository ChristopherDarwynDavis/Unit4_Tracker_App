using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Author: Christopher Davis
 * Date: 11.25.2021
 * Description: This form is the homepage of the tracker program and shows the user
 * the cover images of their pre-orders and series watched.
 */
namespace DavCFinalProject
{
    public partial class dashboardForm : Form
    {
        //Creating a FileLocation object
        FileLocation files = new FileLocation();
        //Creating strings for file locations to save to
        private string seriesCovers;
        //Creating an int for the total number of images
        int imageCount;
        //Creating int's for images displayed
        int imageOne = 0;
        int imageTwo = 1;
        int imageThree = 2;
        int imageFour = 3;
        int imageFive = 4;
        int imageSix = 5;
        //Creating a bitmap list
        List<Bitmap> images;
        public dashboardForm()
        {
            InitializeComponent();
            //Generating file locations
            files.Gen();
            //Setting file locations to strings
            seriesCovers = files.SeriesCover();
            //Try the following on launch
            try
            {
                //Creating a cover object
                Cover cover = new Cover();
                //Giving images bitmap values of cover.Pull
                images = cover.Pull(seriesCovers, 150, 200);
                //Settings images to the display pictureboxs
                coverOnePictureBox.Image = images[imageOne];
                coverTwoPictureBox.Image = images[imageTwo];
                coverThreePictureBox.Image = images[imageThree];
                coverFourPictureBox.Image = images[imageFour];
                coverFivePictureBox.Image = images[imageFive];
                coverSixPictureBox.Image = images[imageSix];
                //Setting imageCount to images.Count - 1
                imageCount = images.Count() - 1;
            }
            catch
            {

            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            // Creating a forward switch for all picture boxes shown
            if (imageOne < imageCount)
            {
                imageOne += 1;
                coverOnePictureBox.Image = images[imageOne];
            }
            else
            {
                imageOne = 0;
                coverOnePictureBox.Image = images[0];
            }

            if (imageTwo < imageCount)
            {
                imageTwo += 1;
                coverTwoPictureBox.Image = images[imageTwo];
            }
            else
            {
                imageTwo = 0;
                coverTwoPictureBox.Image = images[0];
            }

            if (imageThree < imageCount)
            {
                imageThree += 1;
                coverThreePictureBox.Image = images[imageThree];
            }
            else
            {
                imageThree = 0;
                coverThreePictureBox.Image = images[0];
            }

            if (imageFour < imageCount)
            {
                imageFour += 1;
                coverFourPictureBox.Image = images[imageFour];
            }
            else
            {
                imageFour = 0;
                coverFourPictureBox.Image = images[0];
            }

            if (imageFive < imageCount)
            {
                imageFive += 1;
                coverFivePictureBox.Image = images[imageFive];
            }
            else
            {
                imageFive = 0;
                coverFivePictureBox.Image = images[0];
            }

            if (imageSix < imageCount)
            {
                imageSix += 1;
                coverSixPictureBox.Image = images[imageSix];
            }
            else
            {
                imageSix = 0;
                coverSixPictureBox.Image = images[0];
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Creating a forward switch for all picture boxes shown
            if (imageOne > 0)
            {
                imageOne -= 1;
                coverOnePictureBox.Image = images[imageOne];
            }
            else
            {
                imageOne = imageCount;
                coverOnePictureBox.Image = images[imageCount];
            }

            if (imageTwo > 0)
            {
                imageTwo -= 1;
                coverTwoPictureBox.Image = images[imageTwo];
            }
            else
            {
                imageTwo = imageCount;
                coverTwoPictureBox.Image = images[imageCount];
            }

            if (imageThree > 0)
            {
                imageThree -= 1;
                coverThreePictureBox.Image = images[imageThree];
            }
            else
            {
                imageThree = imageCount;
                coverThreePictureBox.Image = images[imageCount];
            }

            if (imageFour > 0)
            {
                imageFour -= 1;
                coverFourPictureBox.Image = images[imageFour];
            }
            else
            {
                imageFour = imageCount;
                coverFourPictureBox.Image = images[imageCount];
            }

            if (imageFive > 0)
            {
                imageFive -= 1;
                coverFivePictureBox.Image = images[imageFive];
            }
            else
            {
                imageFive = imageCount;
                coverFivePictureBox.Image = images[imageCount];
            }

            if (imageSix > 0)
            {
                imageSix -= 1;
                coverSixPictureBox.Image = images[imageSix];
            }
            else
            {
                imageSix = imageCount;
                coverSixPictureBox.Image = images[imageCount];
            }
        }
    }
}
