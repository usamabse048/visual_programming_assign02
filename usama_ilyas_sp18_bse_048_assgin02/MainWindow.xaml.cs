using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using usama_ilyas_sp18_bse_048_assign02.controller;

namespace usama_ilyas_sp18_bse_048_assgin02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void regNum_TextChanged(object sender, TextChangedEventArgs e)
        {
           

        }

       
        private void loginBtnClick(object sender, RoutedEventArgs e)
        {
           if( Controller.authentication(regNum.Text, password.Password.ToString()))
            {
                Console.WriteLine(Controller.students.ElementAt(Controller.currentUser).Name+" Login Successful");
            }
            else
            {
                Console.WriteLine("Login failed");

            }
            
        }
        private void createAccountBtnClick(object sender, RoutedEventArgs e)
        {
            

            RegisterWindow registerWindow = new RegisterWindow();
            this.Hide();
            registerWindow.Show();

        }
    }
}
