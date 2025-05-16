using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class BodyTypeCalculator : Form
    {
        private string bodyType;
        public BodyTypeCalculator()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlCalculator.Visible = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double shoulderSize = Convert.ToDouble(txtShoulderSize.Text);
            Double bustSize = Convert.ToDouble(txtBustSize.Text);
            Double waistSize = Convert.ToDouble(txtWaistSize.Text);
            Double hipSize = Convert.ToDouble(txtHipSize.Text);
            double waistToBustRatio = waistSize / bustSize;
            double waistToHipRatio = waistSize / hipSize;
            double bustHipDifference = Math.Abs(bustSize - hipSize);
            double bustHipPercentage = bustHipDifference / Math.Max(bustSize, hipSize) * 100;
            string bodyShape = "Rectangle";

            if (waistToBustRatio <= 0.75 && waistToHipRatio <= 0.75 && bustHipPercentage <= 5)
            {
                bodyShape = "Hourglass";
            }

            else if (hipSize > bustSize && bustHipPercentage >= 5 && waistToHipRatio >= 0.75)
            {
                bodyShape = "Pear";
            }

            else if (waistToBustRatio >= 0.80 && waistToHipRatio >= 0.80)
            {
                bodyShape = "Apple";
            }

            else if (waistToBustRatio >= 0.75 && waistToHipRatio >= 0.75 && bustHipPercentage <= 5)
            {
                bodyShape = "Rectangle";
            }

            else if (bustSize > hipSize && bustHipPercentage >= 5 && waistToBustRatio <= 0.75)
            {
                bodyShape = "Inverted Triangle";
            }

        lbYourShape.Visible = true;
            lbYourShape.Text = "Your body shape is " + bodyShape;
            lbReminder.Visible = true;
            btnPlayQuiz.Visible = true;
            lbStyleReminder.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtShoulderSize.Clear();
            txtBustSize.Clear();
            txtWaistSize.Clear();
            txtHipSize.Clear();
            lbYourShape.Visible = false;
            lbReminder.Visible = false;
            btnPlayQuiz.Visible = false;
            lbStyleReminder.Visible = false;
        }
        private void btnPlayQuiz_Click(object sender, EventArgs e)
        {
            StyleQuiz quizform = new StyleQuiz();
            quizform.Show();
            this.Hide();
        }
    }
}
