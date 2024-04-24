﻿using DBChebakov.Model;
using DBChebakov.View;
using System.Threading.Channels;
using System.Windows;
using System.Windows.Input;

namespace DBChebakov.ViewModel
{
    public class DBConnectViewModel : PropChange
    {
        private string dbName;
        public string DbName
        {
            get { return dbName; }
            set
            {
                dbName = value;
                OnPropertyChanged(nameof(DbName));
            }
        }

        public ICommand ConnectCommand { get; set; }
        public ICommand EnterDefaultCommand { get; set; }

        public DBConnectViewModel()
        {
            ConnectCommand = new RelayCommand(ConnectToDatabase);
            EnterDefaultCommand = new RelayCommand(EnterDefault);
        }

        private void EnterDefault(object obj)
        {
            OnPropertyChanged(nameof(DbName));
        }

        private void ConnectToDatabase(object obj)
        {
            if (!string.IsNullOrWhiteSpace(DbName))
            {
                using (var db = new ApplicationContext(DbName.ToString()))
                {
                    bool exists = db.Database.CanConnect();
                    if (exists)
                    {
                        MessageBox.Show($"Подключение к существующей базе данных {DbName}", "Подключение");                        
                    }
                    else
                    {
                        db.Database.EnsureCreated();
                        MessageBox.Show($"Подключение к новой базе данных {DbName}", "Подключение");
                    }
                    var win = new MainWindow()
                    {
                        DataContext = new MainViewModel()
                    };
                    win.Show();
                    Application.Current.MainWindow.Close();
                    Application.Current.MainWindow = win;
                    OnPropertyChanged(nameof(obj));
                }
            }
        }
    }
}
