using BasketLibrary;
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


namespace Basketball3x3
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GlobalConfig.InitializeConnections(DatabaseType.TextFile);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_CreateTournament(object sender, RoutedEventArgs e)
        {
            CreateTournament ct = new CreateTournament();
            ct.Show();
            this.Hide();
        }

        private void Button_LoadTournament(object sender, RoutedEventArgs e)
        {
            if (combobox1.SelectedIndex < -1) // checks if combobox item is selected
                MessageBox.Show("Select tournament first.");
            else
            {
                TournamentViewer tw = new TournamentViewer();
                tw.Show();
                tw.Hide();
            }
        }

        private void Button_X(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
