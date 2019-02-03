namespace GraysonBeam_Mass_Area_Calculator_GUI_HW2
{
    partial class Form1
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
            this.SphereGroupBox = new System.Windows.Forms.GroupBox();
            this.SphereTrackSelectionLabel = new System.Windows.Forms.Label();
            this.SphereResetButton = new System.Windows.Forms.Button();
            this.SphereCalculateButton = new System.Windows.Forms.Button();
            this.SphereTrackBarLabel = new System.Windows.Forms.Label();
            this.SphereTrackBar = new System.Windows.Forms.TrackBar();
            this.SphereDensityLabel = new System.Windows.Forms.Label();
            this.SphereDensityTextBox = new System.Windows.Forms.TextBox();
            this.SphereRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CubeGroupBox = new System.Windows.Forms.GroupBox();
            this.CubeTrackSelectionLabel = new System.Windows.Forms.Label();
            this.CubeResetButton = new System.Windows.Forms.Button();
            this.CubeCalculateButton = new System.Windows.Forms.Button();
            this.CubeTrackBarLabel = new System.Windows.Forms.Label();
            this.CubeTrackBar = new System.Windows.Forms.TrackBar();
            this.CubeDensityLabel = new System.Windows.Forms.Label();
            this.CubeDensityTextBox = new System.Windows.Forms.TextBox();
            this.CubeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SphereGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SphereTrackBar)).BeginInit();
            this.CubeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CubeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SphereGroupBox
            // 
            this.SphereGroupBox.Controls.Add(this.SphereTrackSelectionLabel);
            this.SphereGroupBox.Controls.Add(this.SphereResetButton);
            this.SphereGroupBox.Controls.Add(this.SphereCalculateButton);
            this.SphereGroupBox.Controls.Add(this.SphereTrackBarLabel);
            this.SphereGroupBox.Controls.Add(this.SphereTrackBar);
            this.SphereGroupBox.Controls.Add(this.SphereDensityLabel);
            this.SphereGroupBox.Controls.Add(this.SphereDensityTextBox);
            this.SphereGroupBox.Controls.Add(this.SphereRichTextBox);
            this.SphereGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SphereGroupBox.Name = "SphereGroupBox";
            this.SphereGroupBox.Size = new System.Drawing.Size(373, 426);
            this.SphereGroupBox.TabIndex = 0;
            this.SphereGroupBox.TabStop = false;
            this.SphereGroupBox.Text = "Sphere Group Box";
            // 
            // SphereTrackSelectionLabel
            // 
            this.SphereTrackSelectionLabel.AutoSize = true;
            this.SphereTrackSelectionLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SphereTrackSelectionLabel.Location = new System.Drawing.Point(314, 101);
            this.SphereTrackSelectionLabel.Name = "SphereTrackSelectionLabel";
            this.SphereTrackSelectionLabel.Size = new System.Drawing.Size(32, 17);
            this.SphereTrackSelectionLabel.TabIndex = 7;
            this.SphereTrackSelectionLabel.Text = "100";
            // 
            // SphereResetButton
            // 
            this.SphereResetButton.BackColor = System.Drawing.Color.LightCoral;
            this.SphereResetButton.Location = new System.Drawing.Point(0, 171);
            this.SphereResetButton.Name = "SphereResetButton";
            this.SphereResetButton.Size = new System.Drawing.Size(367, 37);
            this.SphereResetButton.TabIndex = 6;
            this.SphereResetButton.Text = "Clear";
            this.SphereResetButton.UseVisualStyleBackColor = false;
            // 
            // SphereCalculateButton
            // 
            this.SphereCalculateButton.Location = new System.Drawing.Point(0, 214);
            this.SphereCalculateButton.Name = "SphereCalculateButton";
            this.SphereCalculateButton.Size = new System.Drawing.Size(367, 37);
            this.SphereCalculateButton.TabIndex = 5;
            this.SphereCalculateButton.Text = "Calculate";
            this.SphereCalculateButton.UseVisualStyleBackColor = true;
            // 
            // SphereTrackBarLabel
            // 
            this.SphereTrackBarLabel.AutoSize = true;
            this.SphereTrackBarLabel.Location = new System.Drawing.Point(14, 84);
            this.SphereTrackBarLabel.Name = "SphereTrackBarLabel";
            this.SphereTrackBarLabel.Size = new System.Drawing.Size(313, 34);
            this.SphereTrackBarLabel.TabIndex = 4;
            this.SphereTrackBarLabel.Text = "Please use the slider to select the radius for the \r\nsphere below:";
            this.SphereTrackBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SphereTrackBar
            // 
            this.SphereTrackBar.Location = new System.Drawing.Point(6, 121);
            this.SphereTrackBar.Maximum = 100;
            this.SphereTrackBar.Minimum = 1;
            this.SphereTrackBar.Name = "SphereTrackBar";
            this.SphereTrackBar.Size = new System.Drawing.Size(361, 56);
            this.SphereTrackBar.TabIndex = 3;
            this.SphereTrackBar.Value = 1;
            // 
            // SphereDensityLabel
            // 
            this.SphereDensityLabel.AutoSize = true;
            this.SphereDensityLabel.Location = new System.Drawing.Point(6, 34);
            this.SphereDensityLabel.Name = "SphereDensityLabel";
            this.SphereDensityLabel.Size = new System.Drawing.Size(363, 17);
            this.SphereDensityLabel.TabIndex = 2;
            this.SphereDensityLabel.Text = "Please enter the density in the box below for the sphere:\r\n";
            // 
            // SphereDensityTextBox
            // 
            this.SphereDensityTextBox.Location = new System.Drawing.Point(0, 54);
            this.SphereDensityTextBox.Name = "SphereDensityTextBox";
            this.SphereDensityTextBox.Size = new System.Drawing.Size(373, 22);
            this.SphereDensityTextBox.TabIndex = 1;
            // 
            // SphereRichTextBox
            // 
            this.SphereRichTextBox.Location = new System.Drawing.Point(7, 257);
            this.SphereRichTextBox.Name = "SphereRichTextBox";
            this.SphereRichTextBox.Size = new System.Drawing.Size(360, 163);
            this.SphereRichTextBox.TabIndex = 0;
            this.SphereRichTextBox.Text = "";
            // 
            // CubeGroupBox
            // 
            this.CubeGroupBox.Controls.Add(this.CubeTrackSelectionLabel);
            this.CubeGroupBox.Controls.Add(this.CubeResetButton);
            this.CubeGroupBox.Controls.Add(this.CubeCalculateButton);
            this.CubeGroupBox.Controls.Add(this.CubeTrackBarLabel);
            this.CubeGroupBox.Controls.Add(this.CubeTrackBar);
            this.CubeGroupBox.Controls.Add(this.CubeDensityLabel);
            this.CubeGroupBox.Controls.Add(this.CubeDensityTextBox);
            this.CubeGroupBox.Controls.Add(this.CubeRichTextBox);
            this.CubeGroupBox.Location = new System.Drawing.Point(407, 12);
            this.CubeGroupBox.Name = "CubeGroupBox";
            this.CubeGroupBox.Size = new System.Drawing.Size(381, 426);
            this.CubeGroupBox.TabIndex = 1;
            this.CubeGroupBox.TabStop = false;
            this.CubeGroupBox.Text = "Cube Group Box";
            // 
            // CubeTrackSelectionLabel
            // 
            this.CubeTrackSelectionLabel.AutoSize = true;
            this.CubeTrackSelectionLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CubeTrackSelectionLabel.Location = new System.Drawing.Point(327, 101);
            this.CubeTrackSelectionLabel.Name = "CubeTrackSelectionLabel";
            this.CubeTrackSelectionLabel.Size = new System.Drawing.Size(32, 17);
            this.CubeTrackSelectionLabel.TabIndex = 8;
            this.CubeTrackSelectionLabel.Text = "100";
            // 
            // CubeResetButton
            // 
            this.CubeResetButton.BackColor = System.Drawing.Color.LightCoral;
            this.CubeResetButton.Location = new System.Drawing.Point(9, 171);
            this.CubeResetButton.Name = "CubeResetButton";
            this.CubeResetButton.Size = new System.Drawing.Size(367, 37);
            this.CubeResetButton.TabIndex = 7;
            this.CubeResetButton.Text = "Clear";
            this.CubeResetButton.UseVisualStyleBackColor = false;
            // 
            // CubeCalculateButton
            // 
            this.CubeCalculateButton.Location = new System.Drawing.Point(8, 214);
            this.CubeCalculateButton.Name = "CubeCalculateButton";
            this.CubeCalculateButton.Size = new System.Drawing.Size(367, 37);
            this.CubeCalculateButton.TabIndex = 8;
            this.CubeCalculateButton.Text = "Calculate";
            this.CubeCalculateButton.UseVisualStyleBackColor = true;
            // 
            // CubeTrackBarLabel
            // 
            this.CubeTrackBarLabel.AutoSize = true;
            this.CubeTrackBarLabel.Location = new System.Drawing.Point(6, 84);
            this.CubeTrackBarLabel.Name = "CubeTrackBarLabel";
            this.CubeTrackBarLabel.Size = new System.Drawing.Size(294, 34);
            this.CubeTrackBarLabel.TabIndex = 5;
            this.CubeTrackBarLabel.Text = "Please use the slider to select the side length\r\nfor the cube below:";
            this.CubeTrackBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CubeTrackBar
            // 
            this.CubeTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.CubeTrackBar.Location = new System.Drawing.Point(9, 121);
            this.CubeTrackBar.Maximum = 100;
            this.CubeTrackBar.Minimum = 1;
            this.CubeTrackBar.Name = "CubeTrackBar";
            this.CubeTrackBar.Size = new System.Drawing.Size(366, 56);
            this.CubeTrackBar.TabIndex = 4;
            this.CubeTrackBar.Value = 1;
            // 
            // CubeDensityLabel
            // 
            this.CubeDensityLabel.AutoSize = true;
            this.CubeDensityLabel.Location = new System.Drawing.Point(20, 34);
            this.CubeDensityLabel.Name = "CubeDensityLabel";
            this.CubeDensityLabel.Size = new System.Drawing.Size(350, 17);
            this.CubeDensityLabel.TabIndex = 3;
            this.CubeDensityLabel.Text = "Please enter the density in the box below for the cube:\r\n";
            // 
            // CubeDensityTextBox
            // 
            this.CubeDensityTextBox.Location = new System.Drawing.Point(0, 54);
            this.CubeDensityTextBox.Name = "CubeDensityTextBox";
            this.CubeDensityTextBox.Size = new System.Drawing.Size(381, 22);
            this.CubeDensityTextBox.TabIndex = 2;
            // 
            // CubeRichTextBox
            // 
            this.CubeRichTextBox.Location = new System.Drawing.Point(7, 257);
            this.CubeRichTextBox.Name = "CubeRichTextBox";
            this.CubeRichTextBox.Size = new System.Drawing.Size(374, 163);
            this.CubeRichTextBox.TabIndex = 0;
            this.CubeRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CubeGroupBox);
            this.Controls.Add(this.SphereGroupBox);
            this.Name = "Form1";
            this.Text = "GeometricSolids";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SphereGroupBox.ResumeLayout(false);
            this.SphereGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SphereTrackBar)).EndInit();
            this.CubeGroupBox.ResumeLayout(false);
            this.CubeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CubeTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SphereGroupBox;
        private System.Windows.Forms.GroupBox CubeGroupBox;
        private System.Windows.Forms.TrackBar SphereTrackBar;
        private System.Windows.Forms.Label SphereDensityLabel;
        private System.Windows.Forms.TextBox SphereDensityTextBox;
        private System.Windows.Forms.RichTextBox SphereRichTextBox;
        private System.Windows.Forms.TrackBar CubeTrackBar;
        private System.Windows.Forms.Label CubeDensityLabel;
        private System.Windows.Forms.TextBox CubeDensityTextBox;
        private System.Windows.Forms.RichTextBox CubeRichTextBox;
        private System.Windows.Forms.Button SphereResetButton;
        private System.Windows.Forms.Button SphereCalculateButton;
        private System.Windows.Forms.Label SphereTrackBarLabel;
        private System.Windows.Forms.Button CubeResetButton;
        private System.Windows.Forms.Button CubeCalculateButton;
        private System.Windows.Forms.Label CubeTrackBarLabel;
        private System.Windows.Forms.Label SphereTrackSelectionLabel;
        private System.Windows.Forms.Label CubeTrackSelectionLabel;
    }
}

