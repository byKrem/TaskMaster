using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Input;
using TaskMaster.Commands;
using TaskMaster.Models;
using TaskMaster.Views;

namespace TaskMaster.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private ICommand? _shutdownCommand;
        private ICommand? _showWindowCommand;
        private UserControl? _propertyPage;

        public ICommand ShutdownCommand
        {
            get
            {
                _shutdownCommand ??= new ShutdownCommand();
                return _shutdownCommand;
            }
        }

        public ICommand ShowWindowCommand
        {
            get
            {
                _showWindowCommand ??= new ShowWindowCommand();
                return _showWindowCommand;
            }
        }

        public UserControl PropertyPage
        {
            get
            {
                _propertyPage = new TaskPropertyPage() { DataContext = SelectedTask };
                return _propertyPage;
            }
        }
        public ObservableCollection<MyTask> TaskList { get; set; }
        public ObservableCollection<MyTask> SelectedTask { get; set; }
        public MainViewModel()
        {
            TaskList = new ObservableCollection<MyTask>();
            SelectedTask = new ObservableCollection<MyTask>();
#if DEBUG
            TaskList.Add(new MyTask("Name1"));
            TaskList.Add(new MyTask("Name2"));
            TaskList.Add(new MyTask("Name3"));
            TaskList.Add(new MyTask("Name4"));
#endif
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnProperyChanged([CallerMemberName] string prop = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
