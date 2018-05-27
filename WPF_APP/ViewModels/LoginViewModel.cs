using AppContext.Respositories;
using GalaSoft.MvvmLight.Command;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_APP.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private UsersRepository repository = new UsersRepository();

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(LoginAction, canExecute: () => true);
            RefreshTable();
        }

        private void RefreshTable()
        {
            UsersCollection = new ObservableCollection<User>();
            UsersCollection = new ObservableCollection<User>(repository.GetAllUsers());
        }
 
        public  User Account { get { return _account; }  set { _account = value; OnPropertyChanged("Account"); } }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }


         

        public void LoginAction()
        {
            // todo call the api to login and store the token

            var repo = new UsersRepository();

            repo.AddUser(Account);

            Account = new User();

            RefreshTable();

        }
        private bool CanLogin()
        {
            return !string.IsNullOrEmpty(_firstName) && !string.IsNullOrEmpty(_lastName);
        }


        public ObservableCollection<User> UsersCollection
        {
            get { return users; }

            set
            {
                users = value;
                OnPropertyChanged("UsersCollection");
            }
        }
    
        public ICommand LoginCommand { get; set; } 
        #region Private properties
        private string _firstName;

        private string _lastName;

        private User _account { get; set; } = new User();

        private ICommand _loginCommand;

        private ObservableCollection<User> users;

        #endregion
    }
}
