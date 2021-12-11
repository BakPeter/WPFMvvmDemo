using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPfMvvmDemo.Model;
using WPfMvvmDemo.ViewModels;

namespace WPfMvvmDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Hotel _hotel;

        public App()
        {
            _hotel = new Hotel("My Hotel");
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow
            {
                DataContext = new MainViewModel(_hotel)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
