using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using MVVMobileSample.View;

namespace MVVMobileSample.ViewModel
{
    public class UserListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<UserViewModel> Users { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand CreateCommand { protected set; get; }
        public ICommand DeleteCommand { protected set; get; }
        public ICommand SaveCommand { protected set; get; }
        public ICommand EditCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }
        UserViewModel selectedUser;

        public INavigation Navigation { get; set; }

        public UserListViewModel()
        {
            Users = new ObservableCollection<UserViewModel>();
            CreateCommand = new Command(CreateUser);
            EditCommand = new Command(EditUser);
            DeleteCommand = new Command(DeleteUser);
            SaveCommand = new Command(SaveUser);
            BackCommand = new Command(Back);
        }

        public UserViewModel SelectedUser
        {
            get { return selectedUser; }
            set
            {
                if (selectedUser != value)
                {
                    UserViewModel tempFriend = value;
                    selectedUser = null;
                    OnPropertyChanged("SelectedFriend");
                    Navigation.PushAsync(new PageUser(tempFriend));
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        private void CreateUser()
        {
            Navigation.PushAsync(new PageUser(new UserViewModel() { ListViewModel = this }));
        }
        private void Back()
        {
            Navigation.PopAsync();
        }
        private void SaveUser(object userObject)
        {
            UserViewModel user = userObject as UserViewModel;
            if (user != null && user.IsValid && !Users.Contains(user))
            {
                Users.Add(user);
            }
            Back();
        }
        private void EditUser(object userObject)
        {

        }
        private void DeleteUser(object userObject)
        {
            UserViewModel user = userObject as UserViewModel;
            if (user != null)
            {
                Users.Remove(user);
            }
            Back();
        }
    }
}
