using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeodesicCalculator
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        
        private void slopeButton_Click_1(object sender, EventArgs e)
        {
            Slope s = new Slope();
            s.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void straigthCutButton_Click(object sender, EventArgs e)
        {
            StraightCut c = new StraightCut();
            c.Show();
            this.Hide();
        }
    }
}
