using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
/* Author: Christopher Davis
 * Date: 12.5.2021
 * Desc: This program creates the cover/images bitmap lists
 */
namespace DavCFinalProject
{
    class Cover
    {
        public List<Bitmap> Pull(string file, int width, int height)
        {
            //Creating a string list
            List<string> path = new List<string>();
            //Creating bitmap list's
            List<Bitmap> create = new List<Bitmap>();
            List<Bitmap> cover = new List<Bitmap>();
            //Try the following
            try
            {
                //Creating a StreamReader object and setting its file
                StreamReader inputFile;
                inputFile = File.OpenText(file);
                //While inputFile is not at the end of the file
                while (!inputFile.EndOfStream)
                {
                    //Adding the paths from inputFile to path string list
                    path.Add(inputFile.ReadLine());
                }
                //While index is less than the number of paths in the path list
                for (int index = 0; index < path.Count(); index++)
                {
                    //Creating a new bitmap from the paths string and adding it
                    //to the create bitmap list
                    create.Add(new Bitmap(path[index]));
                    cover.Add(new Bitmap(create[index], width, height));
                }
                //Closing the inputFile
                inputFile.Close();
            }
            //If any errors occur
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Returning the cover bitmap list
            return (cover);
        }
    }
}
