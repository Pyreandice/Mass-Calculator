using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GraysonBeam_Mass_Area_Calculator_GUI_HW2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The fraction four over three in decimal form.
        /// </summary>
        public const double FourOverThree = 1.33D;

        /// <summary>
        /// The power of two.
        /// </summary>
        public const double PowerOfTwo = 2.0;

        /// <summary>
        /// The power of three.
        /// </summary>
        public const double PowerOfThree = 3.0;

        /// <summary>
        /// The grams to imperial pounds conversion ratio.
        /// </summary>
        public const double ConversionRatio = 0.00220462;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent(); 
        }

        /// <summary>
        /// The form 1_load. Executes on the intital load of the application.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // OOF
        }

        /// <summary>
        /// The sphere calculate button_click.
        /// Validates the user input density and will not let the user
        /// continue untill the user inputs a number greater than 0.
        /// Calculates the mass, volume, and density of a sphere given the density and radius.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void SphereCalculateButton_Click(object sender, EventArgs e)
        {
            double.TryParse(this.SphereDensityTextBox.Text, out double density);
            double radius = SphereTrackBar.Value;

            if (density.CompareTo(0.0) <= 0)
            {
                this.SphereDensityTextBox.Clear();
                this.SphereDensityTextBox.BackColor = Color.PaleVioletRed;
                this.SphereDensityTextBox.Focus();
                return;
            }
            else
            {
                this.SphereDensityTextBox.BackColor = Color.White;
            }

            // Calculate Sphere Volume.
            double volume = FourOverThree * Math.Pow(radius, PowerOfThree);

            // Calculate Sphere Surface Area.
            double surfaceArea = 4 * (Math.PI) * Math.Pow(radius, PowerOfTwo);

            // Calculate Sphere Mass in grams.
            double massGrams = volume * density;

            // Calculate Sphere Mass in Imperial Pounds
            double massPounds = massGrams * ConversionRatio;


            this.SphereRichTextBox.Text = $@"The Volume of the Sphere is: {volume:F2}g^3 
                                          {Environment.NewLine}
                                          The Surface Area is: {surfaceArea:F2}cm^2 
                                          {Environment.NewLine}
                                          The Mass is: {massGrams:F2}g
                                          {Environment.NewLine}
                                          The Mass is: {massPounds:F2}lbs";
        }

        /// <summary>
        /// The sphere reset button_click.
        /// Resets the form environment to allow to user to input new data.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void SphereResetButton_Click(object sender, EventArgs e)
        {
            this.SphereDensityTextBox.Clear();
            this.SphereDensityTextBox.BackColor = Color.White;
            this.SphereRichTextBox.Clear();
            this.SphereDensityTextBox.Focus();
        }

        /// <summary>
        /// The sphere track bar_scroll.
        /// Displays the number at the current position of the track-bar.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void SphereTrackBar_Scroll(object sender, EventArgs e)
        {
            double radius = SphereTrackBar.Value;
            this.SphereTrackSelectionLabel.Text = $@"{radius:F2}";
        }

        /// <summary>
        /// The cube calculate button_click.
        /// Validates the user input density and will not let the user
        /// continue until the user inputs a number greater than 0.
        /// Calculates the mass, volume, and density of a cube given the density and radius.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CubeCalculateButton_Click(object sender, EventArgs e)
        {
            double.TryParse(this.CubeDensityTextBox.Text, out double density);
            double SideLength = CubeTrackBar.Value;

            if (density.CompareTo(0.0) <= 0)
            {
                this.CubeDensityTextBox.Clear();
                this.CubeDensityTextBox.BackColor = Color.PaleVioletRed;
                this.CubeDensityTextBox.Focus();
                return;
            }
            else
            {
                this.CubeDensityTextBox.BackColor = Color.White;
            }

            // Calculate Cube Volume.
            double volume = Math.Pow(SideLength, PowerOfThree);

            // Calculate Cube Surface Area.
            double surfaceArea = (SideLength * SideLength) * 6.0;

            // Calculate Cube Mass in grams.
            double massGrams = volume * density;

            // Calculate Cube Mass in Imperial Pounds.
            double massPounds = massGrams * ConversionRatio;

            this.CubeRichTextBox.Text = $@"The Volume of the cube is: {volume:F2}cm^3 
                                        {Environment.NewLine}
                                        The Surface Area is: {surfaceArea:F2}cm^2 
                                        {Environment.NewLine}
                                        The Mass is: {massGrams:F2}g
                                        {Environment.NewLine}
                                        The Mass is: {massPounds:F2}lbs";
        }

        /// <summary>
        /// The cube track bar_scroll.
        /// Displays the number at the current position of the track-bar.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CubeTrackBar_Scroll(object sender, EventArgs e)
        {
            double SideLength = CubeTrackBar.Value;
            this.CubeTrackSelectionLabel.Text = $@"{SideLength:F2}";
        }

        /// <summary>
        /// The cube reset button_click.
        /// Resets the form environment to allow to user to input new data.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CubeResetButton_Click(object sender, EventArgs e)
        {
            this.CubeDensityTextBox.Clear();
            this.CubeDensityTextBox.BackColor = Color.White;
            this.CubeRichTextBox.Clear();
            this.CubeDensityTextBox.Focus();
        }
    }
}
