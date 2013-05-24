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
    public partial class NewMapForm : Form
    {
        //Declare map and tile dimensions
        public int mapHeight;
        public int mapWidth;
        public int tileHeight;
        public int tileWidth;

        //Declare the map name
        public String mapName;

        public NewMapForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //Get input from the form
            mapName = MapNameTextBox.Text;
            mapHeight = Convert.ToInt32(MapHeightNumeric.Value);
            mapWidth = Convert.ToInt32(MapWidthNumeric.Value);
            tileHeight = Convert.ToInt32(TileHeightNumeric.Value);
            tileWidth = Convert.ToInt32(TileWidthNumeric.Value);

            //Set the dialog result to ok
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Cancel the input
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
