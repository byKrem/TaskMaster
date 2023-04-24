using System;
using System.Windows;
using System.Windows.Input;

namespace TaskMaster.Commands
{
    internal class ShowWindowCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if(parameter is Type windowType)
            {
                Window? window = (Window?) Activator.CreateInstance(windowType);
                window?.Show();
            }
        }
    }
}
