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
using System.Windows.Shapes;

namespace RP_MN_I3_2024
{
    /// <summary>
    /// Interaction logic for Movie.xaml
    /// </summary>
    public partial class Movie : Window
    {
        bool StateClosed = true;
        public Movie()
        {
            InitializeComponent();
        }

        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            if (StateClosed)
            {
                Storyboard? sb = this.FindResource("OpenMenu") as Storyboard;
                sb?.Begin();
            }
            else
            {
                Storyboard? sb = this.FindResource("CloseMenu") as Storyboard;
                sb?.Begin();
            }

            StateClosed = !StateClosed;
        }
    }
}
