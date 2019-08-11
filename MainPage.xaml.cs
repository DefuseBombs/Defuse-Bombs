using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DefuseBombs1
{
    public partial class MainPage : ContentPage
    {

        static string bomb = new Random().Next(1, 6).ToString(); //Create a String variable called bomb with a random number from 1 to 5 to randomly assign the button with the bomb.
        static int scores = 0; //Create an integer variable to represent the score.
        public MainPage()
        {
            InitializeComponent();
        }
        async void ButtonClicked(object sender, EventArgs e) // Create an Event Handler to when a button is clicked. "Sender" object contains the reference to the button clicked and the "EventArgs" contain the data associated with the object.
        {
            Button button = sender as Button;// Create a button in the method and set it as a Button Type, to access the attributes of the button.
            // create an if function to see if the user clicks a buton which contains the bomb.
            if (button.Text == bomb) //The If function if the user clicks the button with the bomb.
            {
                await DisplayAlert("Bomb Exploded", "Game Over", "Retry"); //Display an Alert with the Title "Bomb Exploded", with a message saying "Game Over", and cancel function to "Retry" the game.
                bomb = new Random().Next(1, 6).ToString(); //Assigning a random number after the user exploded the bomb.
                scores = 0; //Scores brought back to Zero.
                button.BackgroundColor = Color.Gray; //Change the colour of the button to gray when you click the button with the bomb.
                BackgroundColor = Color.Red; //Change the colour of the background to red when you click the button with the bomb.

            }
            else //If the user clicks a button which doesn't contain the bomb.
            {
                scores += 1; //The score will increase by one
                await DisplayAlert("Bomb Defused!", "Scores: " + scores, "Continue"); //an Alert will be displayed with the title ""Bomb Defused!", a message which shows the scores and a cancel button which says "Continue" to continue the game.
                bomb = new Random().Next(1, 6).ToString(); //Assigning a random number after the user exploded the bomb.
                button.BackgroundColor = Color.Green; // Change the colour of the button to green when you click the button.
                 BackgroundColor = Color.White; //Change the colour of the background to white when you click the button with the bomb.
            }
            

            
        }

   
    }
}
