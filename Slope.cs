using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GeodesicCalculator
{
    public partial class Slope : Form
    {
        public Slope()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double h1 = Convert.ToDouble(h1TextBox.Text);
            double h2 = Convert.ToDouble(h2TextBox.Text);
            double s = Convert.ToDouble(sTextBox.Text);

            double slope = Math.Abs((h2 - h1) / s);
            double slopeInPercent = Math.Round((slope * 100), 2);

            slopeTextbox.Text = $"{slopeInPercent.ToString()}%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }
    }
}
