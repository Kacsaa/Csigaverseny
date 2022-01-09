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
using System.IO;
using System.Windows.Threading;

namespace Csigaverseny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer idozites;
        int csigaszam1 = 21;
        int csigaszam2 = 21;
        int csigaszam3 = 21;

        public MainWindow()
        {
            InitializeComponent();
            idozites = new DispatcherTimer();
            idozites.Interval = TimeSpan.FromSeconds(0.3);
#pragma warning disable CS8622
            idozites.Tick += new EventHandler(Mozgascs);
#pragma warning restore CS8622
            ujfutam.IsEnabled = false;
        }

        private void Mozgascs(object sender, EventArgs e)
        {
            idozites.Start();
            start.IsEnabled = false;
            ujbajnoksag.IsEnabled = false;
            Random rnd = new Random();
            csigaszam1 += rnd.Next(20, 100);
            csiga1.Margin = new Thickness(csigaszam1,78,0,0);
            if (csigaszam1 > 779)
            {
                csiga1.Margin = new Thickness(779,78,0,0);
            }
            
            Random rnd2 = new Random();
            csigaszam2 += rnd2.Next(20, 100);
            csiga2.Margin = new Thickness(csigaszam2,267,0,0);
            if (csigaszam2 > 779)
            {
                csiga2.Margin = new Thickness(779,267,0,0);
            }
            
            Random rnd3 = new Random();
            csigaszam3 += rnd3.Next(20, 100);
            csiga3.Margin = new Thickness(csigaszam3,452,0,0);
            if (csigaszam3 > 810)
            {
                csiga3.Margin = new Thickness(810,452,0,0);
            }

            if (csiga1.Margin == new Thickness(779,78,0,0) && csiga2.Margin != new Thickness(779,267,0,0) && csiga3.Margin != new Thickness(810,452,0,0))
            {
                csut1.Opacity = 1;
                csut1.Fill = Brushes.Yellow;
                if (csiga2.Margin == new Thickness(722,267,0,0) && csiga3.Margin != new Thickness(810,452,0,0))
                {

                }
            }

            else if (csiga2.Margin != new Thickness(779,267,0,0)  && csiga1.Margin == new Thickness(779,78,0,0) && csiga3.Margin != new Thickness(810,452,0,0))
            {
                csut2.Opacity = 1;
                csut2.Fill = Brushes.Gray;
            }

            if (csiga1.Margin == new Thickness(779,78,0,0) && csiga2.Margin == new Thickness(779,267,0,0) && csiga3.Margin == new Thickness(810,452,0,0))
            {
                idozites.Stop();
                ujfutam.IsEnabled = true;
                ujbajnoksag.IsEnabled = true;
            }
        }

        private void Ujfutam(object sender, RoutedEventArgs e)
        {
            csiga1.Margin = new Thickness(21,78,0,0);
            csiga2.Margin = new Thickness(21,267,0,0);
            csiga3.Margin = new Thickness(21,452,0,0);
            start.IsEnabled = true;
            ujfutam.IsEnabled = false;
        }
    }
}
