namespace MahMaps.Forms
{
    partial class NewTileSheetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTileSheetForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TileSheetLocationTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.TileHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.TileWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.LoadTilesetButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TileHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileWidthNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tile Sheet Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tile Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tile Width";
            // 
            // TileSheetLocationTextBox
            // 
            this.TileSheetLocationTextBox.Location = new System.Drawing.Point(119, 13);
            this.TileSheetLocationTextBox.Name = "TileSheetLocationTextBox";
            this.TileSheetLocationTextBox.Size = new System.Drawing.Size(122, 20);
            this.TileSheetLocationTextBox.TabIndex = 3;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(248, 13);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(61, 23);
            this.BrowseButton.TabIndex = 4;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // TileHeightNumeric
            // 
            this.TileHeightNumeric.Location = new System.Drawing.Point(119, 41);
            this.TileHeightNumeric.Name = "TileHeightNumeric";
            this.TileHeightNumeric.Size = new System.Drawing.Size(66, 20);
            this.TileHeightNumeric.TabIndex = 5;
            this.TileHeightNumeric.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // TileWidthNumeric
            // 
            this.TileWidthNumeric.Location = new System.Drawing.Point(119, 69);
            this.TileWidthNumeric.Name = "TileWidthNumeric";
            this.TileWidthNumeric.Size = new System.Drawing.Size(66, 20);
            this.TileWidthNumeric.TabIndex = 6;
            this.TileWidthNumeric.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // LoadTilesetButton
            // 
            this.LoadTilesetButton.Location = new System.Drawing.Point(22, 109);
            this.LoadTilesetButton.Name = "LoadTilesetButton";
            this.LoadTilesetButton.Size = new System.Drawing.Size(75, 23);
            this.LoadTilesetButton.TabIndex = 7;
            this.LoadTilesetButton.Text = "Load Tileset";
            this.LoadTilesetButton.UseVisualStyleBackColor = true;
            this.LoadTilesetButton.Click += new System.EventHandler(this.LoadTilesetButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(119, 109);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NewTileSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 141);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.LoadTilesetButton);
            this.Controls.Add(this.TileWidthNumeric);
            this.Controls.Add(this.TileHeightNumeric);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.TileSheetLocationTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewTileSheetForm";
            this.Text = "Load Tile Sheet";
            ((System.ComponentModel.ISupportInitialize)(this.TileHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileWidthNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TileSheetLocationTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.NumericUpDown TileHeightNumeric;
        private System.Windows.Forms.NumericUpDown TileWidthNumeric;
        private System.Windows.Forms.Button LoadTilesetButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}