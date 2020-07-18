using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CalcMobile.Models
{
    public class CalculatorModel : INotifyPropertyChanged
    {
        private string _firstNumber;
        private string _secondNumber;
        private string _solution;
        private string _operation;
        private string _equation;

        public string Equation
        {
            get
            {
                return _equation;
            }
            set
            {
                _equation = value;
                OnPropertyChanged("Equation");
            }
        }

        public string Operation
        {
            get
            {
                return _operation;
            }
            set
            {
                _operation = value;
                OnPropertyChanged("Operation");
            }
        }

        public string Solution
        {
            get
            {
                return _solution;
            }
            set
            {
                _solution = value;
                OnPropertyChanged("Solution");
            }
        }

        public string FirstNumber
        {
            get
            {
                return _firstNumber;
            }
            set
            {
                _firstNumber = value;
                OnPropertyChanged("FirstNumber");
            }
        }

        public string SecondNumber
        {
            get
            {
                return _secondNumber;
            }
            set
            {
                _secondNumber = value;
                OnPropertyChanged("SecondNumber");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
