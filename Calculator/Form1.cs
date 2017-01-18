using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //Dim FirstNumber As Decimal
        public Form1()
        {
            InitializeComponent();
        }
        Double firstNumber = 0.0;
        String selectedOperator = "";
        Boolean operationPressed = false;
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button selectedButton = (Button)sender;
            result.Text = result.Text + selectedButton.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "";
        }
       
        private void operator_click(object sender, EventArgs e)
        {

            Button selectedButton = (Button)sender;
            selectedOperator = selectedButton.Text;
            firstNumber = Double.Parse(result.Text);
            operationPressed = true;
            result.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            switch (selectedOperator)
            {
                case "+": 
                result.Text = (firstNumber + Double.Parse(result.Text)).ToString();
                break;

                case "-":
                    result.Text = (firstNumber - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (firstNumber * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (firstNumber / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            operationPressed = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Double enteredValue = Double.Parse(result.Text);
            enteredValue = enteredValue * -1;
            result.Text = enteredValue.ToString();
        }
    }
}
