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

namespace galeriaWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ImageSource> characters = new List<ImageSource>();
        int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            characters.Add(new BitmapImage(new Uri("carlotta.png", UriKind.Relative)));
            characters.Add(new BitmapImage(new Uri("chixia.png", UriKind.Relative)));
            characters.Add(new BitmapImage(new Uri("yangyang.png", UriKind.Relative)));
            characters.Add(new BitmapImage(new Uri("yinlin.png", UriKind.Relative)));
        }

        private void left(object sender, RoutedEventArgs e)
        {
            if(counter == 0)
            {
                counter = characters.Count-1;
            }
            else
            {
                counter--;
            }
            sout();
        }

        private void right(object sender, RoutedEventArgs e)
        {
            if(counter == characters.Count-1)
            {
                counter = 0;
            }
            else
            {
                counter++;
            }
            sout();
        }
        void sout()
        {
            image.Source = characters[counter];
        }
    }
}
