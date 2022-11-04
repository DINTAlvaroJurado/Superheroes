using Superheroes.models;
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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int pestaña = 1;
        int numSuper = 0;
        SolidColorBrush cl = new SolidColorBrush();

        List<Superheroe> sh = new List<Superheroe>();
        public MainWindow()
        {
            InitializeComponent();
            
            sh = Superheroe.GetSamples();
            contenedorDockPanel.DataContext = sh[numSuper];

            cambioHeroe();
        }

        public void cambioHeroe()
        {
            if (((Superheroe)contenedorDockPanel.DataContext).Vengador == true)
                compañiaPertenecienteImage.Visibility = Visibility.Visible;
            else
                compañiaPertenecienteImage.Visibility = Visibility.Collapsed;

            if (((Superheroe)contenedorDockPanel.DataContext).Xmen == true)
                compañiaPerteneciente2Image.Visibility = Visibility.Visible;
            else
                compañiaPerteneciente2Image.Visibility = Visibility.Collapsed;
            
            if (((Superheroe)contenedorDockPanel.DataContext).Heroe == true)
            {
                cl.Color = Colors.LightGreen;
                contenedorDockPanel.Background = cl;
            }
            else
            {
                cl.Color = Colors.IndianRed;
                contenedorDockPanel.Background = cl;
            }
                
        }

        private void leftArrowImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (pestaña > 1)
            {
                pestaña--;
                numSuper--;

                guiaPaginaTextBlock.Text = $"{pestaña}/3";
                contenedorDockPanel.DataContext = sh[numSuper];
                cambioHeroe();
            }  
        }

        private void rightArrowImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (pestaña < 3)
            {
                pestaña++;
                numSuper++;

                guiaPaginaTextBlock.Text = $"{pestaña}/3";
                contenedorDockPanel.DataContext = sh[numSuper];
                cambioHeroe();
            }
        }
    }
}
