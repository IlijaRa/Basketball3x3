using BasketLibrary;
using BasketLibrary.Models;
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

namespace Basketball3x3
{

    public partial class CreateTeam : Window
    {
        private List<PersonModel> availableMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedMembers = new List<PersonModel>();
        ITeamRequester calling;
        public CreateTeam(ITeamRequester caller)
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
            calling = caller;
        }

        private void CreateSampleData()
        {
            availableMembers.Add(new PersonModel() { FirstName = "Alek", LastName = "Aleksic" });
            availableMembers.Add(new PersonModel() { FirstName = "Stefan", LastName = "Stefanovic" });

            selectedMembers.Add(new PersonModel() { FirstName = "Dina", LastName = "Dinovic" });
            selectedMembers.Add(new PersonModel() { FirstName = "Marta", LastName = "Martinovic" });
        }

        private void WireUpLists()
        {
            cb_teamMembers.ItemsSource = null;
            cb_teamMembers.ItemsSource = availableMembers;
            cb_teamMembers.DisplayMemberPath = "FullName";

            lb_teamMembers.ItemsSource = null;
            lb_teamMembers.ItemsSource = selectedMembers;
            lb_teamMembers.DisplayMemberPath = "FullName";
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

                selectedMembers.Add(p);
                WireUpLists();

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
            if (Textbox1.Text.Length == 0)
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

        private void Button_AddMember(object sender, RoutedEventArgs e)
        {
            PersonModel p = (PersonModel)cb_teamMembers.SelectedItem;

            if (p != null)
            {
                availableMembers.Remove(p);
                selectedMembers.Add(p);

                WireUpLists();
            }
            
        }

        private void Button_RemoveSelected(object sender, RoutedEventArgs e)
        {
            PersonModel p = (PersonModel)lb_teamMembers.SelectedItem;

            if (p != null)
            {
                selectedMembers.Remove(p);
                availableMembers.Add(p);

                WireUpLists();
            }
        }

        private void Button_CreateTeam(object sender, RoutedEventArgs e)
        {
            if (lb_teamMembers.Items.Count > 3)
                MessageBox.Show("Max number of team members is 3!");
            else
            {
                TeamModel t = new TeamModel();
                t.TeamName = tb_teamName.Text;
                t.TeamMembers = selectedMembers;

                GlobalConfig.Connection.CreateTeam(t);
                calling.TeamComplete(t);
                this.Close();
            }
        }
    }
}
