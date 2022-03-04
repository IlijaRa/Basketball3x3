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

    public partial class CreateTournament : Window, IPrizeRequester, ITeamRequester
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
            // Call the CreateTeam form
            CreateTeam ct = new CreateTeam(this);
            ct.ShowDialog();
        }

        private void Button_CreatePrize(object sender, RoutedEventArgs e)
        {
            // Call the CreatePrize form
            CreatePrize cp = new CreatePrize(this);
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

        public void PrizeComplete(PrizeModel model)
        {
            // Get back from the form a PrizeModel
            // Take the PrizeModel and put it into out list of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void Button_RemoveSelectedTeam(object sender, RoutedEventArgs e)
        {

            TeamModel t = (TeamModel)lb_tournamentTeams.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpLists();
            }
        }

        private void Button_RemoveSelectedPrize(object sender, RoutedEventArgs e)
        {
            PrizeModel p = (PrizeModel)lb_prizes.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpLists();
            }
        }

        private void Button_CreateTournament(object sender, RoutedEventArgs e)
        {
            // Validate data
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(tb_entryFee.Text, out fee);
            if (!feeAcceptable)
            {
                MessageBox.Show("Youu need to enter a valid entry fee.", "Invalid fee!", 
                                                                         MessageBoxButton.OK, 
                                                                         MessageBoxImage.Error);
                return;
            }

            //Create our TournamentModel
            TournamentModel tm = new TournamentModel();
            tm.TournamentName = tb_tournamentName.Text;
            tm.EntryFee = fee;
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            //Create tournament entry
            //Create all of the prizes entries
            //Create all of team entries

            //Create our matchups
        }
    }
}
