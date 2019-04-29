using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        double memoryValue = 0.0;
        bool clearDisplay = true;

        bool isFirstValue = true;
        bool isAfterEqual = false;

        double currentAnswer;
        double lastValueEntered;

        char lastOp;

        
        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string digit = button.Text;

            if (isAfterEqual)
            {
                currentAnswer = 0.0;
                lastOp = ' ';
            }

            isAfterEqual = false;
            
            
            if (clearDisplay)
            {
                txtDisplay.Text = digit;
                clearDisplay = false;
            }
            else
            {
                txtDisplay.AppendText(digit);
            }
        }

        private void btnDP_Click(object sender, EventArgs e)
        {
            if(isAfterEqual)
            {
                currentAnswer = 0.0;
                lastOp = ' ';
            }

            isAfterEqual = false;

            if (clearDisplay)
            {
                txtDisplay.Text = ("0.");
                clearDisplay = false;
            }
            else
            {
                txtDisplay.AppendText(".");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lastOp = ' ';
            currentAnswer = 0.0;

            txtDisplay.Text = ("0");
            
            isFirstValue = true;
            isAfterEqual = false;

        }

        private void btnMAdd_Click(object sender, EventArgs e)
        {
            memoryValue += Double.Parse(txtDisplay.Text);
        }

        private void btnMSub_Click(object sender, EventArgs e)
        {
            memoryValue -= Double.Parse(txtDisplay.Text);
        }

        private void btnMrec_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memoryValue.ToString();
        }

        private void btnMClr_Click(object sender, EventArgs e)
        {
            memoryValue = 0.0;
            btnDP.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isFirstValue)
            {
                currentAnswer = double.Parse(txtDisplay.Text);
                isFirstValue = false;

                lastOp = ('+');
                isFirstValue = false;
            }
                else
                {
              lastValueEntered = double.Parse(txtDisplay.Text);
                switch(lastOp)
                {
                    case '+':
                        currentAnswer += lastValueEntered;
                        break;
                    case '-':
                        currentAnswer -= lastValueEntered;
                        break;
                    case '*':
                        currentAnswer *= lastValueEntered;
                        break;
                    case '/':
                        currentAnswer /= lastValueEntered;
                        break;

                }
            }

            lastOp = '+';
            isAfterEqual = false;
            txtDisplay.Text = currentAnswer.ToString();  

            clearDisplay = true;
            btnDP.Enabled = true;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (isFirstValue)
            {
                currentAnswer = double.Parse(txtDisplay.Text);
                isFirstValue = false;

                lastOp = ('-');
                isFirstValue = false;
            }
            else
            {
                lastValueEntered = double.Parse(txtDisplay.Text);
                switch (lastOp)
                {
                    case '+':
                        currentAnswer += lastValueEntered;
                        break;
                    case '-':
                        currentAnswer -= lastValueEntered;
                        break;
                    case '*':
                        currentAnswer *= lastValueEntered;
                        break;
                    case '/':
                        currentAnswer /= lastValueEntered;
                        break;

                }
            }

            lastOp = '-';
            isAfterEqual = false;
            txtDisplay.Text = currentAnswer.ToString();

            clearDisplay = true;
            btnDP.Enabled = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (isFirstValue)
            {
                currentAnswer = double.Parse(txtDisplay.Text);
                isFirstValue = false;

                lastOp = ('*');
                isFirstValue = false;
            }
            else
            {
                lastValueEntered = double.Parse(txtDisplay.Text);
                switch (lastOp)
                {
                    case '+':
                        currentAnswer += lastValueEntered;
                        break;
                    case '-':
                        currentAnswer -= lastValueEntered;
                        break;
                    case '*':
                        currentAnswer *= lastValueEntered;
                        break;
                    case '/':
                        currentAnswer /= lastValueEntered;
                        break;

                }
            }

            lastOp = '*';
            isAfterEqual = false;
            txtDisplay.Text = currentAnswer.ToString();

            clearDisplay = true;
            btnDP.Enabled = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (isFirstValue)
            {
                currentAnswer = double.Parse(txtDisplay.Text);
                isFirstValue = false;

                lastOp = ('*');
                isFirstValue = false;
            }
            else
            {
                lastValueEntered = double.Parse(txtDisplay.Text);
                switch (lastOp)
                {
                    case '+':
                        currentAnswer += lastValueEntered;
                        break;
                    case '-':
                        currentAnswer -= lastValueEntered;
                        break;
                    case '*':
                        currentAnswer *= lastValueEntered;
                        break;
                    case '/':
                        currentAnswer /= lastValueEntered;
                        break;

                }
            }

            lastOp = '*';
            isAfterEqual = false;
            txtDisplay.Text = currentAnswer.ToString();

            clearDisplay = true;
            btnDP.Enabled = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (isAfterEqual== false)
            {
                lastValueEntered = double.Parse(txtDisplay.Text);
            }

            if (lastOp == '+')
            {
                currentAnswer += lastValueEntered;
            }
            else if (lastOp == '-')
            {
                currentAnswer -= lastValueEntered;
            }
            else if (lastOp == '/')
            {
                currentAnswer /= lastValueEntered;
            }
            else if (lastOp == '*')
            {
                currentAnswer *= lastValueEntered;
            }

            txtDisplay.Text = currentAnswer.ToString();
            isFirstValue = false;

            isAfterEqual = true;
            clearDisplay = true;
        }
    }
}
