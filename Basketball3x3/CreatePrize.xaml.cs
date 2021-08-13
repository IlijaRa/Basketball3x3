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
using System.Windows.Shapes;

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

        private void CreatePrize_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateForm())
            {
                //PrizeModel model = new PrizeModel();
                //model.PlaceName = Textbox1.Text;
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            int placeNumber = 0;
            decimal prizeAmount = 0;
            int prizePercentage = 0;

            bool PlaceNumberIsValidNumber = int.TryParse(Textbox1.Text, out placeNumber);
            bool PrizeAmountIsValidAmount = decimal.TryParse(Textbox3.Text, out prizeAmount);
            bool PrizePercentageIsValidPercentage = int.TryParse(Textbox4.Text, out prizePercentage);
            
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
    }
}
