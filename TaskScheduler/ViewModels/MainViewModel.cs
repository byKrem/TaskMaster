using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using TaskScheduler.Commands;
using TaskScheduler.Models;

namespace TaskScheduler.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public List<MyTask> TaskList { get; set; }
        public List<MyTask> SelectedTask { get; set; }
        public MainViewModel()
        {
            TaskList = new List<MyTask>();
            SelectedTask = new List<MyTask>();
#if DEBUG
            TaskList.Add(new MyTask("Name1"));
            TaskList.Add(new MyTask("Name2"));
            TaskList.Add(new MyTask("Name3"));
            TaskList.Add(new MyTask("Name4"));
#endif
        }

        private ICommand? _shutdownCommand;
        public ICommand ShutdownCommand
        {
            get
            {
                _shutdownCommand ??= new ShutdownCommand();
                return _shutdownCommand;
            }
            set
            {
                _shutdownCommand = value;
            }
        }

        private ICommand? _showWindowCommand;
        public ICommand ShowWindowCommand
        {
            get
            {
                _showWindowCommand ??= new ShowWindowCommand();
                return _showWindowCommand;
            }
            set
            {
                _showWindowCommand = value;
            }
        }
    }
}
