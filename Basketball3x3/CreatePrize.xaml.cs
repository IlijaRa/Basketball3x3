using BasketLibrary;
using BasketLibrary.DataAccess;
using BasketLibrary.Models;
using System.Windows;
using System.Windows.Input;

namespace Basketball3x3
{

    public partial class CreatePrize : Window
    {
        public CreatePrize()
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

        private void CreatePrizeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(Textbox1.Text,
                                                  Textbox2.Text,
                                                  Textbox3.Text,
                                                  Textbox4.Text);

                GlobalConfig.Connection.CreatePrize(model);

                Textbox1.Clear();
                Textbox2.Clear();
                Textbox3.Text = "0";
                Textbox4.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please, check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            int placeNumber = 0;
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool PlaceNumberIsValidNumber = int.TryParse(Textbox1.Text, out placeNumber);
            bool PrizeAmountIsValidAmount = decimal.TryParse(Textbox3.Text, out prizeAmount);
            bool PrizePercentageIsValidPercentage = double.TryParse(Textbox4.Text, out prizePercentage);
            
            if (PlaceNumberIsValidNumber == false)
                output = false;

            if (placeNumber < 1)
                output = false;

            if (Textbox2.Text.Length == 0)
                output = false;

            if (PrizeAmountIsValidAmount == false || PrizePercentageIsValidPercentage == false)
                output = false;

            if (prizeAmount <= 0 && prizePercentage <= 0)
                output = false;

            if (prizePercentage < 0 || prizePercentage > 100)
                output = false;

            return output;
        }

        private void Button_X(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
