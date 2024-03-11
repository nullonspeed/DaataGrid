using DataLayerLib;
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

namespace DaataGrid
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
            try
            {
                HospitalDBContext context = new HospitalDBContext();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                int numEx = context.Examinations.Count();
                Title = numEx.ToString();
            }
            catch(Exception ex) { 
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}