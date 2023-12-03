using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kal
{
    public partial class Form1 : Form
    {
        private float valueBuffer;
        private char operationBuffer;
        private bool clearDisplay;

        public Form1()
        {
            InitializeComponent();
            ResetValues();
        }

        private void ResetValues()
        {
            valueBuffer = 0;
            clearDisplay = false;
        }

        private void DigitPressed(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (clearDisplay)
            {
                displayTextBox.Text = btn.Text;
                clearDisplay = false;
            }
            else
            {
                displayTextBox.Text += btn.Text;
            }
        }

        private void OperationPressed(object sender, EventArgs e)
        {
            clearDisplay = true;
            Button btn = (Button)sender;
            char operation = btn.Text[0];
            float displayValue = float.Parse(displayTextBox.Text);

            PerformOperation(displayValue);

            if (operation == '=')
            {
                displayTextBox.Text = valueBuffer.ToString();
                ResetValues();
            }
            else
            {
                operationBuffer = operation;
            }
        }

        private void PerformOperation(float displayValue)
        {
            switch (operationBuffer)
            {
                case '+':
                    valueBuffer += displayValue;
                    break;
                case '-':
                    valueBuffer -= displayValue;
                    break;
                case '*':
                    valueBuffer *= displayValue;
                    break;
                case '/':
                    valueBuffer /= displayValue;
                    break;
                default:
                    valueBuffer = displayValue;
                    break;
            }
        }

        private void ClearPressed(object sender, EventArgs e)
        {
            ResetValues();
            displayTextBox.Text = "0";
            operationBuffer = '!';
        }
    }
}