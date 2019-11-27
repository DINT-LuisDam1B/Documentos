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

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NuevoDocumento_Button_Click(object sender, RoutedEventArgs e)
        {
            Documento documentoHijo = new Documento();
            documentoHijo.Owner = this;
            documentoHijo.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            documentoHijo.Title = "Documento " + this.OwnedWindows.Count.ToString();

            documentoHijo.Show();
        }

        private void Configuracion_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
