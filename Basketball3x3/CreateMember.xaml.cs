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
using BasketLibrary;
using BasketLibrary.Models;

namespace Basketball3x3
{

    public partial class CreateMember : Window
    {
        public CreateMember()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_X(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_CreateMember(object sender, RoutedEventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = Textbox1.Text;
                p.LastName = Textbox2.Text;
                p.EmailAddress = Textbox3.Text;
                p.CellphoneNumber = Textbox4.Text;

                GlobalConfig.Connection.CreatePerson(p);

                Textbox1.Clear();
                Textbox2.Clear();
                Textbox3.Clear();
                Textbox4.Clear();

            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            if(Textbox1.Text.Length == 0)
            {
                isValid = false;
            }
            if (Textbox2.Text.Length == 0)
            {
                isValid = false;
            }
            if (Textbox3.Text.Length == 0)
            {
                isValid = false;
            }
            if (Textbox4.Text.Length == 0)
            {
                isValid = false;
            }
            return isValid;
        }

        
    }
}
