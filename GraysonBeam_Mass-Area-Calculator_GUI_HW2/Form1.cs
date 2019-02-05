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
        public const double FourOverThree = 1.33D;
        public const double PowerOfTwo = 2.0;
        public const double PowerOfThree = 3.0;
        public Form1()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // OOF
        }

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

            double volume = FourOverThree * Math.Pow(radius, PowerOfThree);
            double surfaceArea = 4 * (Math.PI) * Math.Pow(radius, PowerOfTwo);


            this.SphereRichTextBox.Text = $@"The Volume of the Sphere is: {volume:F2}g {Environment.NewLine}
                                          The Surface Area is: {surfaceArea:F2}cm^2";
        }

        private void SphereResetButton_Click(object sender, EventArgs e)
        {
            this.SphereDensityTextBox.Clear();
            this.SphereDensityTextBox.BackColor = Color.White;
            this.SphereRichTextBox.Clear();
            this.SphereDensityTextBox.Focus();
        }

        private void SphereTrackBar_Scroll(object sender, EventArgs e)
        {
            double radius = SphereTrackBar.Value;
            this.SphereTrackSelectionLabel.Text = $@"{radius:F2}";
        }

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

            double Volume = Math.Pow(SideLength, PowerOfThree);
            double Mass = Volume * density;
            double SurfaceArea = (SideLength * SideLength) * 6.0;

            this.CubeRichTextBox.Text = $@"The Volume of the cube is: {Volume:F2}cm^3 {Environment.NewLine}
                                        The Surface Area is: {SurfaceArea:F2}cm^2 {Environment.NewLine}
                                        The Mass is: {Mass:F2}g";
        }

        private void CubeTrackBar_Scroll(object sender, EventArgs e)
        {
            double SideLength = CubeTrackBar.Value;
            this.CubeTrackSelectionLabel.Text = $@"{SideLength:F2}";
        }

        private void CubeResetButton_Click(object sender, EventArgs e)
        {
            this.CubeDensityTextBox.Clear();
            this.CubeDensityTextBox.BackColor = Color.White;
            this.CubeRichTextBox.Clear();
            this.CubeDensityTextBox.Focus();
        }
    }
}
