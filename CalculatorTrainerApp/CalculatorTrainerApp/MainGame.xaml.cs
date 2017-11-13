using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculatorTrainerApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainGame : ContentPage
    {
        int counter = 0;
        int okAnsCount = 0;
        int finalValue;
        Random randNumber1 = new Random();
        Random randNumber2 = new Random();
        Random randOp = new Random();
        public MainGame(String value)
        {
            Title = "Operando ando";
            InitializeComponent();
            NumberTest.Text = "Numero de pruebas: " + value;

            NextBtn.Clicked += delegate {

                if (AnswerEntry.Text == finalValue.ToString())
                {
                    okAnsCount = okAnsCount + 1;
                    DisplayAlert(" Excelente! ", "Respuestas correctas hasta ahora: " + okAnsCount.ToString(), "OK");
                }
                else
                {
                    DisplayAlert(" Fallaste! ", "Respuesta Incorrectas", "OK");
                }
                int x = randOp.Next(0, 2);
                AnswerEntry.Text = "";
                counter = counter + 1;
                CounterTest.Text = "Prueba N° " + counter;
                FirstNumber.Text = randNumber1.Next(0, 100).ToString();
                SecondNumber.Text = randNumber2.Next(0, 100).ToString();
                if (x == 0)
                {
                    OperationRnd.Text = "+";
                    finalValue = AddTwoStrings(FirstNumber.Text, SecondNumber.Text);
                }
                else
                {
                    OperationRnd.Text = "-";
                    finalValue = SubsTwoStrings(FirstNumber.Text, SecondNumber.Text);
                }
            };
        }


        private static int AddTwoStrings(string one, string two)
        {
            Int32.TryParse(one, out int iOne);
            Int32.TryParse(two, out int iTwo);
            return iOne + iTwo;
        }

        private static int SubsTwoStrings(string one, string two)
        {
            Int32.TryParse(one, out int iOne);
            Int32.TryParse(two, out int iTwo);
            return iOne - iTwo;
        }
    }
}