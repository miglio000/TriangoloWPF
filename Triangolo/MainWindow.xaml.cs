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
using LibreriaClassificazioneTriangolo;
namespace Triangolo
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

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            double lato1, lato2, lato3, perimetro, semip, area, latomax, latomin;
            lblTipoTriangolo.Content = "";
            if (txtLato1.Text != " " && txtLato2.Text != " " && txtLato3.Text != " ")
            {
                try
                {
                    lato1 = double.Parse(txtLato1.Text);
                    lato2 = double.Parse(txtLato2.Text);
                    lato3 = double.Parse(txtLato3.Text);
                    latomax = Math.Max(lato1, Math.Max(lato2, lato3));
                    latomin = Math.Min(lato1, Math.Min(lato2, lato3));
                    if (lato1 < lato2 + lato3 && lato2 < lato1 + lato3 && lato3 < lato1 + lato2)
                    {
                        perimetro = Gestione.Perimetro(lato1, lato2, lato3);
                        lblPerimetro.Content = perimetro;
                        area = Gestione.Area(lato1, lato2, lato3);
                        lblArea.Content = area;
                        if (lato1 == lato2 && lato2 == lato3 && lato1 == lato3)
                        
                            lblTipoTriangolo.Content = "Equilatero";
                        
                        else if (lato1 == lato2 || lato1 == lato3 || lato2 == lato3)
                        
                            lblTipoTriangolo.Content = "Isoscele";
                        
                        else
                            lblTipoTriangolo.Content = "Scaleno";
                    }
                    else
                    {
                        MessageBox.Show("Non è un triangolo", "!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Not Valid", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Inserire dei valori", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
