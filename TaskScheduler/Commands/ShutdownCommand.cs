using System;
using System.Windows;
using System.Windows.Input;

namespace TaskScheduler.Commands
{
    internal class ShutdownCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            Application.Current.Shutdown();
        }
    }
}
