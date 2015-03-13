using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Niko_dr1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.LijeviBotun.Click += new RoutedEventHandler(LijeviBotun_Click);
            this.DesniBotun.Click += new RoutedEventHandler(DesniBotun_Click);
        }

        private void LijeviBotun_Click(object sender, RoutedEventArgs e)
        {
            this.LijeviStupac.Children.Add(new Rectangle()
            {
                Width = 60,
                Height = 60,
                Margin = new Thickness(10),
                Fill = _GetRandomBrush()
            });
        }

        private void DesniBotun_Click(object sender, RoutedEventArgs e)
        {
            this.DesniStupac.Children.Add(new Rectangle()
            {
                Height = 50,
                Width = 450,
                Margin = new Thickness(0, 10, 10, 0),
                Fill = _GetRandomBrush()
            });
        }

        private Brush _GetRandomBrush()
        {
            var random = new Random();

            var brushesType = typeof(Brushes);
            var properties = brushesType.GetProperties();

            var randomNumber = random.Next(properties.Length);

            return (Brush)properties[randomNumber].GetValue(null, null);
        }
    }
}
