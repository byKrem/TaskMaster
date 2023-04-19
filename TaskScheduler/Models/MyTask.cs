using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TaskScheduler.Models
{
    class MyTask : INotifyPropertyChanged
    {
        private string _name;
        private string _description;
        private ObservableCollection<Task> _actions;
        private ObservableCollection<TaskTrigger> _triggers;

        public string Name
        { 
            get => _name;
            set 
            { 
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Description 
        { 
            get => _description;
            set 
            { 
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        public ObservableCollection<Task> Actions
        { 
            get => _actions;
            set 
            { 
                _actions = value;
                OnPropertyChanged(nameof(Actions));
            }
        }
        public ObservableCollection<TaskTrigger> Triggers
        {
            get => _triggers;
            set 
            {
                _triggers = value;
                OnPropertyChanged(nameof(Triggers));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

#pragma warning disable CS8618
        public MyTask(string name, string description = "")
        {
            Name = name;
            Description = description;
            Actions = new ObservableCollection<Task>();
            Triggers = new ObservableCollection<TaskTrigger>();
        }
#pragma warning restore CS8618


    }
}
