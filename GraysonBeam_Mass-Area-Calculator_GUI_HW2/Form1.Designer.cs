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
            this.SphereGroupBox.Location = new System.Drawing.Point(9, 10);
            this.SphereGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SphereGroupBox.Name = "SphereGroupBox";
            this.SphereGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SphereGroupBox.Size = new System.Drawing.Size(280, 346);
            this.SphereGroupBox.TabIndex = 0;
            this.SphereGroupBox.TabStop = false;
            this.SphereGroupBox.Text = "Sphere Group Box";
            // 
            // SphereTrackSelectionLabel
            // 
            this.SphereTrackSelectionLabel.AutoSize = true;
            this.SphereTrackSelectionLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SphereTrackSelectionLabel.Location = new System.Drawing.Point(236, 82);
            this.SphereTrackSelectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SphereTrackSelectionLabel.Name = "SphereTrackSelectionLabel";
            this.SphereTrackSelectionLabel.Size = new System.Drawing.Size(25, 13);
            this.SphereTrackSelectionLabel.TabIndex = 7;
            this.SphereTrackSelectionLabel.Text = "100";
            // 
            // SphereResetButton
            // 
            this.SphereResetButton.BackColor = System.Drawing.Color.LightCoral;
            this.SphereResetButton.Location = new System.Drawing.Point(0, 139);
            this.SphereResetButton.Margin = new System.Windows.Forms.Padding(2);
            this.SphereResetButton.Name = "SphereResetButton";
            this.SphereResetButton.Size = new System.Drawing.Size(275, 30);
            this.SphereResetButton.TabIndex = 6;
            this.SphereResetButton.Text = "Clear";
            this.SphereResetButton.UseVisualStyleBackColor = false;
            this.SphereResetButton.Click += new System.EventHandler(this.SphereResetButton_Click);
            // 
            // SphereCalculateButton
            // 
            this.SphereCalculateButton.Location = new System.Drawing.Point(0, 174);
            this.SphereCalculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.SphereCalculateButton.Name = "SphereCalculateButton";
            this.SphereCalculateButton.Size = new System.Drawing.Size(275, 30);
            this.SphereCalculateButton.TabIndex = 5;
            this.SphereCalculateButton.Text = "Calculate";
            this.SphereCalculateButton.UseVisualStyleBackColor = true;
            this.SphereCalculateButton.Click += new System.EventHandler(this.SphereCalculateButton_Click);
            // 
            // SphereTrackBarLabel
            // 
            this.SphereTrackBarLabel.AutoSize = true;
            this.SphereTrackBarLabel.Location = new System.Drawing.Point(10, 68);
            this.SphereTrackBarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SphereTrackBarLabel.Name = "SphereTrackBarLabel";
            this.SphereTrackBarLabel.Size = new System.Drawing.Size(232, 26);
            this.SphereTrackBarLabel.TabIndex = 4;
            this.SphereTrackBarLabel.Text = "Please use the slider to select the radius for the \r\nsphere below:";
            this.SphereTrackBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SphereTrackBar
            // 
            this.SphereTrackBar.Location = new System.Drawing.Point(4, 98);
            this.SphereTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.SphereTrackBar.Maximum = 100;
            this.SphereTrackBar.Minimum = 1;
            this.SphereTrackBar.Name = "SphereTrackBar";
            this.SphereTrackBar.Size = new System.Drawing.Size(271, 45);
            this.SphereTrackBar.TabIndex = 3;
            this.SphereTrackBar.Value = 1;
            this.SphereTrackBar.Scroll += new System.EventHandler(this.SphereTrackBar_Scroll);
            // 
            // SphereDensityLabel
            // 
            this.SphereDensityLabel.AutoSize = true;
            this.SphereDensityLabel.Location = new System.Drawing.Point(4, 28);
            this.SphereDensityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SphereDensityLabel.Name = "SphereDensityLabel";
            this.SphereDensityLabel.Size = new System.Drawing.Size(271, 13);
            this.SphereDensityLabel.TabIndex = 2;
            this.SphereDensityLabel.Text = "Please enter the density in the box below for the sphere:\r\n";
            // 
            // SphereDensityTextBox
            // 
            this.SphereDensityTextBox.Location = new System.Drawing.Point(0, 44);
            this.SphereDensityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SphereDensityTextBox.Name = "SphereDensityTextBox";
            this.SphereDensityTextBox.Size = new System.Drawing.Size(276, 20);
            this.SphereDensityTextBox.TabIndex = 1;
            // 
            // SphereRichTextBox
            // 
            this.SphereRichTextBox.Location = new System.Drawing.Point(5, 209);
            this.SphereRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SphereRichTextBox.Name = "SphereRichTextBox";
            this.SphereRichTextBox.Size = new System.Drawing.Size(271, 133);
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
            this.CubeGroupBox.Location = new System.Drawing.Point(305, 10);
            this.CubeGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.CubeGroupBox.Name = "CubeGroupBox";
            this.CubeGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.CubeGroupBox.Size = new System.Drawing.Size(286, 346);
            this.CubeGroupBox.TabIndex = 1;
            this.CubeGroupBox.TabStop = false;
            this.CubeGroupBox.Text = "Cube Group Box";
            // 
            // CubeTrackSelectionLabel
            // 
            this.CubeTrackSelectionLabel.AutoSize = true;
            this.CubeTrackSelectionLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CubeTrackSelectionLabel.Location = new System.Drawing.Point(245, 82);
            this.CubeTrackSelectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CubeTrackSelectionLabel.Name = "CubeTrackSelectionLabel";
            this.CubeTrackSelectionLabel.Size = new System.Drawing.Size(25, 13);
            this.CubeTrackSelectionLabel.TabIndex = 8;
            this.CubeTrackSelectionLabel.Text = "100";
            // 
            // CubeResetButton
            // 
            this.CubeResetButton.BackColor = System.Drawing.Color.LightCoral;
            this.CubeResetButton.Location = new System.Drawing.Point(7, 139);
            this.CubeResetButton.Margin = new System.Windows.Forms.Padding(2);
            this.CubeResetButton.Name = "CubeResetButton";
            this.CubeResetButton.Size = new System.Drawing.Size(275, 30);
            this.CubeResetButton.TabIndex = 7;
            this.CubeResetButton.Text = "Clear";
            this.CubeResetButton.UseVisualStyleBackColor = false;
            this.CubeResetButton.Click += new System.EventHandler(this.CubeResetButton_Click);
            // 
            // CubeCalculateButton
            // 
            this.CubeCalculateButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CubeCalculateButton.Location = new System.Drawing.Point(6, 174);
            this.CubeCalculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.CubeCalculateButton.Name = "CubeCalculateButton";
            this.CubeCalculateButton.Size = new System.Drawing.Size(275, 30);
            this.CubeCalculateButton.TabIndex = 8;
            this.CubeCalculateButton.Text = "Calculate";
            this.CubeCalculateButton.UseVisualStyleBackColor = true;
            this.CubeCalculateButton.Click += new System.EventHandler(this.CubeCalculateButton_Click);
            // 
            // CubeTrackBarLabel
            // 
            this.CubeTrackBarLabel.AutoSize = true;
            this.CubeTrackBarLabel.Location = new System.Drawing.Point(4, 68);
            this.CubeTrackBarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CubeTrackBarLabel.Name = "CubeTrackBarLabel";
            this.CubeTrackBarLabel.Size = new System.Drawing.Size(219, 26);
            this.CubeTrackBarLabel.TabIndex = 5;
            this.CubeTrackBarLabel.Text = "Please use the slider to select the side length\r\nfor the cube below:";
            this.CubeTrackBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CubeTrackBar
            // 
            this.CubeTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.CubeTrackBar.Location = new System.Drawing.Point(7, 98);
            this.CubeTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.CubeTrackBar.Maximum = 100;
            this.CubeTrackBar.Minimum = 1;
            this.CubeTrackBar.Name = "CubeTrackBar";
            this.CubeTrackBar.Size = new System.Drawing.Size(274, 45);
            this.CubeTrackBar.TabIndex = 4;
            this.CubeTrackBar.Value = 1;
            this.CubeTrackBar.Scroll += new System.EventHandler(this.CubeTrackBar_Scroll);
            // 
            // CubeDensityLabel
            // 
            this.CubeDensityLabel.AutoSize = true;
            this.CubeDensityLabel.Location = new System.Drawing.Point(15, 28);
            this.CubeDensityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CubeDensityLabel.Name = "CubeDensityLabel";
            this.CubeDensityLabel.Size = new System.Drawing.Size(263, 13);
            this.CubeDensityLabel.TabIndex = 3;
            this.CubeDensityLabel.Text = "Please enter the density in the box below for the cube:\r\n";
            // 
            // CubeDensityTextBox
            // 
            this.CubeDensityTextBox.Location = new System.Drawing.Point(0, 44);
            this.CubeDensityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CubeDensityTextBox.Name = "CubeDensityTextBox";
            this.CubeDensityTextBox.Size = new System.Drawing.Size(284, 20);
            this.CubeDensityTextBox.TabIndex = 2;
            // 
            // CubeRichTextBox
            // 
            this.CubeRichTextBox.Location = new System.Drawing.Point(5, 209);
            this.CubeRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CubeRichTextBox.Name = "CubeRichTextBox";
            this.CubeRichTextBox.Size = new System.Drawing.Size(282, 133);
            this.CubeRichTextBox.TabIndex = 0;
            this.CubeRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.CubeGroupBox);
            this.Controls.Add(this.SphereGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
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

