using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TaskMaster.Models
{
    class MyTask : INotifyPropertyChanged
    {
        #region Private Members
        private string _name;
        private string _description;
        private DateTime _creationDate;
        private TaskStatus _status;
        private ObservableCollection<Task> _actions;
        private ObservableCollection<TaskTrigger> _triggers;
        #endregion
        #region Properties
        public string Name
        { 
            get => _name;
            set 
            { 
                _name = value;
                OnPropertyChanged();
            }
        }
        public string Description 
        { 
            get => _description;
            set 
            { 
                _description = value;
                OnPropertyChanged();
            }
        }
        public DateTime CreationDate
        {
            get => _creationDate;
            set
            {
                _creationDate = value;
                OnPropertyChanged();
            }
        }
        public TaskStatus Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged();
            }

        }
        public ObservableCollection<Task> Actions
        { 
            get => _actions;
            set 
            { 
                _actions = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<TaskTrigger> Triggers
        {
            get => _triggers;
            set 
            {
                _triggers = value;
                OnPropertyChanged();
            }
        }
        public string TriggersToString
        {
            get
            {
                if (Triggers.Count == 0)
                    return "No trigger defined";
                else if (Triggers.Count == 1)
                    return Triggers[0].ToString();
                else
                    return "Definitely multiple triggers";
            }
        }
        #endregion

#pragma warning disable CS8618 // NonNullable private members
        public MyTask(string name, string description = "")
        {
            Name = name;
            Description = description;
            CreationDate = DateTime.Now;
            Status = TaskStatus.WaitingToRun;
            Actions = new ObservableCollection<Task>();
            Triggers = new ObservableCollection<TaskTrigger>();
        }
#pragma warning restore CS8618

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        #endregion
        public void Start()
        {
            // TODO: Execute triggers start up point
        }
    }
}
