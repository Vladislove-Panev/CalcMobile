using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcMobile
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int currentState = 1;
        string mathOperator;
        double firstNumber, secondNumber;
        bool isNegative = false;
        bool isDecimal = false;

        public MainPage()
        {
            InitializeComponent();
            OnClear(this, null);
        }

        void OnSelectNumber(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            if (lable.Text == "0" || currentState < 0)
            {
                lable.Text = "";
                isDecimal = false;
                isNegative = false;
                if (currentState < 0)
                    currentState *= -1;
            }

            lable.Text += pressed;

            if (double.TryParse(lable.Text, out double number))
            {
                lable.Text = Convert.ToString(number);
                if (currentState == 1)
                {
                    firstNumber = number;
                }
                else
                {
                    secondNumber = number;
                }
            }
        }

        void OnSelectOperator(object sender, EventArgs e)
        {
            currentState = -2;
            Button button = (Button)sender;
            string pressed = button.Text;
            mathOperator = pressed;
            isDecimal = false;
            isNegative = false;
        }

        void OnClear(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            currentState = 1;
            isNegative = false;
            isDecimal = false;
            lable.Text = "0";
        }

        void OnCalculate(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentState == 2 && button.Text != "%")
            {
                var result = SimpleCalculator.Calculate(firstNumber, secondNumber, mathOperator);

                lable.Text = result.ToString();
                firstNumber = result;
                currentState = -1;
            }
            else
            {
                var result = SimpleCalculator.Calculate(Convert.ToDouble(lable.Text), 100, "/");

                lable.Text = result.ToString();
                firstNumber = result;
                currentState = -1;
            }

            if(int.TryParse(lable.Text, out int res))
            {
                isDecimal = false;
            }
        }

        void OnMinus(object sender, EventArgs e)
        {
            if (!isNegative)
            {
                if (currentState == 1)
                {
                    firstNumber *= -1;
                }
                else
                {
                    secondNumber *= -1;
                }

                lable.Text = lable.Text.Insert(0, "-");
                isNegative = true;
            }
            else
            {
                if (currentState == 1)
                {
                    firstNumber *= -1;
                }
                else
                {
                    secondNumber *= -1;
                }

                lable.Text.Remove(0);
                isNegative = false;
            }
        }

        void OnDecimal(object sender, EventArgs e)
        {
            if (!isDecimal)
            {
                isDecimal = true;
                lable.Text += ".";
            }
        }
    }
}
