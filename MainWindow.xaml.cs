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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RP_MN_I3_2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool StateClosed = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click()
        {

        }

        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            if (StateClosed)
            {
                Storyboard? sb = this.FindResource("OpenMenu") as Storyboard;
                sb?.Begin();
                HomeButton.Visibility = Visibility.Visible;
                WatchlistButton.Visibility = Visibility.Visible;
                AddMovieButton.Visibility = Visibility.Visible;
            }
            else
            {
                Storyboard? sb = this.FindResource("CloseMenu") as Storyboard;
                sb?.Begin();
                HomeButton.Visibility = Visibility.Hidden;
                WatchlistButton.Visibility = Visibility.Hidden;
                AddMovieButton.Visibility = Visibility.Hidden;
            }

            StateClosed = !StateClosed;
        }
    }
}
