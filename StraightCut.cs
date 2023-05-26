using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GeodesicCalculator
{
    public partial class StraightCut : Form
    {
        public StraightCut()
        {
            InitializeComponent();
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            double yA = Convert.ToDouble(yA_TextBox.Text);  //input
            double yB = Convert.ToDouble(yB_TextBox3.Text);

            double xA = Convert.ToDouble(xA_TextBox2.Text);
            double xB = Convert.ToDouble(xB_TextBox6.Text);

            double beta1 = Convert.ToDouble(beta1TextBox5.Text);
            double beta2 = Convert.ToDouble(beta2TextBox4.Text); //to here


            double deltaY = yB - yA;
            double deltaX = xB - xA;

            


            double alphaABTablic = Math.Abs(Math.Atan(deltaY / deltaX) * (200 / Math.PI));
            
            double alphaAB = 0;

            if (deltaY > 0 && deltaX > 0) //First quadrant
            {
                alphaAB = alphaABTablic;
            }
            else if (deltaY > 0 && deltaX < 0) // Second quadrant
            {
                alphaAB = 200 - alphaABTablic;
            }
            else if (deltaY < 0 && deltaX < 0) //Third quadrant
            {
                alphaAB = 200 + alphaABTablic;
            }
            else if (deltaY < 0 && deltaX > 0) //Fourth quadrant
            {
                alphaAB = 400 - alphaABTablic;
            }

            

            double sAB = Math.Round(Math.Sqrt(Math.Pow(deltaY, 2) + Math.Pow(deltaX, 2)), 2);
            

            double alphaBA = 0;

            if (alphaAB > 200)
            {
                alphaBA = alphaAB - 200;
            }
            else
            {
                alphaBA = alphaAB + 200;
            }

            double alphaAP = alphaAB - beta1;
            double alphaBP = alphaBA + beta2;

            //radians = gradians × 0.015708
            double r = 0.015708;

            double beta2R = beta2 * r;
            double beta1R = beta1 * r;
            double beta3R = (beta1 + beta2) * r;

            double sAP = Math.Round((sAB * Math.Sin(beta2R)) / Math.Sin(beta3R), 2);
            double sBP = Math.Round((sAB * Math.Sin(beta1R)) / Math.Sin(beta3R), 2);
            

            double deltaX_AP = Math.Round((sAP * Math.Cos(alphaAP * r)), 2);
            double deltaY_AP = Math.Round((sAP * Math.Sin(alphaAP * r)), 2);
            double deltaX_BP = Math.Round((sBP * Math.Cos(alphaBP * r)), 2);
            double deltaY_BP = Math.Round((sBP * Math.Sin(alphaBP * r)), 2);

            double xPrimP = xA + deltaX_AP;
            double yPrimP = yA + deltaY_AP;

            double xSecondP = xB + deltaX_BP;
            double ySecondP = yB + deltaY_BP;

            //Finally
            //Its not that simple that you think

            double xP = Math.Round((xPrimP + xSecondP) / 2, 2);
            double yP = Math.Round((yPrimP + ySecondP) / 2, 2);

            alfaAB_TextBox12.Text = Math.Round(alphaAB, 4).ToString();
            sAB_TextBox11.Text = sAB.ToString();
            alfaAP_TextBox8.Text = Math.Round(alphaAP, 4).ToString();
            alfaBP_TextBox7.Text = Math.Round(alphaBP , 4).ToString();
            sAP_TextBox10.Text = sAP.ToString();
            sBP_TextBox9.Text = sBP.ToString();
            yP_TextBox13.Text = Math.Round(yP, 2).ToString();
            xP_TextButton.Text = Math.Round(xP, 2).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage mainPage2 = new MainPage();
            mainPage2.Show();
            this.Hide();
        }
    }
}
