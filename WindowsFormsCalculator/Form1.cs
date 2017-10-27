using System;
using Calculation;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class Form1 : Form
    {
        public float fFirstNumber;
        public float fSecondNumber;              
        Calculator Calculator = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fFirstNumber = Convert.ToSingle(inptFirstNumber.Value);
            fSecondNumber = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(Calculator.Add(fFirstNumber,fSecondNumber));
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            fFirstNumber = Convert.ToSingle(inptFirstNumber.Value);
            fSecondNumber = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(Calculator.Substract(fFirstNumber, fSecondNumber));
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            fFirstNumber = Convert.ToSingle(inptFirstNumber.Value);
            fSecondNumber = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(Calculator.Multiply(fFirstNumber, fSecondNumber));
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            fFirstNumber = Convert.ToSingle(inptFirstNumber.Value);
            fSecondNumber = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(Calculator.Divide(fFirstNumber, fSecondNumber));
        }
    }
}
