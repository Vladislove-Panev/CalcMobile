﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace CalcMobile.Commands
{
    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;
        private object parameter;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute, INotifyPropertyChanged npc = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;

            if (npc != null)
                npc.PropertyChanged += delegate { _ = canExecute(parameter); };
        }

        public RelayCommand(Action execute, Func<bool> canExecute, INotifyPropertyChanged npc = null) : this(o => execute(), o => canExecute(), npc)
        {
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }

        public void RaisCanExecuteChange()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}