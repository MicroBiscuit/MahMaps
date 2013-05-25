namespace MahMaps.Forms
{
    partial class NewMapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMapForm));
            this.MapNameLabel = new System.Windows.Forms.Label();
            this.MapHeightLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MapNameTextBox = new System.Windows.Forms.TextBox();
            this.MapHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.TileHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.MapWidthLabel = new System.Windows.Forms.Label();
            this.TileWidthLabel = new System.Windows.Forms.Label();
            this.MapWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.TileWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MapHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileWidthNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // MapNameLabel
            // 
            this.MapNameLabel.AutoSize = true;
            this.MapNameLabel.Location = new System.Drawing.Point(19, 16);
            this.MapNameLabel.Name = "MapNameLabel";
            this.MapNameLabel.Size = new System.Drawing.Size(62, 13);
            this.MapNameLabel.TabIndex = 0;
            this.MapNameLabel.Text = "Map Name:";
            // 
            // MapHeightLabel
            // 
            this.MapHeightLabel.AutoSize = true;
            this.MapHeightLabel.Location = new System.Drawing.Point(16, 46);
            this.MapHeightLabel.Name = "MapHeightLabel";
            this.MapHeightLabel.Size = new System.Drawing.Size(65, 13);
            this.MapHeightLabel.TabIndex = 1;
            this.MapHeightLabel.Text = "Map Height:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tile Height: ";
            // 
            // MapNameTextBox
            // 
            this.MapNameTextBox.Location = new System.Drawing.Point(82, 13);
            this.MapNameTextBox.Name = "MapNameTextBox";
            this.MapNameTextBox.Size = new System.Drawing.Size(249, 20);
            this.MapNameTextBox.TabIndex = 3;
            // 
            // MapHeightNumeric
            // 
            this.MapHeightNumeric.Location = new System.Drawing.Point(85, 44);
            this.MapHeightNumeric.Name = "MapHeightNumeric";
            this.MapHeightNumeric.Size = new System.Drawing.Size(78, 20);
            this.MapHeightNumeric.TabIndex = 4;
            this.MapHeightNumeric.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // TileHeightNumeric
            // 
            this.TileHeightNumeric.Location = new System.Drawing.Point(85, 76);
            this.TileHeightNumeric.Name = "TileHeightNumeric";
            this.TileHeightNumeric.Size = new System.Drawing.Size(78, 20);
            this.TileHeightNumeric.TabIndex = 5;
            this.TileHeightNumeric.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // MapWidthLabel
            // 
            this.MapWidthLabel.AutoSize = true;
            this.MapWidthLabel.Location = new System.Drawing.Point(188, 46);
            this.MapWidthLabel.Name = "MapWidthLabel";
            this.MapWidthLabel.Size = new System.Drawing.Size(62, 13);
            this.MapWidthLabel.TabIndex = 6;
            this.MapWidthLabel.Text = "Map Width:";
            // 
            // TileWidthLabel
            // 
            this.TileWidthLabel.AutoSize = true;
            this.TileWidthLabel.Location = new System.Drawing.Point(188, 80);
            this.TileWidthLabel.Name = "TileWidthLabel";
            this.TileWidthLabel.Size = new System.Drawing.Size(58, 13);
            this.TileWidthLabel.TabIndex = 7;
            this.TileWidthLabel.Text = "Tile Width:";
            // 
            // MapWidthNumeric
            // 
            this.MapWidthNumeric.Location = new System.Drawing.Point(256, 44);
            this.MapWidthNumeric.Name = "MapWidthNumeric";
            this.MapWidthNumeric.Size = new System.Drawing.Size(75, 20);
            this.MapWidthNumeric.TabIndex = 8;
            this.MapWidthNumeric.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // TileWidthNumeric
            // 
            this.TileWidthNumeric.Location = new System.Drawing.Point(256, 76);
            this.TileWidthNumeric.Name = "TileWidthNumeric";
            this.TileWidthNumeric.Size = new System.Drawing.Size(75, 20);
            this.TileWidthNumeric.TabIndex = 9;
            this.TileWidthNumeric.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(19, 102);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(97, 37);
            this.OkButton.TabIndex = 10;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(191, 102);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(97, 37);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 146);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.TileWidthNumeric);
            this.Controls.Add(this.MapWidthNumeric);
            this.Controls.Add(this.TileWidthLabel);
            this.Controls.Add(this.MapWidthLabel);
            this.Controls.Add(this.TileHeightNumeric);
            this.Controls.Add(this.MapHeightNumeric);
            this.Controls.Add(this.MapNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MapHeightLabel);
            this.Controls.Add(this.MapNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewMapForm";
            this.Text = "New Map";
            ((System.ComponentModel.ISupportInitialize)(this.MapHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileWidthNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MapNameLabel;
        private System.Windows.Forms.Label MapHeightLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MapNameTextBox;
        private System.Windows.Forms.NumericUpDown MapHeightNumeric;
        private System.Windows.Forms.NumericUpDown TileHeightNumeric;
        private System.Windows.Forms.Label MapWidthLabel;
        private System.Windows.Forms.Label TileWidthLabel;
        private System.Windows.Forms.NumericUpDown MapWidthNumeric;
        private System.Windows.Forms.NumericUpDown TileWidthNumeric;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}