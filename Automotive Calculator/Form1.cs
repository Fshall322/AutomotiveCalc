using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive_Calculator
{
    public partial class Form1 : Form
    {
        double totalCost, taxTotal,costTotal, taxTotal2, costTotal2, answer1, answer2, answer3 = 0, answer4 = 0, num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            BoxCalc();
            taxCalc(answer3, answer4, taxTotal,taxTotal2, costTotal);
            totalCostCalc( totalCost, costTotal, answer3 , answer4);
        }

        private double BoxCalc()
        {
           

            if (OilChngBox.Checked == true)
            {
                num1 = 25.00;
            }

            if (RadFlushBox.Checked == true)
            {
                num2 = 45.00;
            }

            if (TransFlushBox.Checked == true)
            {
                num3 = 80.00;
            }

            if (inspectionBox.Checked == true)
            {
                num4 = 30.00;
            }
            if (TireRotaBox.Checked == true)
            {
                num5 = 25.00;
            }

            if (muffReplaceBox.Checked == true)
            {
                num6 = 125.00;
            }

            answer1 = num1 + num2 + num3 + num4 + num5 + num6;
            answer2 = double.Parse(totalLaborText.Text) * 20;
            answer3 = answer1 + answer2;
            answer4 = double.Parse(partsCostText.Text);
            partsBox.Text = answer4.ToString("c");
            servLaborText.Text = answer3.ToString("c");
            return answer3;
        }

        public double taxCalc(double answer3, double answer4, double taxTotal, double taxTotal2, double costTotal)
        {
            taxTotal = answer3 + answer4;
            taxTotal2 = answer3 + answer4 * 1.06;
            costTotal = taxTotal2 - taxTotal;
            taxText.Text = costTotal.ToString("c");
            return costTotal2;
        }
           
        public double totalCostCalc( double totalCost, double costTotal, double answer3, double answer4)
        {
            totalCost = answer3 + answer4 + costTotal;
            totalCostText.Text = totalCost.ToString("c");
            return totalCost;
        }



    }
}
