using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using MVVMobileSample.Model;

namespace MVVMobileSample.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        UserListViewModel Usrlvm;
        public User User { get; private set; }

        public UserViewModel()
        {
            User = new User();
        }
        public UserListViewModel ListViewModel
        {
            get { return Usrlvm; }
            set
            {
                if (Usrlvm != value)
                {
                    Usrlvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }
        public string Name
        {
            get { return User.Name; }
            set
            {
                if (User.Name != value)
                {
                    User.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string Login
        {
            get { return User.Login; }
            set
            {
                if (User.Login != value)
                {
                    User.Login = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        public string LastName
        {
            get { return User.LastName; }
            set
            {
                if (User.LastName != value)
                {
                    User.LastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }
        public int Number
        {
            get { return User.Number; }
            set
            {
                if (User.Number != value)
                {
                    User.Number = value;
                    OnPropertyChanged("Number");
                }
            }

        }
        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Name.Trim())) ||
                    (!string.IsNullOrEmpty(Login.Trim())) ||
                    (!string.IsNullOrEmpty(LastName.Trim())) ||
                    (!string.IsNullOrEmpty(Number.ToString())));
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
