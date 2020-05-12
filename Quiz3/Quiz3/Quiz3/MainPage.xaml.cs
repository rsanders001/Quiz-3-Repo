using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quiz3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        string inputName = "";

        List<string> foodList = new List<string>();

        public MainPage()
        {
            InitializeComponent();

        }

        private void Name(object sender, EventArgs e)
        {
            inputName = responseName.Text;
            DisplayFoodList.Text = "";
            for (int i = 0; i < foodList.Count; i++)
            {
                var output = inputName + " Likes " + foodList[i];
                DisplayFoodList.Text += "\n" + output;
            }
        }

        private void DisplayListFood(object sender, EventArgs e)
        {
            foodList.Add(responseFood.Text);
            DisplayFoodList.Text = "";
            for (int i = 0; i < foodList.Count; i++)
            {
                var output = inputName + " Likes " + foodList[i];
                DisplayFoodList.Text += "\n" + output;
            }
        }
    }
}
