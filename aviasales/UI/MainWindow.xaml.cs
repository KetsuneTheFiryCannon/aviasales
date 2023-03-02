using aviasales.DataSet1TableAdapters;
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

namespace aviasales
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DataSet1 _dataset;
        UsersTableAdapter _usersTableAdapter;
        VisitsTableAdapter _visitsTableAdapter;

        public MainWindow()
        {
            InitializeComponent();

            _dataset = new DataSet1();
            _usersTableAdapter = new UsersTableAdapter();
            _visitsTableAdapter = new VisitsTableAdapter();

            _usersTableAdapter.Fill(_dataset.Users);
            _visitsTableAdapter.Fill(_dataset.Visits);
        }

        private void _loginButton_Click(object sender, RoutedEventArgs e)
        {
            if(LoginField.Text != "" && PasswordField.Password != "")
            {
                for(int i = 0; i < _dataset.Tables["Users"].Rows.Count; i++)
                {
                    if(LoginField.Text == _dataset.
                        Tables["Users"].
                        Rows[i]
                        ["Email"].
                        ToString() &&
                        PasswordField.Password == _dataset.
                        Tables["Users"].
                        Rows[i]
                        ["Password"].
                        ToString())
                    {
                        MessageBox.Show("Auth okay");

                    }
                    else
                    {
                        MessageBox.Show("Auth Bad");
                    }
                }
            }
        }

        private void _exitButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
