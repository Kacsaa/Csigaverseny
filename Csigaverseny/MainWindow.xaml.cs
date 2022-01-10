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
        int pontszam1 = 0;
        int pontszam2 = 0;
        int pontszam3 = 0;

        public MainWindow()
        {
            InitializeComponent();
            idozites = new DispatcherTimer();
            idozites.Interval = TimeSpan.FromSeconds(0.2);
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
            Random rnd1 = new Random();
            csigaszam1 += rnd1.Next(10, 100);
            csiga1.Margin = new Thickness(csigaszam1,78,0,0);
            if (csigaszam1 > 779)
            {
                csiga1.Margin = new Thickness(779,78,0,0);
            }
            
            Random rnd2 = new Random();
            csigaszam2 += rnd2.Next(10, 100);
            csiga2.Margin = new Thickness(csigaszam2,267,0,0);
            if (csigaszam2 > 779)
            {
                csiga2.Margin = new Thickness(779,267,0,0);
            }
            
            Random rnd3 = new Random();
            csigaszam3 += rnd3.Next(10, 100);
            csiga3.Margin = new Thickness(csigaszam3,452,0,0);
            if (csigaszam3 > 810)
            {
                csiga3.Margin = new Thickness(810,452,0,0);
            }

            if (csiga1.Margin == new Thickness(779,78,0,0) && csiga2.Margin != new Thickness(779,267,0,0) && csiga3.Margin != new Thickness(810,452,0,0))
            {
                csut1.Opacity = 1;
                csut1.Fill = Brushes.Yellow;
                pontszam1 += 3;
                if (csiga2.Margin == new Thickness(722,267,0,0) && csiga3.Margin != new Thickness(810,452,0,0))
                {
                    csut2.Opacity = 1;
                    csut2.Fill = Brushes.Gray;
                    csut3.Opacity = 1;
                    csut3.Fill = Brushes.Orange;
                }
                else if (csiga3.Margin == new Thickness(810,452,0,0) && csiga2.Margin != new Thickness(779,267,0,0))
                {
                    csut3.Opacity = 1;
                    csut3.Fill = Brushes.Gray;
                    csut2.Opacity = 1;
                    csut2.Fill = Brushes.Orange;
                }
            }

            else if (csiga2.Margin == new Thickness(779,267,0,0)  && csiga1.Margin != new Thickness(779,78,0,0) && csiga3.Margin != new Thickness(810,452,0,0))
            {
                csut2.Opacity = 1;
                csut2.Fill = Brushes.Yellow;
                pontszam2 += 3;
                if (csiga1.Margin == new Thickness(779,78,0,0) && csiga3.Margin != new Thickness(810,452,0,0))
                {
                    csut1.Opacity = 1;
                    csut1.Fill = Brushes.Gray;
                    csut3.Opacity = 1;
                    csut3.Fill = Brushes.Orange;
                }
                else if (csiga3.Margin == new Thickness(810,452,0,0) && csiga1.Margin != new Thickness(779,78,0,0))
                {
                    csut3.Opacity = 1;
                    csut3.Fill = Brushes.Gray;
                    csut1.Opacity = 1;
                    csut1.Fill = Brushes.Orange;
                }
            }

            else if (csiga3.Margin == new Thickness(810,452,0,0) && csiga1.Margin != new Thickness(779,78,0,0) && csiga2.Margin != new Thickness(779,267,0,0))
            {
                csut3.Opacity = 1;
                csut3.Fill = Brushes.Yellow;
                pontszam3 += 3;
                if (csiga1.Margin == new Thickness(779,78,0,0) && csiga2.Margin != new Thickness(779,267,0,0))
                {
                    csut1.Opacity = 1;
                    csut1.Fill = Brushes.Gray;
                    csut2.Opacity = 1;
                    csut2.Fill = Brushes.Orange;
                }
                else if (csiga2.Margin == new Thickness(779,267,0,0) && csiga1.Margin != new Thickness(779,78,0,0))
                {
                    csut2.Opacity = 1;
                    csut2.Fill = Brushes.Gray;
                    csut1.Opacity = 1;
                    csut1.Fill = Brushes.Orange;
                }
            }

            if (csiga1.Margin == new Thickness(779,78,0,0) && csiga2.Margin == new Thickness(779,267,0,0) && csiga3.Margin == new Thickness(810,452,0,0))
            {
                idozites.Stop();
                pontok1.Content = pontszam1;
                pontok2.Content = pontszam2;
                pontok3.Content = pontszam3;
                hely.Opacity = 1;
                nev.Opacity = 1;
                pont.Opacity = 1;
                pontok1.Opacity = 1;
                pontok2.Opacity = 1;
                pontok3.Opacity = 1;
                helyezes1.Opacity = 1;
                helyezes2.Opacity = 1;
                helyezes3.Opacity = 1;
                hely1.Opacity = 1;
                hely2.Opacity = 1;
                hely3.Opacity = 1;
                elsohelyek1.Opacity = 1;
                elsohelyek2.Opacity = 1;
                elsohelyek3.Opacity = 1;
                masodikhelyek1.Opacity = 1;
                masodikhelyek2.Opacity = 1;
                masodikhelyek3.Opacity = 1;
                harmadikhelyek1.Opacity = 1;
                harmadikhelyek2.Opacity = 1;
                harmadikhelyek3.Opacity = 1;
                ujfutam.IsEnabled = true;
                ujbajnoksag.IsEnabled = true;
            }
        }

        private void Ujfutam(object sender, RoutedEventArgs e)
        {
            csiga1.Margin = new Thickness(21,78,0,0);
            csiga2.Margin = new Thickness(21,267,0,0);
            csiga3.Margin = new Thickness(21,452,0,0);
            csigaszam1 = 21;
            csigaszam2 = 21;
            csigaszam3 = 21;
            csut1.Opacity = 0;
            csut2.Opacity = 0;
            csut3.Opacity = 0;
            start.IsEnabled = true;
            ujfutam.IsEnabled = false;
        }

        private void Ujbajnoksag(object sender, RoutedEventArgs e)
        {
            hely.Opacity = 0;
            nev.Opacity = 0;
            pont.Opacity = 0;
            pontok1.Opacity = 0;
            pontok2.Opacity = 0;
            pontok3.Opacity = 0;
            helyezes1.Opacity = 0;
            helyezes2.Opacity = 0;
            helyezes3.Opacity = 0;
            hely1.Opacity = 0;
            hely2.Opacity = 0;
            hely3.Opacity = 0;
            elsohelyek1.Opacity = 0;
            elsohelyek2.Opacity = 0;
            elsohelyek3.Opacity = 0;
            masodikhelyek1.Opacity = 0;
            masodikhelyek2.Opacity = 0;
            masodikhelyek3.Opacity = 0;
            harmadikhelyek1.Opacity = 0;
            harmadikhelyek2.Opacity = 0;
            harmadikhelyek3.Opacity = 0;
            pontok1.Content = " ";
            pontok2.Content = " ";
            pontok3.Content = " ";
            helyezes1.Content = " ";
            helyezes2.Content = " ";
            helyezes3.Content = " ";
            hely1.Content = " ";
            hely2.Content = " ";
            hely3.Content = " ";
            elsohelyek1.Content = " ";
            elsohelyek2.Content = " ";
            elsohelyek3.Content = " ";
            masodikhelyek1.Content = " ";
            masodikhelyek2.Content = " ";
            masodikhelyek3.Content = " ";
            harmadikhelyek1.Content = " ";
            harmadikhelyek2.Content = " ";
            harmadikhelyek3.Content = " ";
            csigaszam1 = 21;
            csigaszam2 = 21;
            csigaszam3 = 21;
            csiga1.Margin = new Thickness(21,78,0,0);
            csiga2.Margin = new Thickness(21,267,0,0);
            csiga3.Margin = new Thickness(21,452,0,0);
            csut1.Opacity = 0;
            csut2.Opacity = 0;
            csut3.Opacity = 0;
            
            start.IsEnabled = true;
            ujfutam.IsEnabled = false;
            ujbajnoksag.IsEnabled = true;
        }
    }
}
