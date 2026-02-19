using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TaskManagement.Model
{
    public class TaskList:INotifyPropertyChanged
    {
        public int userId;
        public int taskId;
        public string description;
        public bool status;
        public int UserId
        {
            get => userId;
            set
            {
                if (userId != value)
                {
                    userId = value;
                    OnPropertyChanged(nameof(UserId));
                }
            }
        }
        public int TaskId
        {
            get => taskId;
            set
            {
                if (taskId != value)
                {
                    taskId = value;
                    OnPropertyChanged(nameof(TaskId));
                }
            }
        }

        public string Description
        {
            get => description;
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }
        public bool Status
        {
            get => status;
            set
            {
                if (status != value)
                {
                    status = value;
                    OnPropertyChanged(nameof(Status));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
