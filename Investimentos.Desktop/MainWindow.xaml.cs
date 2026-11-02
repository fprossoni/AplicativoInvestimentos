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

namespace Investimentos.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const double ALTURA_PADRAO = 800;
        private const double LARGURA_PADRAO = 1280;

        public MainWindow()
        {
            InitializeComponent();

            Width = ALTURA_PADRAO;
            Height = LARGURA_PADRAO;
        }
    }
}