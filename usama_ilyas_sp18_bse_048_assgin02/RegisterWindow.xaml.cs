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
using System.Windows.Shapes;
using usama_ilyas_sp18_bse_048_assign02.controller;
using usama_ilyas_sp18_bse_048_assign02.models;

namespace usama_ilyas_sp18_bse_048_assgin02
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {

   //     public int RegNumValue { get; set; }
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void regNum_TextChanged(object sender, TextChangedEventArgs e)
        {
         //   Console.WriteLine(RegNumValue.ToString());

        }

        private void nameChanged(object sender, TextChangedEventArgs e)
        {
            //   Console.WriteLine(RegNumValue.ToString());

        }

        private void createAccountBtnClick(object sender, RoutedEventArgs e)
        {
            Student student = new Student(name.Text,regNum.Text,password.Password.ToString());
            Controller.addAccount(student);
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }

       
    }
}
