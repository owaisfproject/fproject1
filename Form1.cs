using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double resultvalue = 0;
        string operationperformed = "";
        bool isoperationperformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0") || (isoperationperformed))
                textBox_result.Clear();
            Button button = (Button) sender;

            if(button.Text == ".")
            {
                if(!textBox_result.Text.Contains("."))
                    textBox_result.Text = textBox_result.Text + button.Text;
            }
            else
             textBox_result.Text = textBox_result.Text + button.Text;
            isoperationperformed = false;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultvalue != 0)
            {

                button12.PerformClick();
                operationperformed = button.Text;
                labelcurrentoperation.Text = resultvalue + " " + operationperformed;
                isoperationperformed = true;

            }
            else
            {

                operationperformed = button.Text;
                resultvalue = double.Parse(textBox_result.Text);
                labelcurrentoperation.Text = resultvalue + " " + operationperformed;
                isoperationperformed = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            resultvalue = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch(operationperformed)
            {
                case "+":
                    textBox_result.Text = (resultvalue + double.Parse(textBox_result.Text)).ToString();
                    break;

                case "-":
                    textBox_result.Text = (resultvalue - double.Parse(textBox_result.Text)).ToString();
                    break;

                case "*":
                    textBox_result.Text = (resultvalue * double.Parse(textBox_result.Text)).ToString();
                    break;

                case "/":
                    textBox_result.Text = (resultvalue / double.Parse(textBox_result.Text)).ToString();
                    break;

            }

            resultvalue = double.Parse(textBox_result.Text);
            labelcurrentoperation.Text = "";
        }
    }
}
