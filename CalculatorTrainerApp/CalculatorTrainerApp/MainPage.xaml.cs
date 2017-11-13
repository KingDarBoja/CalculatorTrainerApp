using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorTrainerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "Calculator Trainer";
            InitializeComponent();

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
                default:
                    break;
            }
        }

        void StartGameBtnOnClick(object sender, EventArgs e)
        {
            var numberTestLabel = new Label();
            numberTestLabel.SetBinding(Label.TextProperty, new Binding("SelectedItem", source: NumberQuestion));
            Navigation.PushAsync(new MainGame(numberTestLabel.Text.ToString()));
        }
    }
}