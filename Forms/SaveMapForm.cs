using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MahMaps.Forms
{
    public partial class SaveMapForm : Form
    {
        //Declare the save file name
        string saveFileName;

        public SaveMapForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Return the cancel dialog result
            this.DialogResult = DialogResult.Cancel;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            //Open the save file dialog
            saveFileDialog1.Title = "Specify Destination File Name";

            //Set the default filename to the mapName
            saveFileDialog1.FileName = Game1.mapName;

            //Prompt the user before overwriting a file
            saveFileDialog1.OverwritePrompt = true;

            //Set the file name
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFileName = saveFileDialog1.FileName;
                textBox1.Text = saveFileName;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            //Save the map
            if (Game1.tileSheetFileName != null)
            {
                saveFileName = saveFileDialog1.FileName;
                Game1.map.SaveMap(saveFileName);
            }
            else
            {
                MessageBox.Show("You have not loaded a tile sheet.");
            }

            //Return the ok dialog result
            this.DialogResult = DialogResult.OK;
        }
    }
}
