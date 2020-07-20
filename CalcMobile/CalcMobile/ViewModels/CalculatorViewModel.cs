using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using CalcMobile.Commands;
using CalcMobile.Models;

namespace CalcMobile.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private CalculatorModel model;

        public CalculatorViewModel()
        {
            model = new CalculatorModel();
        }

        public CalculatorModel Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
                OnPropertyChanged("Model");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private ICommand _oneCommand;

        public ICommand OneCommand
        {
            get
            {
                if(_oneCommand == null)
                {
                    _oneCommand = new RelayCommand(p => AddOne(), p => CanAddOne());
                }

                return _oneCommand;
            }
        }

        private void AddOne()
        {
            if(model.Operation == null || model.Operation == String.Empty)
            {
                model.FirstNumber += "1";
                model.Equation += "1";
            }
            else
            {
                model.SecondNumber += "1";
                model.Equation += "1";
                DisplaySolution();
            }
        }

        private bool CanAddOne()
        {
            return true;
        }

        private ICommand _twoCommand;

        public ICommand TwoCommand
        {
            get
            {
                if (_twoCommand == null)
                {
                    _twoCommand = new RelayCommand(p => AddTwo(), p => CanAddTwo());
                }

                return _twoCommand;
            }
        }

        private void AddTwo()
        {
            if (model.Operation == null || model.Operation == String.Empty)
            {
                model.FirstNumber += "2";
                model.Equation += "2";
            }
            else
            {
                model.SecondNumber += "2";
                model.Equation += "2";
                DisplaySolution();
            }
        }

        private bool CanAddTwo()
        {
            return true;
        }

        private ICommand _threeCommand;

        public ICommand ThreeCommand
        {
            get
            {
                if (_threeCommand == null)
                {
                    _threeCommand = new RelayCommand(p => AddThree(), p => CanAddThree());
                }

                return _threeCommand;
            }
        }

        private void AddThree()
        {
            if (model.Operation == null || model.Operation == String.Empty)
            {
                model.FirstNumber += "3";
                model.Equation += "3";
            }
            else
            {
                model.SecondNumber += "3";
                model.Equation += "3";
                DisplaySolution();
            }
        }

        private bool CanAddThree()
        {
            return true;
        }

        private ICommand _fourCommand;

        public ICommand FourCommand
        {
            get
            {
                if (_fourCommand == null)
                {
                    _fourCommand = new RelayCommand(p => AddFour(), p => CanAddFour());
                }

                return _fourCommand;
            }
        }

        private void AddFour()
        {
            if (model.Operation == null || model.Operation == String.Empty)
            {
                model.FirstNumber += "4";
                model.Equation += "4";
            }
            else
            {
                model.SecondNumber += "4";
                model.Equation += "4";
                DisplaySolution();
            }
        }

        private bool CanAddFour()
        {
            return true;
        }

        private ICommand _fiveCommand;

        public ICommand FiveCommand
        {
            get
            {
                if (_fiveCommand == null)
                {
                    _fiveCommand = new RelayCommand(p => AddFive(), p => CanAddFive());
                }

                return _fiveCommand;
            }
        }

        private void AddFive()
        {
            if (model.Operation == null || model.Operation == String.Empty)
            {
                model.FirstNumber += "5";
                model.Equation += "5";
            }
            else
            {
                model.SecondNumber += "5";
                model.Equation += "5";
                DisplaySolution();
            }
        }

        private bool CanAddFive()
        {
            return true;
        }

        private ICommand _sixCommand;

        public ICommand SixCommand
        {
            get
            {
                if (_sixCommand == null)
                {
                    _sixCommand = new RelayCommand(p => AddSix(), p => CanAddSix());
                }

                return _sixCommand;
            }
        }

        private void AddSix()
        {
            if (model.Operation == null || model.Operation == String.Empty)
            {
                model.FirstNumber += "6";
                model.Equation += "6";
            }
            else
            {
                model.SecondNumber += "6";
                model.Equation += "6";
                DisplaySolution();
            }
        }

        private bool CanAddSix()
        {
            return true;
        }

        private ICommand _sevenCommand;

        public ICommand SevenCommand
        {
            get
            {
                if (_sevenCommand == null)
                {
                    _sevenCommand = new RelayCommand(p => AddSeven(), p => CanAddSeven());
                }

                return _sevenCommand;
            }
        }

        private void AddSeven()
        {
            if (model.Operation == null || model.Operation == String.Empty)
            {
                model.FirstNumber += "7";
                model.Equation += "7";
            }
            else
            {
                model.SecondNumber += "7";
                model.Equation += "7";
                DisplaySolution();
            }
        }

        private bool CanAddSeven()
        {
            return true;
        }

        private ICommand _zeroCommand;

        public ICommand ZeroCommand
        {
            get
            {
                if (_zeroCommand == null)
                {
                    _zeroCommand = new RelayCommand(p => AddZero(), p => CanAddZero());
                }

                return _zeroCommand;
            }
        }

        private void AddZero()
        {
            if (model.Operation == null || model.Operation == String.Empty)
            {
                model.FirstNumber += "0";
                model.Equation += "0";
            }
            else
            {
                model.SecondNumber += "0";
                model.Equation += "0";
                DisplaySolution();
            }
        }

        private bool CanAddZero()
        {
            return true;
        }

        private ICommand _eightCommand;

        public ICommand EightCommand
        {
            get
            {
                if (_eightCommand == null)
                {
                    _eightCommand = new RelayCommand(p => AddEight(), p => CanAddEight());
                }

                return _eightCommand;
            }
        }

        private void AddEight()
        {
            if (model.Operation == null || model.Operation == String.Empty)
            {
                model.FirstNumber += "8";
                model.Equation += "8";
            }
            else
            {
                model.SecondNumber += "8";
                model.Equation += "8";
                DisplaySolution();
            }
        }

        private bool CanAddEight()
        {
            return true;
        }

        private ICommand _nineCommand;

        public ICommand NineCommand
        {
            get
            {
                if (_nineCommand == null)
                {
                    _nineCommand = new RelayCommand(p => AddNine(), p => CanAddNine());
                }

                return _nineCommand;
            }
        }

        private void AddNine()
        {
            if (model.Operation == null || model.Operation == String.Empty)
            {
                model.FirstNumber += "9";
                model.Equation += "9";
            }
            else
            {
                model.SecondNumber += "9";
                model.Equation += "9";
                DisplaySolution();
            }
        }

        private bool CanAddNine()
        {
            return true;
        }

        private ICommand _addCommand;

        public ICommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new RelayCommand(p => AddPlusSign(), p => CanAddPlusSign());
                }

                return _addCommand;
            }
        }

        private void AddPlusSign()
        {
            if (model.FirstNumber != null || model.FirstNumber != String.Empty)
            {
                model.Operation = "+";
                model.Equation += "+";
            }
            if (model.Solution != null)
            {
                model.FirstNumber = model.Solution;
                model.Equation = model.Solution + model.Operation;
                model.SecondNumber = null;
            }
        }

        private bool CanAddPlusSign()
        {
            return true;
        }

        private ICommand _subCommand;

        public ICommand SubCommand
        {
            get
            {
                if (_subCommand == null)
                {
                    _subCommand = new RelayCommand(p => AddSubSign(), p => CanAddSubSign());
                }

                return _subCommand;
            }
        }

        private void AddSubSign()
        {
            if (model.FirstNumber != null || model.FirstNumber != String.Empty)
            {
                model.Operation = "-";
                model.Equation += "-";
            }
            if (model.Solution != null)
            {
                model.FirstNumber = model.Solution;
                model.Equation = model.Solution + model.Operation;
                model.SecondNumber = null;
            }
        }

        private bool CanAddSubSign()
        {
            return true;
        }

        private ICommand _multiplyCommand;

        public ICommand MultiplyCommand
        {
            get
            {
                if (_multiplyCommand == null)
                {
                    _multiplyCommand = new RelayCommand(p => AddMultiplySign(), p => CanAddMultiplySign());
                }

                return _multiplyCommand;
            }
        }

        private void AddMultiplySign()
        {
            if (model.FirstNumber != null || model.FirstNumber != String.Empty)
            {
                model.Operation = "*";
                model.Equation += "*";
            }
            if (model.Solution != null)
            {
                model.FirstNumber = model.Solution;
                model.Equation = model.Solution + model.Operation;
                model.SecondNumber = null;
            }
        }

        private bool CanAddMultiplySign()
        {
            return true;
        }

        private ICommand _divCommand;

        public ICommand DivCommand
        {
            get
            {
                if (_divCommand == null)
                {
                    _divCommand = new RelayCommand(p => AddDivSign(), p => CanAddDivSign());
                }

                return _divCommand;
            }
        }

        private void AddDivSign()
        {
            if (model.FirstNumber != null || model.FirstNumber != String.Empty)
            {
                model.Operation = "/";
                model.Equation += "/";
            }
            if (model.Solution != null)
            {
                model.FirstNumber = model.Solution;
                model.Equation = model.Solution + model.Operation;
                model.SecondNumber = null;
            }
        }

        private bool CanAddDivSign()
        {
            return true;
        }

        private ICommand _percentCommand;

        public ICommand PercentCommand
        {
            get
            {
                if (_percentCommand == null)
                {
                    _percentCommand = new RelayCommand(p => AddPercentSign(), p => CanAddPercentSign());
                }

                return _percentCommand;
            }
        }

        private void AddPercentSign()
        {
            if (model.FirstNumber != null || model.FirstNumber != String.Empty)
            {
                model.Operation = "%";
                model.Equation += "%";
            }
            if (model.Solution != null)
            {
                model.FirstNumber = model.Solution;
                model.Equation = model.Solution + model.Operation;
                model.SecondNumber = null;
            }
        }

        private bool CanAddPercentSign()
        {
            return true;
        }

        private ICommand _deleteCommand;

        public ICommand DeleteCommand
        {
            get
            {
                if (_deleteCommand == null)
                {
                    _deleteCommand = new RelayCommand(
                    param => Delete(),
                    param => CanDelete()
                    );
                }
                return _deleteCommand;
            }
        }
        private void Delete()
        {


            if ((model.FirstNumber != null & model.FirstNumber != string.Empty && model.Equation.Length - 1 >= 0) && (model.Operation == null || model.Operation == string.Empty))
            {
                model.Equation = model.Equation.Remove(model.Equation.Length - 1);
                model.FirstNumber = model.FirstNumber.Remove(model.FirstNumber.Length - 1);

            }
            else if (model.FirstNumber != null && (model.SecondNumber == null || model.SecondNumber == string.Empty) && model.Operation != null && model.Operation != string.Empty)
            {
                model.Equation = model.Equation.Remove(model.Equation.Length - 1);
                model.Operation = model.Operation.Remove(model.Operation.Length - 1);

            }
            else if (model.FirstNumber != null && model.FirstNumber != string.Empty && model.Operation != null && model.Operation != string.Empty)
            {
                if (model.SecondNumber.Length == 1)
                {
                    model.Equation = model.Equation.Remove(model.Equation.Length - 1);
                    model.SecondNumber = model.SecondNumber.Remove(model.SecondNumber.Length - 1);

                    model.Solution = null;
                }
                else
                {
                    model.Equation = model.Equation.Remove(model.Equation.Length - 1);
                    model.SecondNumber = model.SecondNumber.Remove(model.SecondNumber.Length - 1);

                    DisplaySolution();
                }
            }


        }


        private bool CanDelete()
        {
            return true;
        }

        private ICommand _clearCommand;
  
        public ICommand ClearCommand
        {
            get
            {
                if (_clearCommand == null)
                {
                    _clearCommand = new RelayCommand(
                    param => Clear(),
                    param => CanClear()
                    );
                }
                return _clearCommand;
            }
        }
        private void Clear()
        {
            model.FirstNumber = null;
            model.SecondNumber = null;
            model.Equation = null;
            model.Operation = null;
            model.Solution = null;
        }


        private bool CanClear()
        {
            return true;
        }

        private ICommand _dotCommand;

        public ICommand DotCommand
        {
            get
            {
                if (_dotCommand == null)
                {
                    _dotCommand = new RelayCommand(p => AddDotSign(), p => CanAddDotSign());
                }

                return _dotCommand;
            }
        }

        private void AddDotSign()
        {
            if (model.FirstNumber != null && model.FirstNumber != string.Empty && !model.FirstNumber.Contains(".") && (model.Operation == null || model.Operation == string.Empty) && (model.SecondNumber == null || model.SecondNumber == string.Empty))
            {
                model.FirstNumber += ".";
                model.Equation += ".";
            }
            else if (model.Operation != null && model.Operation != string.Empty && model.SecondNumber != null && model.SecondNumber != string.Empty && !model.SecondNumber.Contains("."))
            {
                model.SecondNumber += ".";
                model.Equation += ".";

                DisplaySolution();
            }
        }

        private bool CanAddDotSign()
        {
            return true;
        }

        private void DisplaySolution()
        {
            string operation = model.Operation;
            double firstNumber = Convert.ToDouble(model.FirstNumber);
            double first = Convert.ToDouble(model.FirstNumber);
            double secondNumber = Convert.ToDouble(model.SecondNumber);
            double second = Convert.ToDouble(model.SecondNumber);

            double solution;
            switch (operation)
            {
                case "+":
                    solution = Math.Round(firstNumber + secondNumber, 3);
                    model.Solution = solution + "";
                    break;
                case "-":
                    solution = Math.Round(firstNumber - secondNumber, 3);
                    model.Solution = solution + "";
                    break;
                case "/":
                    solution = Math.Round(firstNumber / secondNumber, 3);
                    model.Solution = solution + "";
                    break;
                case "*":
                    solution = Math.Round(firstNumber * secondNumber, 3);
                    model.Solution = solution + "";
                    break;
                case "%":
                    double answer = Math.Round((first * (double)second) / 100, 3);
                    model.Solution = answer + "";
                    break;
            }
        }
    }
}
