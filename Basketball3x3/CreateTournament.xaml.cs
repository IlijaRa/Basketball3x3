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

    public partial class CreateTournament : Window
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>(); 
        public CreateTournament()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            cb_selectTeam.ItemsSource = null;
            cb_selectTeam.ItemsSource = availableTeams;
            cb_selectTeam.DisplayMemberPath = "TeamName";

            lb_tournamentTeams.ItemsSource = null;
            lb_tournamentTeams.ItemsSource = selectedTeams;
            lb_tournamentTeams.DisplayMemberPath = "TeamName";

            lb_prizes.ItemsSource = null;
            lb_prizes.ItemsSource = selectedPrizes;
            lb_prizes.DisplayMemberPath = "PlaceName";
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_GoBack(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void Button_CreateTeam(object sender, RoutedEventArgs e)
        {
            CreateTeam ct = new CreateTeam();
            ct.ShowDialog();
        }

        private void Button_CreatePrize(object sender, RoutedEventArgs e)
        {
            CreatePrize cp = new CreatePrize();
            cp.ShowDialog();
        }

        private void Button_AddTeam(object sender, RoutedEventArgs e)
        {
            TeamModel t = (TeamModel)cb_selectTeam.SelectedItem;
            
            if(t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }
    }
}
