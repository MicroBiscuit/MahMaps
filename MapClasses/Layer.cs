using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MahMaps.MapClasses
{
    public class Layer
    {
        //Declare the layer array
        public int[,] layer;

        //Declare map and tile size variables
        int mapWidth, mapHeight, tileWidth, tileHeight;

        public Layer(int mapWidth, int mapHeight, int tileWidth, int tileHeight)
        {
            //Initializeing instance variables
            this.mapHeight = mapHeight;
            this.mapWidth = mapWidth;
            this.tileHeight = tileHeight;
            this.tileWidth = tileWidth;
            layer = new int[mapWidth, mapHeight];
        }

        public void SetTiles(int selectedTile)
        {
            //Declare local variables
            Vector2 mouse;
            double mouseMapX;
            double mouseMapY;

            //Get the mouse position on the left click
            MouseState currMouseState = Mouse.GetState();

            try
            {
                //Check for tile laying
                if (currMouseState.LeftButton == ButtonState.Pressed)
                {
                    mouse = new Vector2(currMouseState.X, currMouseState.Y);
                    mouseMapX = ((int)mouse.X / tileWidth) + Game1.drawOffset.X;
                    mouseMapY = ((int)mouse.Y / tileHeight) + Game1.drawOffset.Y;
                    if (mouseMapX < mapWidth && mouseMapY < mapHeight && mouseMapX >= 0 && mouseMapY >= 0)
                    {
                        layer[(int)mouseMapX, (int)mouseMapY] = selectedTile;
                    }
                }

                //Check for tile deleting
                if (currMouseState.RightButton == ButtonState.Pressed)
                {
                    mouse = new Vector2(currMouseState.X, currMouseState.Y);
                    mouseMapX = ((int)mouse.X / tileWidth) + Game1.drawOffset.X;
                    mouseMapY = ((int)mouse.Y / tileHeight) + Game1.drawOffset.Y;
                    if (mouseMapX < mapWidth && mouseMapY < mapHeight && mouseMapX >= 0 && mouseMapY >= 0)
                    {
                        layer[(int)mouseMapX, (int)mouseMapY] = 0;
                    }
                }
            }
            catch
            {
                ;//Empty
            }
        }

        public void SaveLayer(System.IO.StreamWriter objWriter)
        {
            try
            {
                //Write the Layer to the text file
                for (int i = 0; i < mapWidth; ++i)
                {
                    for (int j = 0; j < mapHeight; ++j)
                    {
                        objWriter.WriteLine(layer[i, j]);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("There was an error saving the tiles.\nError:" + ex);
            }
        }

        public void LoadLayer(System.IO.StreamReader objReader)
        {
            try
            {
                //Populate the layer arry
                for (int i = 0; i < mapWidth; ++i)
                {
                    for (int j = 0; j < mapHeight; ++j)
                    {
                        layer[i, j] = Convert.ToInt32(objReader.ReadLine());
                    }
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("There was an error loading the tiles.\nError:" + ex);
            }
        }
    }
}
