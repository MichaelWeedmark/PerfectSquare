/*
*Created by: Michael Weedmark
*Created on: 13-Oct-2015
*Created for: Unit #3-09
*This program calculates perfect squares.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectSquare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = 1;
            int endingValue;
            Double squareRootAsDouble;
            int squareRootAsInteger;
            int numberOfPerfectSquare = 0;

            this.lsbList.Items.Clear();

            endingValue = Convert.ToInt32(this.nudValue.Text);

            while (value <= endingValue)
            {
                squareRootAsDouble = Math.Sqrt(value);
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                if (squareRootAsDouble == squareRootAsInteger)
                {
                    numberOfPerfectSquare++;
                    this.lsbList.Items.Add(value);
                }
                value++;
            }
        }
    }
}
