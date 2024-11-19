using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
/* Author: Christopher Davis
 * Date: 12.5.2021
 * Desc: This program pulls the files for titles, images, ratings, and pricing.
 */
namespace DavCFinalProject
{
    class FileLocation
    {
        //Creating a const int
        const int FILES_COUNT = 6;
        //Creating a string array
        string[] files = new string[FILES_COUNT];

        public void Gen()
        {
            //Try the following
            try
            {
                //Creating a StreamReader object
                StreamReader inputFile;
                inputFile = File.OpenText("files.txt");
                //Creating an int
                int index = 0;
                //While not at the end of inputFile 
                while (!inputFile.EndOfStream)
                {
                    //Reads a line from inputFile it passes the it to files array
                    files[index] = inputFile.ReadLine();
                    //Adds one to indexd
                    index++;
                }
                //Closes inputFile
                inputFile.Close();
            }
            catch
            {
                //Displays a message box
                MessageBox.Show("Unable to read or locate location's file");
            }
        }
        public string SeriesTitle()
        {
            //Creating an empty string
            string seriesTitle = "";
            //Try the following
            try
            {
                //Sets the string equal to the corect file path
                seriesTitle = files[0];
            }
            catch
            {
                //Displays a message box
                MessageBox.Show("Location file must be read first");
            }
            //Returning a string thats a path
            return (seriesTitle);
        }

        public string SeriesRating()
        {
            //Creating an empty string
            string seriesRating = "";
            //Try the following
            try
            {
                //Sets the string equal to the corect file path
                seriesRating = files[1];
            }
            catch
            {
                //Displays a message box
                MessageBox.Show("Location file must be read first");
            }
            //Returning a string thats a path
            return (seriesRating);
        }

        public string SeriesCover()
        {
            //Creating an empty string
            string seriesCover = "";
            //Try the following
            try
            {
                //Sets the string equal to the corect file path
                seriesCover = files[2];
            }
            catch
            {
                //Displays a message box
                MessageBox.Show("Location file must be read first");
            }
            //Returning a string thats a path
            return (seriesCover);
        }

        public string PreOrderTitle()
        {
            //Creating an empty string
            string preTitle = "";
            //Try the following
            try
            {
                //Sets the string equal to the corect file path
                preTitle = files[3];
            }
            catch
            {
                //Displays a message box
                MessageBox.Show("Location file must be read first");
            }
            //Returning a string thats a path
            return (preTitle);
        }

        public string PreOrderPrice()
        {
            //Creating an empty string
            string prePrice = "";
            //Try the following
            try
            {
                //Sets the string equal to the corect file path
                prePrice = files[4];
            }
            catch
            {
                //Displays a message box
                MessageBox.Show("Location file must be read first");
            }
            //Returning a string thats a path
            return (prePrice);
        }

        public string PreOrderImages()
        {
            //Creating an empty string
            string preImages = "";
            //Try the following
            try
            {
                //Sets the string equal to the corect file path
                preImages = files[5];
            }
            catch
            {
                //Displays a message box
                MessageBox.Show("Location file must be read first");
            }
            //Returning a string thats a path
            return (preImages);
        }
    }
}
