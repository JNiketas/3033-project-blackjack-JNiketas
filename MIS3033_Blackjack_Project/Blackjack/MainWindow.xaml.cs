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

        Deck newDeck = new Deck();
        int counter = 0;

        public MainWindow()
        {
            InitializeComponent();

            lblDealer.Visibility = Visibility.Collapsed;
            lblDealerCard1.Visibility = Visibility.Collapsed;
            lblDealerCard2.Visibility = Visibility.Collapsed;
            btnRestart.Visibility = Visibility.Collapsed;
            lblPlayersCard1.Visibility = Visibility.Collapsed;
            lblPlayersCard2.Visibility = Visibility.Collapsed;
            lblPlayersCard3.Visibility = Visibility.Collapsed;
            lblPlayersCard4.Visibility = Visibility.Collapsed;
            lblPlayersCard5.Visibility = Visibility.Collapsed;
            btnHit.Visibility = Visibility.Collapsed;
            btnStand.Visibility = Visibility.Collapsed;


        }


        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btnStart.Visibility = Visibility.Collapsed;
            lblDealer.Visibility = Visibility.Visible;
            lblDealerCard1.Visibility = Visibility.Visible;
            lblDealerCard2.Visibility = Visibility.Visible;
            btnRestart.Visibility = Visibility.Visible;
            lblPlayersCard1.Visibility = Visibility.Visible;
            lblPlayersCard2.Visibility = Visibility.Visible;
            btnHit.Visibility = Visibility.Visible;
            btnStand.Visibility = Visibility.Visible;

            newDeck.Shuffle();
            Card DealerCard1 = new Card();
            DealerCard1 = newDeck.Deal();
            lblDealerCard1.Content = DealerCard1;

            newDeck.Shuffle();
            Card DealerCard2 = new Card();
            DealerCard2 = newDeck.Deal();
            lblDealerCard2.Content = DealerCard2;

            newDeck.Shuffle();
            Card PlayersCard1 = new Card();
            PlayersCard1 = newDeck.Deal();
            lblPlayersCard1.Content = PlayersCard1;

            newDeck.Shuffle();
            Card PlayersCard2 = new Card();
            PlayersCard2 = newDeck.Deal();
            lblPlayersCard2.Content = PlayersCard2;

        }

        private void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            
            newDeck.Shuffle();
            Card DealerCard1 = new Card();
            DealerCard1 = newDeck.Deal();
            lblDealerCard1.Content = DealerCard1;

            newDeck.Shuffle();
            Card DealerCard2 = new Card();
            DealerCard2 = newDeck.Deal();
            lblDealerCard2.Content = DealerCard2;

            newDeck.Shuffle();
            Card PlayersCard1 = new Card();
            PlayersCard1 = newDeck.Deal();
            lblPlayersCard1.Content = PlayersCard1;

            newDeck.Shuffle();
            Card PlayersCard2 = new Card();
            PlayersCard2 = newDeck.Deal();
            lblPlayersCard2.Content = PlayersCard2;

            lblPlayersCard3.Visibility = Visibility.Collapsed;
            lblPlayersCard4.Visibility = Visibility.Collapsed;
            lblPlayersCard5.Visibility = Visibility.Collapsed;

            counter = 0;
        }

        private void btnHit_Click(object sender, RoutedEventArgs e)
        {

            if (counter == 0)
            {
                lblPlayersCard3.Visibility = Visibility.Visible;

                newDeck.Shuffle();
                Card PlayersCard3 = new Card();
                PlayersCard3 = newDeck.Deal();
                lblPlayersCard3.Content = PlayersCard3;

                counter++;
            }
            else if (counter == 1)
            {
                lblPlayersCard4.Visibility = Visibility.Visible;

                newDeck.Shuffle();
                Card PlayersCard4 = new Card();
                PlayersCard4 = newDeck.Deal();
                lblPlayersCard4.Content = PlayersCard4;

                counter++;
            }

            else if (counter == 2)
            {
                lblPlayersCard5.Visibility = Visibility.Visible;

                newDeck.Shuffle();
                Card PlayersCard5 = new Card();
                PlayersCard5 = newDeck.Deal();
                lblPlayersCard5.Content = PlayersCard5;

                counter++;
            }


        }
    }
}
