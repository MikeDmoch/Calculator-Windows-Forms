using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Threading;

namespace CalculatorWinForms
{
    public partial class Form1 : Form
    {
        string value1 = "0";
        string value2 = "0";
        char operation = 'e';
        bool selectedOperation = false;
        bool commaPlaced = false;
        public Form1()
        {
            InitializeComponent();
        }
        public void err()
        {
            MessageBox.Show("Error: invalid input\nCalculator resetted...");
            selectedOperation = false;
            value1 = "0";
            value2 = "0";
            updateScreen();
        }
        public void checkInput()
        {
            try
            {
               double check = double.Parse(value1);
               check = double.Parse(value2);
            }
            catch
            {
                err();
            }
            if (value1.Length > 14) err();
            if (value2.Length > 14) err();
        }
        public void checkOutput()
        {
            if (Convert.ToDouble(value1) > 999_999_999_999_99) err();
            else if (value1.Length > 14) value1 = value1.Substring(0, 14);
            if (Convert.ToDouble(value2) > 999_999_999_999_99) err();
            else if (value2.Length > 14) value2 = value2.Substring(0, 14);
            if (value1.EndsWith(","))  value1 = value1.Substring(0, value1.Length - 1);
            if (value2.EndsWith(","))  value2 = value2.Substring(0, value2.Length - 1);
        }
        public void updateScreen()
        {
            if (selectedOperation == false)
            {
                Screen.Text = value1;
            }
            else
            {
                Screen.Text = value2;
            }
        }
        public void addComma()
        {
            if (!selectedOperation)
            {
                if (!value1.Contains(",")) value1 += ",";
            }
            else
            {
                if (!value2.Contains(",")) value2 += ",";
            }
        }

        public void setNumber(string number)
        {
            if (selectedOperation == false)
            {
                if (value1 != "0") value1 += number;
                else value1 = number;
            }
            else
            {
                if (value2 != "0") value2 += number;
                else value2 = number;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateScreen();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            setNumber("0");
            checkInput();
            updateScreen();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            setNumber("1");
            checkInput();
            updateScreen();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            checkInput();
            double tmpv = Convert.ToDouble(value1);
            double tmps = Convert.ToDouble(value2);
            if (selectedOperation)
                switch (operation)
                {
                    case '+':
                        value1 = (tmps + tmpv).ToString();
                        break;
                    case '-':
                        value1 = (tmpv - tmps).ToString();
                        break;
                    case '*':
                        value1 = (tmps * tmpv).ToString();
                        break;
                    case '/':
                        if (value2 != "0")
                            value1 = (tmpv / tmps).ToString();
                        else
                            err();
                        break;
                    case 'm':
                        value1 = (tmpv % tmps).ToString();
                        break;
                }
            checkOutput();
            selectedOperation = false;
            updateScreen();
            value2 = "0";
        }

        private void Screen_TextChanged(object sender, EventArgs e)
        {

        }

        //private void doCalcAction(delegate un)
        //{
        //    fun()
        //    checkInput();
        //    updateScreen();
        //}
        private void buttonTwo_Click(object sender, EventArgs e)
        {
            setNumber("2");
            checkInput();
            updateScreen();
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            setNumber("3");
            checkInput();
            updateScreen();
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            setNumber("4");
            checkInput();
            updateScreen();
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            setNumber("5");
            checkInput();
            updateScreen();
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            setNumber("6");
            checkInput();
            updateScreen();
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            setNumber("7");
            checkInput();
            updateScreen();
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            setNumber("8");
            checkInput();
            updateScreen();
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            setNumber("9");
            checkInput();
            updateScreen();
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (selectedOperation == false)
            {
                if (value1 != "0")
                {
                    if (value1 != string.Empty) value1 = value1.Substring(0, value1.Length - 1);

                }
                if (value1 == string.Empty) value1 = "0";
            }
            else if (value2 != "0")
            {
                if (value2 != string.Empty) value2 = value2.Substring(0, value2.Length - 1);
                if (value2 == string.Empty) value2 = "0";
            }
            updateScreen();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            checkInput();
            operation = '+';
            selectedOperation = true;           
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            checkInput();
            operation = '-';
             selectedOperation = true;
            
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            checkInput();
            operation = '*';
             selectedOperation = true;
            
        }

        private void buttonDevide_Click(object sender, EventArgs e)
        {
            checkInput();
            operation = '/';
            selectedOperation = true;
            
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            checkInput();
            if (selectedOperation == false)
            {
                if (value1 != "0") 
                    value1 = (Convert.ToDouble(value1) * (-1)).ToString();
            }
            else
                if (value2 != "0") value2 = (Convert.ToDouble(value2) * (-1)).ToString();
            updateScreen();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            checkInput();
            operation = 'm';
                selectedOperation = true;
            
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            selectedOperation = false;
            value1 = "0";
            value2 = "0";
            updateScreen();
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            checkInput();
            addComma();
            commaPlaced = true;
            updateScreen();
        }

        private void buttonCE_Click_1(object sender, EventArgs e)
        {
            if (selectedOperation) value2 = "0";
            else value1 = "0";
            updateScreen();
        }
    }
}
