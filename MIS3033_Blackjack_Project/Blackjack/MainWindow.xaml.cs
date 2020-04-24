//John Niketas

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

namespace Blackjack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Deck newDeck = new Deck();
            newDeck.Shuffle();
            Card card1 = new Card();
            card1 = newDeck.Deal();
            lblCard1.Content = card1;

            newDeck.Shuffle();

            lblCard2.Content = newDeck.Deal();

            string dealtcard = "";

            dealtcard = lblCard1.Content.ToString();


            

            lblCardValue.Content = cardvalue;

        }

        private void btnNewCard_Click(object sender, RoutedEventArgs e)
        {
            Deck newDeck = new Deck();
            newDeck.Shuffle();
            string dealtcard = "";
            int cardvalue = 0;

            lblCard1.Content = newDeck.Deal();

            newDeck.Shuffle();

            lblCard2.Content = newDeck.Deal();

            dealtcard = lblCard1.Content.ToString();
            

            if (dealtcard.Contains("Two"))
            {
                cardvalue = 2;
            }
            else if (dealtcard.Contains("Three"))
            {
                cardvalue = 3;
            }
            else if (dealtcard.Contains("Four"))
            {
                cardvalue = 4;
            }
            else if (dealtcard.Contains("Five"))
            {
                cardvalue = 5;
            }
            else if (dealtcard.Contains("Six"))
            {
                cardvalue = 6;
            }
            else if (dealtcard.Contains("Seven"))
            {
                cardvalue = 7;
            }
            else if (dealtcard.Contains("Eight"))
            {
                cardvalue = 8;
            }
            else if (dealtcard.Contains("Nine"))
            {
                cardvalue = 9;
            }
            else if (dealtcard.Contains("Ten") || dealtcard.Contains("Jack") || dealtcard.Contains("Queen") || dealtcard.Contains("King"))
            {
                cardvalue = 10;
            }
            else if (dealtcard.Contains("Ace"))
            {
                cardvalue = 11;
            }

            lblCardValue.Content = cardvalue;



        }
    }
}
